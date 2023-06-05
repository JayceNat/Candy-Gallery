using System;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using System.Xml.Serialization;
using CandyGallery.Interface;
using CandyGallery.Models;
using Microsoft.Win32;

namespace CandyGallery
{
    internal class Program
    {
        public static CandyGalleryWindow CandyGalleryWindow;
        public static XmlSerializer UserSettingsSerializer = new XmlSerializer(typeof(UserSettings));
        public static bool IsAdministrator()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        public Program(XmlSerializer userSettingsSerializer)
        {
            UserSettingsSerializer = userSettingsSerializer;
        }

        [STAThread]
        private static void Main()
        {
            // Requires being run as admin
            if (IsAdministrator())
            {
                CheckFontInstall("Magneto.ttf");
            }

            Application.Run(new LoginWindow());
        }

        [DllImport("gdi32", EntryPoint = "AddFontResource")]
        public static extern int AddFontResourceA(string lpFileName);
        [DllImport("gdi32.dll")]
        private static extern int AddFontResource(string lpszFilename);
        [DllImport("gdi32.dll")]
        private static extern int CreateScalableFontResource(uint fdwHidden, string
            lpszFontRes, string lpszFontFile, string lpszCurrentPath);

        /// <summary>
        /// Installs font on the user's system and adds it to the registry so it's available on the next session
        /// Your font must be included in your project with its build path set to 'Content' and its Copy property
        /// set to 'Copy Always'
        /// </summary>
        /// <param name="contentFontName">Your font to be passed as a resource (i.e. "myfont.tff")</param>
        private static void CheckFontInstall(string contentFontName)
        {
            // Creates the full path where your font will be installed
            var fontDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), contentFontName);

            if (!File.Exists(fontDestination))
            {
                try
                {
                    // Copies font to destination
                    File.Copy(Path.Combine(Application.StartupPath, contentFontName), fontDestination);

                    // Retrieves font name
                    // Makes sure you reference System.Drawing
                    PrivateFontCollection fontCol = new PrivateFontCollection();
                    fontCol.AddFontFile(fontDestination);
                    var actualFontName = fontCol.Families[0].Name;

                    //Add font
                    AddFontResource(fontDestination);
                    //Add registry entry   
                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", actualFontName, contentFontName, RegistryValueKind.String);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Failed to install 'Magneto.ttf' font...", "Candy Gallery: Font Install Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
