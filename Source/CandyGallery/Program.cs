using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using CandyGallery.Interface;
using CandyGallery.Models;

namespace CandyGallery
{
    internal class Program
    {
        public static CandyGalleryWindow CandyGalleryWindow;
        public static XmlSerializer UserSettingsSerializer = new XmlSerializer(typeof(UserSettings));

        public Program(XmlSerializer userSettingsSerializer)
        {
            UserSettingsSerializer = userSettingsSerializer;
        }

        [STAThread]
        private static void Main()
        {
            Application.Run(new LoginWindow());
        }
    }
}
