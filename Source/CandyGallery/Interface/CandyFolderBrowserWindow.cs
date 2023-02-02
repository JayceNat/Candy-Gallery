using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandyGallery.Helpers;
using CandyGallery.Models;

namespace CandyGallery.Interface
{
    public partial class CandyFolderBrowserWindow : Form
    {
        #region Initialization

        ////////// Used to make form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        ////////// Used to make form draggable

        public string FolderPathToLoad = Program.CandyGalleryWindow.UserSettings.StartFolderPath;
        public string CurrentFolderBeingViewed = "";
        public bool FormMaximized = false;
        public System.Drawing.Image errorImg = Program.CandyGalleryWindow.picBxCandyGallery.ErrorImage;
        private int nTileSize = 256;

        public enum HRESULT : int
        {
            S_OK = 0,
            S_FALSE = 1,
            E_NOINTERFACE = unchecked((int)0x80004002),
            E_NOTIMPL = unchecked((int)0x80004001),
            E_FAIL = unchecked((int)0x80004005),
            E_UNEXPECTED = unchecked((int)0x8000FFFF),
            E_OUTOFMEMORY = unchecked((int)0x8007000E)
        }

        [ComImport()]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("e357fccd-a995-4576-b01f-234630154e96")]
        public interface IThumbnailProvider
        {
            HRESULT GetThumbnail(uint cx, out IntPtr phbmp, out WTS_ALPHATYPE pdwAlpha);
        }

        public enum WTS_ALPHATYPE
        {
            WTSAT_UNKNOWN = 0,
            WTSAT_RGB = 1,
            WTSAT_ARGB = 2
        }

        [ComImport()]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
        public interface IShellItem
        {
            [PreserveSig()]
            HRESULT BindToHandler(IntPtr pbc, ref Guid bhid, ref Guid riid, ref IntPtr ppv);
            HRESULT GetParent(ref IShellItem ppsi);
            HRESULT GetDisplayName(SIGDN sigdnName, ref System.Text.StringBuilder ppszName);
            HRESULT GetAttributes(uint sfgaoMask, ref uint psfgaoAttribs);
            HRESULT Compare(IShellItem psi, uint hint, ref int piOrder);
        }

        public enum SIGDN : int
        {
            SIGDN_NORMALDISPLAY = 0x0,
            SIGDN_PARENTRELATIVEPARSING = unchecked((int)0x80018001),
            SIGDN_DESKTOPABSOLUTEPARSING = unchecked((int)0x80028000),
            SIGDN_PARENTRELATIVEEDITING = unchecked((int)0x80031001),
            SIGDN_DESKTOPABSOLUTEEDITING = unchecked((int)0x8004C000),
            SIGDN_FILESYSPATH = unchecked((int)0x80058000),
            SIGDN_URL = unchecked((int)0x80068000),
            SIGDN_PARENTRELATIVEFORADDRESSBAR = unchecked((int)0x8007C001),
            SIGDN_PARENTRELATIVE = unchecked((int)0x80080001)
        }

        [DllImport("Shell32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern HRESULT SHCreateItemFromParsingName(string pszPath, IntPtr pbc, [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IShellItem ppv);

        [DllImport("Gdi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        public static Guid BHID_ThumbnailHandler = new Guid("7b2e650a-8e20-4f4a-b09e-6597afc72fb0");

        #endregion

        public CandyFolderBrowserWindow()
        {
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
            InitializeComponent();
            SetFormColors();
            SetPictureBoxContextStrips();
            Shown += CandyMultiRandomWindow_Shown;
        }

        private void CandyMultiRandomWindow_Shown(object sender, EventArgs e)
        {
            SetListViewer(FolderPathToLoad);
        }

        public void SetListViewer(string folderPath)
        {
            var cursor = Cursors.Default;
            Cursor.Current = Cursors.WaitCursor;

            listViewFolderBrowser.Clear();
            var imageList = new ImageList();
            imageList.ImageSize = new Size(nTileSize, nTileSize);
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            listViewFolderBrowser.View = View.Tile;
            listViewFolderBrowser.TileSize = new Size(nTileSize*2, nTileSize);
            listViewFolderBrowser.LargeImageList = imageList;

            CurrentFolderBeingViewed = folderPath;
            //await Task.Run(() => SetBrowserIcons(folderPath, imageList));
            SetBrowserIcons(folderPath, imageList);

            Cursor.Current = cursor;
        }

        private void SetBrowserIcons(string folderPath, ImageList imageList)
        {
            var directories = Directory.GetDirectories(folderPath);
            var files = Directory.GetFiles(folderPath);
            var counter = 1;

            if (directories?.Any() == true)
            {
                foreach (var dir in directories)
                {
                    var cardThumb = GetFirstItemInDirectoryItemPath(dir, imageList);
                    if (CandyGalleryHelpers.IsImageTypeMedia(cardThumb))
                    {
                        var listViewItem = new ListViewItem();
                        var cardName = folderPath.EndsWith("\\") ? cardThumb?.Replace(folderPath, "") : cardThumb?.Replace(folderPath + "\\", "");
                        cardName = cardName?.Remove(cardName.IndexOf("\\"));

                        listViewItem.Text = cardName;
                        listViewItem.ImageIndex = counter - 1;
                        listViewItem.ToolTipText = cardThumb;
                        listViewItem.Name = cardName;
                        listViewItem.Tag = folderPath + "\\" + cardName;                      

                        var bmpThumb = CandyGalleryHelpers.GetThumbnailFromFile(cardThumb);
                        if (Program.CandyGalleryWindow.UserSettings.ApplyImageFilter && Program.CandyGalleryWindow.UserSettings.ApplyFilterToSubWindows) bmpThumb = Program.CandyGalleryWindow.ApplyFilterToImage(bmpThumb, 4);
                        bmpThumb = CandyGalleryHelpers.ResizeImage(bmpThumb, nTileSize, nTileSize);

                        //Invoke(new Action(() => {
                        imageList.Images.Add(bmpThumb);

                        listViewFolderBrowser.Items.Add(new ListViewItem
                        {
                            ImageIndex = counter - 1,
                            Text = cardName,
                            Tag = folderPath + "\\" + cardName
                        });

                        counter++;
                        //}));
                    }
                }
                //Invoke(new Action(() => { listViewFolderBrowser.Sort(); }));
                listViewFolderBrowser.Sort();
            }

            if (files?.Any() == true)
            {
                foreach (var file in files)
                {
                    var cardThumb = file;
                    if (CandyGalleryHelpers.IsImageTypeMedia(cardThumb))
                    {
                        var listViewItem = new ListViewItem();
                        var cardName = folderPath.EndsWith("\\") ? cardThumb?.Replace(folderPath, "") : cardThumb?.Replace(folderPath + "\\", "");

                        listViewItem.Text = cardName;
                        listViewItem.ImageIndex = counter - 1;
                        listViewItem.ToolTipText = cardThumb;
                        listViewItem.Name = cardName;
                        listViewItem.Tag = folderPath + "\\" + cardName;

                        var bmpThumb = CandyGalleryHelpers.GetThumbnailFromFile(cardThumb);
                        if (Program.CandyGalleryWindow.UserSettings.ApplyImageFilter && Program.CandyGalleryWindow.UserSettings.ApplyFilterToSubWindows) bmpThumb = Program.CandyGalleryWindow.ApplyFilterToImage(bmpThumb, 4);
                        bmpThumb = CandyGalleryHelpers.ResizeImage(bmpThumb, nTileSize, nTileSize);

                        //Invoke(new Action(() => {
                        imageList.Images.Add(bmpThumb);

                        listViewFolderBrowser.Items.Add(new ListViewItem
                        {
                            ImageIndex = counter - 1,
                            Text = cardName,
                            Tag = folderPath + "\\" + cardName
                        });

                        counter++;
                        //}));
                    }
                }
                //Invoke(new Action(() => { listViewFolderBrowser.Sort(); }));
                listViewFolderBrowser.Sort();
            }
        }

        private string GetFirstItemInDirectoryItemPath(string folderPath, ImageList imageList)
        {
            var files = Directory.GetFiles(folderPath);
            var directory = Directory.GetDirectories(folderPath);

            if (files?.Any() == true)
            {
                return files.FirstOrDefault();
            }
            else if (directory?.Any() == true)
            {
                return GetFirstItemInDirectoryItemPath(directory?.First(), imageList);
            }
            else
            {
                return null;
            }
        }

        public void CandyMultiRandomWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            var focusedItem = listViewFolderBrowser.FocusedItem;
            if (focusedItem != null)
            {
                var folder = listViewFolderBrowser.FocusedItem.Tag.ToString();
                if (folder?.Any() == true)
                {
                    if (CandyGalleryHelpers.IsImageTypeMedia(folder) || CandyGalleryHelpers.IsGifTypeMedia(folder) || CandyGalleryHelpers.IsVideoTypeMedia(folder))
                    {
                        btnExitFolderBrowser.PerformClick();
                        Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(folder);
                    }
                    else
                    {
                        SetListViewer(folder);
                    }
                }
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CurrentFolderBeingViewed) && CurrentFolderBeingViewed != Program.CandyGalleryWindow.UserSettings.StartFolderPath)
            {
                var parentFolder = Directory.GetParent(CurrentFolderBeingViewed)?.FullName;
                SetListViewer(parentFolder);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SetListViewer(Program.CandyGalleryWindow.UserSettings.StartFolderPath);
        }

        private void SetFavorite_Click(object sender, EventArgs e)
        {
            var focusedItem = listViewFolderBrowser.FocusedItem;
            if (focusedItem != null)
            {
                var folder = listViewFolderBrowser.FocusedItem.Tag.ToString();
                if (folder?.Any() == true)
                {
                    if (CandyGalleryHelpers.IsImageTypeMedia(folder) || CandyGalleryHelpers.IsGifTypeMedia(folder) || CandyGalleryHelpers.IsVideoTypeMedia(folder))
                    {
                        var itemName = new DirectoryInfo(folder).Name;
                        var nonZeroIndex = Program.CandyGalleryWindow.UserSettings.UserFavorites.Count + 1;
                        var newFavorite = new UserFavorite
                        {
                            Index = nonZeroIndex,
                            FullPath = folder,
                            MediaType = CandyGalleryHelpers.IsImageTypeMedia(folder) ? MediaFilterType.Image : MediaFilterType.Gif
                        };
                        Program.CandyGalleryWindow.UserSettings.UserFavorites.Add(newFavorite);
                        DeselectMediaSelection();
                        //MessageBox.Show($@"Created a new favorite for ""{itemName}"" as Favorite #{nonZeroIndex}!",
                        //    @"Favorite Created!", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ExitMultiRandom_Click(object sender, EventArgs e)
        {
            Program.CandyGalleryWindow.UserSettings.PerSessionSettings.ChildWindowOpen = false;
            Dispose();
            Close();
        }

        private void MaximizeMultiRandom_Click(object sender, EventArgs e)
        {
            if (FormMaximized)
            {
                MinimizeForm();
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                FormMaximized = true;
            }
        }

        #region ListView Click Handling

        private void ListViewMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var focusedItem = listViewFolderBrowser.FocusedItem;
            if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
            {
                var folder = listViewFolderBrowser.FocusedItem.Tag.ToString();
                if (folder?.Any() == true)
                {
                    if (CandyGalleryHelpers.IsImageTypeMedia(folder) || CandyGalleryHelpers.IsGifTypeMedia(folder) || CandyGalleryHelpers.IsVideoTypeMedia(folder))
                    {
                        btnExitFolderBrowser.PerformClick();
                        Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(folder);
                    }
                    else
                    {
                        SetListViewer(folder);
                    }
                }
            }
        }

        private void AddToMainViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!(sender is ToolStripMenuItem menuItem)) return;
            //if (!(menuItem.GetCurrentParent() is ContextMenuStrip contextMenu)) return;
            //if (contextMenu.SourceControl is PictureBox pictureBox)
            //{
            //    var id = pictureBox.Name.Remove(0, nameLength);
            //    var matchingLocation = GetMatchingImgLocation(id);
            //    if (!string.IsNullOrEmpty(matchingLocation))
            //    {
            //        Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(matchingLocation);
            //        RemoveImgLocation(id);
            //        pictureBox.ImageLocation = null;
            //        pictureBox.Image = pictureBox.InitialImage;
            //        DeselectMediaSelection();
            //    }
            //}
        }

        private void SetAsUserAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Helper Methods

        private void MinimizeForm()
        {
            WindowState = FormWindowState.Normal;
            FormMaximized = false;
        }

        private void DeselectMediaSelection()
        {
            listViewFolderBrowser.FocusedItem = null;
        }

        private void SetFormColors()
        {
            lblCandyFolderBrowserTitle.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnGoBack.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnReset.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnSetFavorite.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnOpen.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
        }

        private void SetPictureBoxContextStrips()
        {
           
        }

        #endregion

        #region Keyboard Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var matchedShortcut = Program.CandyGalleryWindow.UserSettings.KeyboardShortcuts.FirstOrDefault(x => x.Key == keyData.ToString());
            if (matchedShortcut == null) return base.ProcessCmdKey(ref msg, keyData);
            switch (matchedShortcut.Action)
            {
                case ShortcutActionType.Enter:
                case ShortcutActionType.Randomize:
                case ShortcutActionType.NextImage:
                    btnOpen.PerformClick();
                    return true;
                case ShortcutActionType.MaximizeWindow:
                case ShortcutActionType.FullscreenMedia:
                    btnMaximizeFolderBrowser.PerformClick();
                    return true;
                case ShortcutActionType.Escape:
                    if (!string.IsNullOrWhiteSpace(listViewFolderBrowser?.FocusedItem?.Text))
                    {
                        DeselectMediaSelection();
                        return true;
                    }
                    if (FormMaximized && !Program.CandyGalleryWindow.UserSettings.PerSessionSettings.GalleryMaximized)
                    {
                        MinimizeForm();
                        return true;
                    }
                    btnExitFolderBrowser.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
