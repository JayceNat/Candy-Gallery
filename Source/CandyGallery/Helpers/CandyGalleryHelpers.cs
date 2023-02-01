using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using static CandyGallery.Interface.CandyFolderBrowserWindow;
using System.Drawing;

namespace CandyGallery.Helpers
{
    public class CandyGalleryHelpers
    {
        public static bool IsImageTypeMedia(string mediaItem)
        {
            return mediaItem.ToLower().EndsWith(".jpg")
                   || mediaItem.ToLower().EndsWith(".jpeg")
                   || mediaItem.ToLower().EndsWith(".tiff")
                   || mediaItem.ToLower().EndsWith(".img")
                   || mediaItem.ToLower().EndsWith(".bmp")
                   || mediaItem.ToLower().EndsWith(".jfif")
                   || mediaItem.ToLower().EndsWith(".exif")
                   || mediaItem.ToLower().EndsWith(".png")
                   || mediaItem.ToLower().EndsWith(".ico")
                   || mediaItem.ToLower().EndsWith(".svg");
        }

        public static bool IsGifTypeMedia(string mediaItem)
        {
            return mediaItem.ToLower().EndsWith(".gif");
        }

        public static bool IsVideoTypeMedia(string mediaItem)
        {
            return mediaItem.ToLower().EndsWith(".mp4")
                   || mediaItem.ToLower().EndsWith(".mkv")
                   || mediaItem.ToLower().EndsWith(".flv")
                   || mediaItem.ToLower().EndsWith(".avi")
                   || mediaItem.ToLower().EndsWith(".m4v")
                   || mediaItem.ToLower().EndsWith(".svi");
        }

        public static bool IsShortcutTypeMedia(string mediaItem)
        {
            return mediaItem.ToLower().EndsWith(".lnk");
        }

        public static void SetUserAvatarByPath(string filePath)
        {
            if (File.Exists(filePath))
            {
                Program.CandyGalleryWindow.UserSettings.UsingCustomAvatar = true;
                var appPath = Application.StartupPath;
                var settingsFolder = "\\CandyGalleryUserSettings\\";
                Directory.CreateDirectory(appPath + settingsFolder);
                File.Copy(filePath, Path.Combine(appPath + settingsFolder, Program.CandyGalleryWindow.UserSettings.UserName + @"_CustomAvatar"), true);
                Program.CandyGalleryWindow.picBxUserAvatar.ImageLocation = filePath;
            }
        }

        public static Cursor LoadCustomCursor()
        {
            var curs = Cursors.Default;
            var cursorLocation = Path.Combine(Application.StartupPath, @"Cursor.ani");
            if (File.Exists(cursorLocation))
            {
                IntPtr hCurs = LoadCursorFromFile(cursorLocation);
                if (hCurs == IntPtr.Zero) throw new Win32Exception();
                curs = new Cursor(hCurs);
                // Note: force the cursor to own the handle so it gets released properly
                var fi = typeof(Cursor).GetField("ownHandle", BindingFlags.NonPublic | BindingFlags.Instance);
                fi.SetValue(curs, true);
            }
            return curs;
        }
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr LoadCursorFromFile(string path);

        public static Bitmap GetThumbnailFromFile(string sFile, uint nSize = 256)
        {
            Bitmap bitmap = null;
            IntPtr hThumbnail;
            IShellItem pShellItem;
            HRESULT hr = SHCreateItemFromParsingName(sFile, IntPtr.Zero, typeof(IShellItem).GUID, out pShellItem);
            if (hr == HRESULT.S_OK)
            {
                IThumbnailProvider pThumbProvider = null;
                IntPtr pThumbProviderPtr = IntPtr.Zero;
                hr = pShellItem.BindToHandler(IntPtr.Zero, BHID_ThumbnailHandler, typeof(IThumbnailProvider).GUID, ref pThumbProviderPtr);
                if (hr == HRESULT.S_OK)
                {
                    pThumbProvider = Marshal.GetObjectForIUnknown(pThumbProviderPtr) as IThumbnailProvider;
                    if (pThumbProvider != null)
                    {
                        WTS_ALPHATYPE wtsAlpha;
                        hr = pThumbProvider.GetThumbnail(nSize, out hThumbnail, out wtsAlpha);
                        if (hr == HRESULT.S_OK)
                        {
                            bitmap = System.Drawing.Image.FromHbitmap(hThumbnail);
                            DeleteObject(hThumbnail);
                        }
                        Marshal.ReleaseComObject(pThumbProvider);
                    }
                }
                Marshal.ReleaseComObject(pShellItem);
            }
            return bitmap;
        }

        public static Bitmap ResizeImage(System.Drawing.Image image, int width = 256, int height = 256)
        {
            var destRect = new Rectangle(((width - image.Width) / 2), ((height - image.Height) / 2), image.Width, image.Height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                //graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            }
            return destImage;
        }
    }
}