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
    }
}