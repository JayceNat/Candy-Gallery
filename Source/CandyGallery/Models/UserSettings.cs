using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CandyGallery.Models
{
    [Serializable]
    public class UserSettings
    {
        public string UserName { get; set; } = "admin";

        public string Pass { get; set; } = "admin";

        public string StartFolderPath { get; set; }

        public string UserInterfaceColorName { get; set; } = "Cherry";

        public bool ApplyColorToRandomizeButton { get; set; } = false;

        public int UserAvatarKey { get; set; } = 1;

        [XmlArray(nameof(UserFavorites))]
        [XmlArrayItem(nameof(UserFavorite))]
        public List<UserFavorite> UserFavorites { get; set; } = new List<UserFavorite>();

        [XmlArray(nameof(SessionHistory))]
        [XmlArrayItem("HistoryItem")]
        public List<string> SessionHistory { get; set; }

        [XmlArray(nameof(UnseenItems))]
        [XmlArrayItem("UnseenItem")]
        public List<string> UnseenItems { get; set; } = new List<string>();

        public bool PreserveSessionHistory { get; set; } = true;
        
        public bool EncryptSettingsFile { get; set; } = true;

        public bool FullscreenVideosOnOpen { get; set; } = false;

        public bool SidePanelCollapsed { get; set; } = false;

        public string CurrentMediaTypeToDisplay { get; set; } = MediaFilterType.All;

        public int LimitCurrentMediaCount { get; set; } = 30;

        public bool IncludeImageMediaType { get; set; } = true;

        public bool IncludeVideoMediaType { get; set; } = true;

        public bool IncludeShortcutMediaType { get; set; } = true;

        public bool IncludeGifMediaType { get; set; } = true;

        public string ImageFilterType { get; set; } = Models.ImageFilterType.Blur;

        public int ImageFilterAmount { get; set; } = 20;

        public bool ApplyFilterToSubWindows { get; set; } = false;

        public bool ApplyImageFilter { get; set; } = false;

        public int SlideShowSpeed { get; set; } = 5;

        [XmlIgnore]
        public PerSessionSettings PerSessionSettings { get; set; } = new PerSessionSettings();
    }
}