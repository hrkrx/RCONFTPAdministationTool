using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MinecraftFTPadminTool
{
    public class SettingsController
    {
        public static SettingsItem settingsItem = new SettingsItem();

        /// <summary>
        /// Loads or Reloads the Settings from file
        /// </summary>
        public void LoadSettings()
        {
            try
            {
                //TODO determine path
                StreamReader reader = new StreamReader(/*Application.StartupPath + */"\\MFTP.conf");
                List<string> settings = new List<string>();
                while (!reader.EndOfStream)
                {
                    settings.Add(reader.ReadLine());
                }
                reader.Close();

                foreach (string item in settings)
                {
                    if (item.Contains("Game"))
                    {
                        settingsItem.ftpGameDir = Util.GetLastWordOfString(item);
                    }
                    else if (item.Contains("ConfDir"))
                    {
                        if (!Util.GetLastWordOfString(item).Contains("="))
                        {
                            settingsItem.configDir = Util.GetLastWordOfString(item);
                        }
                    }
                    else if (item.Contains("BackupDir"))
                    {
                        if (!Util.GetLastWordOfString(item).Contains("="))
                        {
                            settingsItem.backupDir = Util.GetLastWordOfString(item);
                        }
                    }
                    else if (item.Contains("Opacity"))
                    {
                        settingsItem.frmOpacity = Convert.ToInt32(Util.GetLastWordOfString(item));
                    }
                    else if (item.Contains("refresh"))
                    {
                        settingsItem.refreshInteval = Convert.ToInt32(Util.GetLastWordOfString(item));
                    }
                    else if (item.Contains("savelogin"))
                    {
                        if (Util.GetLastWordOfString(item) == "True")
                        {
                            settingsItem.saveLogin = true;
                        }
                        else
                        {
                            settingsItem.saveLogin = false;
                        }
                    }
                    else if (item.Contains("backup"))
                    {
                        if (Util.GetLastWordOfString(item) == "True")
                        {
                            settingsItem.createBackup = true;
                        }
                        else
                        {
                            settingsItem.createBackup = false;
                        }
                    }
                    else if (item.Contains("ip"))
                    {
                        if (!String.IsNullOrEmpty(Util.GetLastWordOfString(item)))
                        {
                            settingsItem.serverIP = Util.GetLastWordOfString(item);
                        }
                    }
                    else if (item.Contains("RCONport"))
                    {
                        if (!String.IsNullOrEmpty(Util.GetLastWordOfString(item)))
                        {
                            settingsItem.rconPort = Util.GetLastWordOfString(item);
                        }
                    }
                    else if (item.Contains("Username"))
                    {
                        settingsItem.ftpUsername = Util.GetLastWordOfString(item);
                    }
                    else if (item.Contains("RCONpass"))
                    {
                        settingsItem.rconPassword = Util.GetLastWordOfString(item);
                    }
                    else if (item.Contains("FTPpass"))
                    {
                        settingsItem.ftpPassword = Util.GetLastWordOfString(item);
                    }
                    else if (item.Contains("ConfigFilename"))
                    {
                        settingsItem.configDir = Util.GetLastWordOfString(item);
                    }
                }
            }
            catch (Exception)
            {
                //Handle Exception
            }
        }
    }

    public class SettingsItem
    {
        /// <summary>
        /// creates an empty SettingsItem
        /// </summary>
        public SettingsItem()
        { }

        /// <summary>
        /// creates a new SettingsItem used to load or save settings
        /// </summary>
        /// <param name="ftpUsername">Username used for the FTP-Server</param>
        /// <param name="ftpPassword">Password used for the FTP-Server</param>
        /// <param name="rconUsername">Username used for the RCON-Service</param>
        /// <param name="rconPassword">Password used for the RCON-Service</param>
        /// <param name="serverIP">Gameserver IP</param>
        /// <param name="rconPort">RCON-Service Port</param>
        /// <param name="backupDir">Directory where configbackups are stored</param>
        /// <param name="createBackup">True if you want to create backups of your configfiles</param>
        /// <param name="ftpGameDir">Initial Gamedirectory</param>
        /// <param name="configDir">Directory where the configfiles are to be found</param>
        /// <param name="saveLogin">If True save login to file</param>
        /// <param name="refreshInteval">Refreshinterval for requesting log from Server</param>
        /// <param name="frmOpacity">Opacity of the form</param>
        public SettingsItem(String ftpUsername, String ftpPassword, String rconUsername,
            String rconPassword, String serverIP, String rconPort, String backupDir, bool createBackup,
            String ftpGameDir, String configDir, bool saveLogin, int refreshInteval, int frmOpacity)
        {

        }
        public String ftpUsername { get; set; }
        public String ftpPassword { get; set; }
        public String rconUsername { get; set; }
        public String rconPassword { get; set; }
        public String serverIP { get; set; }
        public String rconPort { get; set; }
        public String backupDir { get; set; }
        public String ftpGameDir { get; set; }
        public String configDir { get; set; }
        public bool createBackup { get; set; }
        public bool saveLogin { get; set; }
        public int refreshInteval { get; set; }
        public int frmOpacity { get; set; }
    }
}
