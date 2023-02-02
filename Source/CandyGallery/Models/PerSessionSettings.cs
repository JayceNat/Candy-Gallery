using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CandyGallery.Models
{
    public class PerSessionSettings
    {
        public string CurrentWorkingDirectory { get; set; }
        public string OriginalUsername { get; set; }
        public string FullPathToCurrentSettingsFile { get; set; }
        public bool EnableHotKeys { get; set; } = true;
        public bool GalleryMaximized { get; set; } = false;
        public bool PictureBoxMaximized { get; set; } = false;
        public bool RunSlideshow { get; set; } = false;
        public Control ControlParentToRestoreViewForMaximizedPicture { get; set; }
        public Control ControlParentToRestoreViewForSidePanel { get; set; }
        public BorderStyle DefaultBorderStyle { get; set; } = BorderStyle.FixedSingle;
        public Color BackgroundColor { get; set; } = Color.FromArgb(32, 32, 32);
        public List<string> ForwardList { get; set; } = new List<string>();
        public List<string> BackList { get; set; } = new List<string>();
        public bool UserHasVideosFolder { get; set; } = false;
        public bool UserHasGifsFolder { get; set; } = false;
        public bool UserHasOtherFolder { get; set; } = false;
        public List<string> NewestMediaList { get; set; } = new List<string>();
        public List<string> OldestMediaList { get; set; } = new List<string>();
        public bool LoadedSettingsFileWasEncrypted { get; set; } = true;
        public bool StartFolderMissingOnLoad { get; set; } = false;
        public bool ChildWindowOpen { get; set; } = false;
        public bool ResetCandyGallery { get; set; } = false;
    }
}