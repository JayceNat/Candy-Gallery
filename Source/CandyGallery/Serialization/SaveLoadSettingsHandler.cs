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
            if (File.Exists(saveFile))
            {
                userSettings.PerSessionSettings.FullPathToCurrentSettingsFile = saveFile;
                var contents = File.ReadAllText(saveFile);
                if (!string.IsNullOrWhiteSpace(contents))
                {
                    // Try reading it as if unencrypted first
                    try
                    {
                        var attemptedUserSettings = HandleXmlFileLoad(saveFile, username, userSettings, false);
                        if (attemptedUserSettings != null)
                        {
                            userSettings = attemptedUserSettings;
                            userSettings.PerSessionSettings.LoadedSettingsFileWasEncrypted = false;
                        }
                        else throw new Exception();
                    }
                    catch (Exception e)
                    {
                        // File must be encrypted then...
                        try
                        {
                            contents = DecryptString(contents);
                            File.WriteAllText(saveFile, contents);
                            userSettings = HandleXmlFileLoad(saveFile, username, userSettings);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($@"Error loading user settings for ""{username}"": " + e.Message,
                                @"Error Loading Settings File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"No contents found inside the settings file for user \"{username}\". \nA new file will be created upon exit!",
                        @"Missing Settings File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"No settings found for user \"{username}\". \nA new file will be created upon exit!",
                    @"Missing Settings File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return userSettings;
        }

        public static UserSettings HandleXmlFileLoad(string fullSaveFilePath, string username, UserSettings userSettings, bool treatFileAsEncrypted = true)
        {
            if (File.Exists(fullSaveFilePath))
            {
                try
                {
                    using (var reader = XmlReader.Create(fullSaveFilePath))
                    {
                        // Skip root node
                        reader.ReadToFollowing(
                            "UserSettings"); // Name of first class

                        userSettings = (UserSettings)Program.UserSettingsSerializer.Deserialize(reader);

                        userSettings.PerSessionSettings.OriginalUsername = username;
                        userSettings.PerSessionSettings.FullPathToCurrentSettingsFile = fullSaveFilePath;

                        if (treatFileAsEncrypted)
                        {
                            userSettings.Pass = DecryptString(userSettings.Pass);
                            userSettings.StartFolderPath = DecryptString(userSettings.StartFolderPath);
                            userSettings.UserInterfaceColorName = DecryptString(userSettings.UserInterfaceColorName);
                            var decryptedUnseen = userSettings.UnseenItems.Select(DecryptString).ToList();
                            userSettings.UnseenItems = decryptedUnseen;

                            foreach (var favorite in userSettings.UserFavorites)
                            {
                                favorite.FullPath = DecryptString(favorite.FullPath);
                            }
                        }

                        if (userSettings.PreserveSessionHistory)
                        {
                            if (treatFileAsEncrypted)
                            {
                                var decryptedHistory = userSettings.SessionHistory.Select(DecryptString).ToList();
                                userSettings.SessionHistory = decryptedHistory;
                            }

                            userSettings.PerSessionSettings.BackList = userSettings.SessionHistory;
                            userSettings.SessionHistory = null;
                        }

                        // Check if our Start Folder exists, if not then later ask user to locate it
                        if (!Directory.Exists(userSettings.StartFolderPath))
                        {
                            userSettings.PerSessionSettings.StartFolderMissingOnLoad = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }

            return userSettings;
        }

        public static void SaveUserSettings(UserSettings userSettings)
        {
            // Reset settings that should not persist for next session
            userSettings.CurrentMediaTypeToDisplay = MediaFilterType.All;
            if (userSettings.EncryptSettingsFile)
            {
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

                var encryptedUnseen = userSettings.UnseenItems.Select(EncryptString).ToList();
                userSettings.UnseenItems = encryptedUnseen;
            }

            var appPath = Application.StartupPath;
            Directory.CreateDirectory($"{appPath}\\CandyGalleryUserSettings\\");
            var saveFile = $"{appPath}\\CandyGalleryUserSettings\\{userSettings.UserName.ToLower()}_CandyGalleryUserSettings.xml";
            // This will create a file in the same directory as the .exe since we didn't specify a path
            using (var xmlWriter = XmlWriter.Create(saveFile, new XmlWriterSettings { Indent = true }))
            {
                xmlWriter.WriteStartElement("root");

                // We only need to serialize the main object model; all the other ones are children of it or irrelevant
                Program.UserSettingsSerializer.Serialize(xmlWriter, userSettings);
            }

            if (File.Exists(saveFile) && userSettings.EncryptSettingsFile)
            {
                EncryptSaveFileContents(saveFile);
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

        public static string DecryptUserSettingsDirectFromContent(XmlDocument xmlContent, bool decryptContent = true)
        {
            try
            {
                // Decrypt relevant nodes
                var password = xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText;
                var startFolder = xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText;
                var interfaceColor = xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText;

                if (decryptContent)
                {
                    password = DecryptString(password);
                    startFolder = DecryptString(startFolder);
                    interfaceColor = DecryptString(interfaceColor);
                }

                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText = password;
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText = startFolder;
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText = interfaceColor;

                foreach (XmlNode favoriteNode in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserFavorites)).SelectNodes(nameof(UserFavorite)))
                {
                    if (favoriteNode.HasChildNodes)
                    {
                        var favorite = favoriteNode.SelectSingleNode(nameof(UserFavorite.FullPath))?.InnerText;
                        if (favorite != null)
                        {
                            if (decryptContent) favorite = DecryptString(favorite);
                            favoriteNode.SelectSingleNode(nameof(UserFavorite.FullPath)).InnerText = favorite;
                        }
                    }
                }

                foreach (XmlNode historyItemNode in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.SessionHistory)).SelectNodes("HistoryItem"))
                {
                    if (historyItemNode?.InnerText != null)
                    {
                        var histItem = historyItemNode.InnerText;
                        if (histItem != null)
                        {
                            if (decryptContent) histItem = DecryptString(histItem);
                            historyItemNode.InnerText = histItem;
                        }
                    }
                }

                foreach (XmlNode unseenItemNode in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UnseenItems)).SelectNodes("UnseenItem"))
                {
                    if (unseenItemNode?.InnerText != null)
                    {
                        var unseenItem = unseenItemNode.InnerText;
                        if (unseenItem != null)
                        {
                            if (decryptContent) unseenItem = DecryptString(unseenItem);
                            unseenItemNode.InnerText = unseenItem;
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

        public static void EncryptAndSaveUserSettingsDirectToFile(XmlDocument xmlContent, bool encryptContent = true)
        {
            try
            {
                // Encrypt relevant nodes
                var password = xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText;
                var startFolder = xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText;
                var interfaceColor = xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText;

                if (encryptContent)
                {
                    password = EncryptString(password);
                    startFolder = EncryptString(startFolder);
                    interfaceColor = EncryptString(interfaceColor);
                }

                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.Pass)).InnerText = password;
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.StartFolderPath)).InnerText = startFolder;
                xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserInterfaceColorName)).InnerText = interfaceColor;

                foreach (XmlNode favoriteNode in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UserFavorites)).SelectNodes(nameof(UserFavorite)))
                {
                    if (favoriteNode.HasChildNodes)
                    {
                        var favorite = favoriteNode.SelectSingleNode(nameof(UserFavorite.FullPath))?.InnerText;
                        if (favorite != null)
                        {
                            if (encryptContent) favorite = EncryptString(favorite);
                            favoriteNode.SelectSingleNode(nameof(UserFavorite.FullPath)).InnerText = favorite;
                        }
                    }
                }

                foreach (XmlNode historyItemNode in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.SessionHistory)).SelectNodes("HistoryItem"))
                {
                    if (historyItemNode?.InnerText != null)
                    {
                        var histItem = historyItemNode.InnerText;
                        if (histItem != null)
                        {
                            if (encryptContent) histItem = EncryptString(histItem);
                            historyItemNode.InnerText = histItem;
                        }
                    }
                }

                foreach (XmlNode unseenItemNode in xmlContent.DocumentElement.SelectSingleNode(nameof(UserSettings)).SelectSingleNode(nameof(UserSettings.UnseenItems)).SelectNodes("UnseenItem"))
                {
                    if (unseenItemNode?.InnerText != null)
                    {
                        var unseenItem = unseenItemNode.InnerText;
                        if (unseenItem != null)
                        {
                            if (encryptContent) unseenItem = EncryptString(unseenItem);
                            unseenItemNode.InnerText = unseenItem;
                        }
                    }
                }

                xmlContent.Save(Program.CandyGalleryWindow.UserSettings.PerSessionSettings.FullPathToCurrentSettingsFile);
                
                if (encryptContent)
                {
                    EncryptSaveFileContents(Program.CandyGalleryWindow.UserSettings.PerSessionSettings.FullPathToCurrentSettingsFile);
                }
                
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
            string decrypted = "";
            if (!string.IsNullOrWhiteSpace(stringToDecrypt))
            {
                try
                {
                    var b = Convert.FromBase64String(stringToDecrypt);
                    decrypted = ASCII.GetString(b);
                }
                catch (FormatException)
                {
                    decrypted = "";
                }
            }
            return decrypted;
        }

        public static string EncryptString(string stringToEncrypt)
        {
            var b = ASCII.GetBytes(stringToEncrypt);
            var encrypted = Convert.ToBase64String(b);
            return encrypted;
        }

        public static void EncryptSaveFileContents(string fullSaveFilePath)
        {
            var contents = File.ReadAllText(fullSaveFilePath);
            contents = SaveLoadSettingsHandler.EncryptString(contents);
            File.WriteAllText(fullSaveFilePath, contents);
        }
    }
}