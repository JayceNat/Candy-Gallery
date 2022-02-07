using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;

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
    }
}