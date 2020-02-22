using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using CandyGallery.Models;
using static System.Text.Encoding;
using Convert = System.Convert;

namespace CandyGallery.Serialization
{
    public class SaveLoadSettingsHandler
    {
        public static UserSettings TryLoadUserSettings(string username, string password)
        {
            var appPath = Application.StartupPath;
            var userSettings = new UserSettings { UserName = username, Pass = password };
            var saveFile = $"{appPath}\\CandyGalleryUserSettings\\{username.ToLower()}_CandyGalleryUserSettings.xml";
            if (File.Exists(saveFile) && File.ReadAllText(saveFile).Length != 0)
            {
                try
                {
                    using (var reader = XmlReader.Create(saveFile))
                    {
                        // Skip root node
                        reader.ReadToFollowing(
                            "UserSettings"); // Name of first class

                        userSettings = (UserSettings) Program.UserSettingsSerializer.Deserialize(reader);
                        userSettings.Pass = DecryptString(userSettings.Pass);
                        userSettings.StartFolderPath = DecryptString(userSettings.StartFolderPath);
                        userSettings.UserInterfaceColorName = DecryptString(userSettings.UserInterfaceColorName);
                        userSettings.PerSessionSettings.OriginalUsername = username;
                        userSettings.PerSessionSettings.FullPathToCurrentSettingsFile = saveFile;

                        foreach (var favorite in userSettings.UserFavorites)
                        {
                            favorite.FullPath = DecryptString(favorite.FullPath);
                        }

                        if (userSettings.PreserveSessionHistory)
                        {
                            var decryptedHistory = userSettings.SessionHistory.Select(DecryptString).ToList();

                            userSettings.SessionHistory = decryptedHistory;
                            userSettings.PerSessionSettings.BackList = userSettings.SessionHistory;
                            userSettings.SessionHistory = null;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($@"Error loading user settings for ""{username}"": " + e.Message,
                        @"Error Loading Settings File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No settings found for user \"{username}\". \nA new file will be created upon exit!",
                    @"Missing Settings File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return userSettings;
        }

        public static void SaveUserSettings(UserSettings userSettings)
        {
            // Reset settings that should not persist for next session
            userSettings.CurrentMediaTypeToDisplay = MediaFilterType.All;
            userSettings.Pass = EncryptString(userSettings.Pass);
            userSettings.StartFolderPath = EncryptString(userSettings.StartFolderPath);
            userSettings.UserInterfaceColorName = EncryptString(userSettings.UserInterfaceColorName);
            foreach (var favorite in userSettings.UserFavorites)
            {
                favorite.FullPath = EncryptString(favorite.FullPath);
            }

            if (userSettings.PreserveSessionHistory)
            {
                var encryptedHistory = userSettings.SessionHistory.Select(EncryptString).ToList();
                userSettings.SessionHistory = encryptedHistory;
            }

            var appPath = Application.StartupPath;
            Directory.CreateDirectory($"{appPath}\\CandyGalleryUserSettings\\");
            // This will create a file in the same directory as the .exe since we didn't specify a path
            using (var xmlWriter = XmlWriter.Create($"{appPath}\\CandyGalleryUserSettings\\{userSettings.UserName.ToLower()}_CandyGalleryUserSettings.xml", new XmlWriterSettings { Indent = true }))
            {
                xmlWriter.WriteStartElement("root");

                // We only need to serialize the main object model; all the other ones are children of it or irrelevant
                Program.UserSettingsSerializer.Serialize(xmlWriter, userSettings);
            }

            if (userSettings.PerSessionSettings.OriginalUsername != null && userSettings.UserName != userSettings.PerSessionSettings.OriginalUsername)
            {
                var file = $"{appPath}\\CandyGalleryUserSettings\\{userSettings.PerSessionSettings.OriginalUsername.ToLower()}_CandyGalleryUserSettings.xml";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
        }

        public static string DecryptUserSettingsDirectFromContent(XmlDocument xmlContent)
        {
            try
            {
                // Encrypt relevant nodes
                var decryptedPassword = DecryptString(xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText);
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText = decryptedPassword;

                var decryptedStartFolder = DecryptString(xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText);
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText = decryptedStartFolder;

                var decryptedInterfaceColor =
                    DecryptString(xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText);
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText = decryptedInterfaceColor;

                foreach (XmlNode favorite in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserFavorites)).SelectNodes(nameof(UserFavorite)))
                {
                    if (favorite.HasChildNodes)
                    {
                        var decryptedFavorite =
                            DecryptString(favorite.SelectSingleNode(nameof(UserFavorite.FullPath))?.InnerText);
                        if (decryptedFavorite != null)
                        {
                            favorite.SelectSingleNode(nameof(UserFavorite.FullPath)).InnerText = decryptedFavorite;
                        }
                    }
                }

                foreach (XmlNode historyItem in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.SessionHistory)).SelectNodes("HistoryItem"))
                {
                    if (historyItem?.InnerText != null)
                    {
                        var decryptedHistItem =
                            DecryptString(historyItem.InnerText);
                        if (decryptedHistItem != null)
                        {
                            historyItem.InnerText = decryptedHistItem;
                        }
                    }
                }

                return xmlContent.OuterXml;
            }
            catch (Exception)
            {
                MessageBox.Show($"An error occurred while reading/decrypting the settings file.",
                    "Read Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static void EncryptAndSaveUserSettingsDirectToFile(XmlDocument xmlContent)
        {
            try
            {
                // Encrypt relevant nodes
                var encryptedPassword = EncryptString(xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText);
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText = encryptedPassword;

                var encryptedStartFolder = EncryptString(xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText);
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText = encryptedStartFolder;

                var encryptedInterfaceColor =
                    EncryptString(xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText);
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText = encryptedInterfaceColor;

                foreach (XmlNode favorite in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserFavorites)).SelectNodes(nameof(UserFavorite)))
                {
                    if (favorite.HasChildNodes)
                    {
                        var encryptedFavorite =
                            EncryptString(favorite.SelectSingleNode(nameof(UserFavorite.FullPath))?.InnerText);
                        if (encryptedFavorite != null)
                        {
                            favorite.SelectSingleNode(nameof(UserFavorite.FullPath)).InnerText = encryptedFavorite;
                        }
                    }
                }

                foreach (XmlNode historyItem in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.SessionHistory)).SelectNodes("HistoryItem"))
                {
                    if (historyItem?.InnerText != null)
                    {
                        var encryptedHistItem =
                            EncryptString(historyItem.InnerText);
                        if (encryptedHistItem != null)
                        {
                            historyItem.InnerText = encryptedHistItem;
                        }
                    }
                }

                xmlContent.Save(Program.CandyGalleryWindow.UserSettings.PerSessionSettings.FullPathToCurrentSettingsFile);
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while encrypting/saving the settings file and Candy Gallery needs to close.",
                    "Save Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static string DecryptString(string stringToDecrypt)
        {
            string decrypted;
            try
            {
                var b = Convert.FromBase64String(stringToDecrypt);
                decrypted = ASCII.GetString(b);
            }
            catch (FormatException)
            {
                decrypted = "";
            }
            return decrypted;
        }

        public static string EncryptString(string stringToEncrypt)
        {
            var b = ASCII.GetBytes(stringToEncrypt);
            var encrypted = Convert.ToBase64String(b);
            return encrypted;
        }
    }
}