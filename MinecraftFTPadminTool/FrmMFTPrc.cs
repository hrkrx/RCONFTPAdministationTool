using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using SourceRcon;
using System.IO;
using System.Text.RegularExpressions;

namespace MinecraftFTPadminTool
{
    public partial class MFTPrc : Form
    {
        //RCON connection;
        List<string> lastcmd = new List<string>();
        SourceRcon.SourceRcon rcon = new SourceRcon.SourceRcon();
        string IP = null, Port = null, backup = null;
        Point startPoint;
        bool tbMdown = false;

        public MFTPrc()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            IP = null;
            Port = null;
            tbFTPIP.Enabled = false;
            tbFTPuser.Enabled = false;
            tbFTPpass.Enabled = false;
            if (getFTPserverLog(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text) != null)
            {
                rtbShow.Text = getFTPserverLog(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text);
                trefreshlog.Enabled = true;
                checkBox1.Enabled = true;
                checkBox1.Checked = true;
            }
            else
            {
                tbFTPIP.Enabled = true;
                tbFTPuser.Enabled = true;
                tbFTPpass.Enabled = true;
            }

            tbSrvPort.Enabled = false;
            tbrconPass.Enabled = false;
            btSend.Enabled = true;

            //connection = new RCON();


            int Qstring = 1;

            foreach (char item in tbSrvPort.Text)
            {
                if (Qstring == 1 && item != ':')
                {
                    IP = IP + item;
                }

                if (Qstring == 2 && item != ':')
                {
                    Port = Port + item;
                }

                if (item == ':')
                {
                    Qstring = 2;
                }

            }

            IPEndPoint adrss = new IPEndPoint(IPAddress.Parse(IP), Convert.ToInt32(Port));
            try
            {
                bool res = rcon.Connect(adrss, tbrconPass.Text);
                if (!res)
                {
                    throw new Exception("Connection Error");
                }
                else
                {
                    rcon.ServerOutput += rcon_ServerOutput;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RCON Connectionfailure");
            }


            rtbShow.SelectionStart = rtbShow.Text.Length;
            rtbShow.ScrollToCaret();

            btConnect.Text = "Reconnect";


        }

        void rcon_ServerOutput(string output)
        {
            if (!String.IsNullOrEmpty(output))
            {
                MessageBox.Show(output, "Serverausgabe");
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(connection.sendCommand(tbsend.Text, IP, tbrconPass.Text, Convert.ToInt32(Port)),"Test");
            try
            {

                rcon.ServerCommand(tbsend.Text);
                lastcmd.Add(tbsend.Text);
                tbsend.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RCON Connectionfailure");
            }


        }

        public string getFTPserverLog(string IP, string username, string pass)
        {
            WebClient request = new WebClient();
            string url = "ftp://" + IP + "/" + tbFTPDir.Text + "/server.log";
            if (!String.IsNullOrEmpty(tbFileName.Text))
            {
                url = "ftp://" + IP + "/" + tbFTPDir.Text + "/" + tbFileName.Text;
            }
            request.Credentials = new NetworkCredential(username, pass);

            try
            {

                byte[] newFileData = request.DownloadData(url);
                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                return fileString;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Fehler");
                if (trefreshlog.Enabled)
                {
                    trefreshlog.Enabled = false;

                }
                rtbShow.Text = rtbShow.Text + "\n" + DateTime.Now.ToString() + ": " + e.Message;
            }

            return null;
        }

        private void trefreshlog_Tick(object sender, EventArgs e)
        {

            if (checkBox1.Checked && !tbMdown)
            {
                rtbShow.Text = getFTPserverLog(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text);
                rtbShow.SelectionStart = rtbShow.Text.Length;
                rtbShow.ScrollToCaret();
            }

        }

        private void tbsend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    rcon.ServerCommand(tbsend.Text);
                    lastcmd.Add(tbsend.Text);
                    tbsend.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RCON Connectionfailure");
                }

            }

            if (e.KeyCode == Keys.Down)
            {
                if (tbsend.Text == "")
                {
                    if (lastcmd.Count < 0)
                    {
                        tbsend.Text = lastcmd[lastcmd.Count - 1];
                    }
                }
                else
                {
                    try
                    {
                        tbsend.Text = lastcmd[lastcmd.IndexOf(tbsend.Text) - 1];
                    }
                    catch
                    {

                    }

                }

            }

            if (e.KeyCode == Keys.Up)
            {
                try
                {
                    tbsend.Text = lastcmd[lastcmd.IndexOf(tbsend.Text) + 1];
                }
                catch
                {

                }



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        void frm_MouseAction(object sender, MouseEventArgs e)
        {
            if (startPoint.IsEmpty)
            {
                startPoint = new Point(-e.Location.X, -e.Location.Y);
            }
            else
            {
                startPoint = Point.Empty;
            }
        }

        void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!startPoint.IsEmpty)
            {
                Point endPoint = this.PointToScreen(e.Location);
                this.Location = new Point(startPoint.X + endPoint.X,
                                          startPoint.Y + endPoint.Y);
            }
        }

        private void MFTPrc_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(frm_MouseAction);
            this.MouseUp += new MouseEventHandler(frm_MouseAction);
            this.MouseMove += new MouseEventHandler(frm_MouseMove);
            //tpConsole.MouseDown += new MouseEventHandler(frm_MouseAction);
            //tpConsole.MouseUp += new MouseEventHandler(frm_MouseAction);
            //tpConsole.MouseMove += new MouseEventHandler(frm_MouseMove);
            //tpProperties.MouseDown += new MouseEventHandler(frm_MouseAction);
            //tpProperties.MouseUp += new MouseEventHandler(frm_MouseAction);
            //tpProperties.MouseMove += new MouseEventHandler(frm_MouseMove);
            //tabCMFTP.MouseDown += new MouseEventHandler(frm_MouseAction);
            //tabCMFTP.MouseUp += new MouseEventHandler(frm_MouseAction);
            //tabCMFTP.MouseMove += new MouseEventHandler(frm_MouseMove); 
            LoadSettings();
            label9.Text = Convert.ToString(this.Opacity * 100);
            label10.Text = Convert.ToString(trefreshlog.Interval / 1000);

        }

        private void rtbShow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                rtbShow.Text = getFTPserverLog(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text);
                rtbShow.SelectionStart = rtbShow.Text.Length;
                rtbShow.ScrollToCaret();
            }
        }

        private List<string> getCofigList(string IP, string Username, string Password)
        {
            List<string> Files = new List<string>();
            List<string> confFiles = new List<string>();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + IP + "/" + "/");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;


            request.Credentials = new NetworkCredential(Username, Password);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            while (!reader.EndOfStream)
            {
                Files.Add(reader.ReadLine());
            }

            var VAR = response.StatusDescription;

            foreach (string item in Files)
            {
                if (item.Contains(".txt") || item.Contains(".properties") || item.Contains(".config") || item.Contains(".conf"))
                {
                    if (!item.Contains(".backup"))
                    {
                        confFiles.Add(item);
                    }

                }
            }



            reader.Close();
            response.Close();

            return confFiles;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {

            foreach (string item in getCofigList(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text))
            {
                lbConfigs.Items.Add(GetLastWordOfString(item));
            }

            btLoad.Enabled = false;

        }

        private static string GetLastWordOfString(string token)
        {
            string[] words = token.Split('=');

            return words[words.Length - 1].Trim();
        }

        private void lbConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {

            rtConfigs.Text = getFTPconfig(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text, (string)lbConfigs.SelectedItem);
            //FTPUpload(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text, (string)lbConfigs.SelectedItem + ".backup");

            btSave.Enabled = true;
            btRestore.Enabled = true;

            rtConfigs.Refresh();
        }

        public string getFTPconfig(string IP, string username, string pass, string Filename)
        {
            WebClient request = new WebClient();
            string url = "ftp://" + IP + "/MinecraftDIRE/" + Filename;
            request.Credentials = new NetworkCredential(username, pass);

            try
            {

                byte[] newFileData = request.DownloadData(url);
                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                return fileString;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fehler");
            }

            return null;
        }

        public bool FTPUpload(string IP, string username, string pass, string Filename)
        {

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + IP + "/MinecraftDIRE/" + Filename);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(username, pass);

            byte[] fileContents = Encoding.UTF8.GetBytes(rtConfigs.Text);
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            response.Close();

            return true;

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            backup = rtConfigs.Text;
            rtConfigs.Text = getFTPconfig(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text, (string)lbConfigs.SelectedItem);
            FTPUpload(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text, (string)lbConfigs.SelectedItem + ".backup");

            rtConfigs.Text = backup;

            FTPUpload(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text, (string)lbConfigs.SelectedItem);
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            try
            {
                rtConfigs.Text = getFTPconfig(tbFTPIP.Text, tbFTPuser.Text, tbFTPpass.Text, (string)lbConfigs.SelectedItem + ".backup");
            }
            catch
            {
                MessageBox.Show("No Backup exists on the Server", "FileError");
            }

        }

        private void btOptions_Click(object sender, EventArgs e)
        {
            if (MFTPrc.ActiveForm.Height == 338)
            {
                MFTPrc.ActiveForm.Height = 516;
            }
            else
            {
                MFTPrc.ActiveForm.Height = 338;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btSwitch.Text == "CONFIG")
            {
                pnlServerConsole.Visible = false;
                pnlConfig.Visible = true;
                btSwitch.Text = "SERVER";
            }
            else
            {
                pnlConfig.Visible = false;
                pnlServerConsole.Visible = true;
                btSwitch.Text = "CONFIG";
            }




        }

        private void sbOpacity_Scroll(object sender, ScrollEventArgs e)
        {

            double value = sbOpacity.Value;
            value = value / 1000;
            this.Opacity = value;
            label9.Text = Convert.ToString(value * 100);

        }

        private void sbRefreshrate_Scroll(object sender, ScrollEventArgs e)
        {
            label10.Text = Convert.ToString(trefreshlog.Interval / 1000);
            trefreshlog.Interval = sbRefreshrate.Value * 1000;
        }

        private void SaveSettings()
        {
            StreamWriter writer = new StreamWriter(Application.StartupPath + "\\MFTP.conf");
            List<string> settingsS = new List<string>();

            settingsS.Add("Game= " + tbFTPDir.Text);
            settingsS.Add("ConfDir= " + tbConfigDir.Text);
            settingsS.Add("BackupDir= " + tbBackupDir.Text);
            settingsS.Add("Opacity= " + Convert.ToString(Convert.ToInt32(sbOpacity.Value / 10)));
            settingsS.Add("refresh= " + Convert.ToString(Convert.ToInt32(sbRefreshrate.Value * 1000)));
            settingsS.Add("savelogin= " + Convert.ToString(cbSaveData.Checked));
            settingsS.Add("backup= " + Convert.ToString(cbBackup.Checked));
            settingsS.Add("ip= " + tbFTPIP.Text);
            if (tbSrvPort.Text.Contains(":"))
            {
                settingsS.Add("RCONport= " + tbSrvPort.Text.Split(':')[1]);
            }
            settingsS.Add("RCONpass= " + tbrconPass.Text);
            settingsS.Add("Username= " + tbFTPuser.Text);
            settingsS.Add("FTPpass= " + tbFTPpass.Text);
            settingsS.Add("ConfigFilename= " + tbFileName.Text);

            foreach (string item in settingsS)
            {
                writer.WriteLine(item);
            }

            writer.Close();
        }

        private void LoadSettings()
        {
            string ip = "";
            try
            {
                StreamReader reader = new StreamReader(Application.StartupPath + "\\MFTP.conf");
                List<string> settings = new List<string>();
                while(!reader.EndOfStream)
                {
                    settings.Add(reader.ReadLine());
                }

                reader.Close();

                foreach (string item in settings)
                {

                    if (item.Contains("Game"))
                    {
                        tbFTPDir.Text = GetLastWordOfString(item);
                    }
                    else if (item.Contains("ConfDir"))
                    {
                        if (!GetLastWordOfString(item).Contains("="))
                        {
                            tbConfigDir.Text = GetLastWordOfString(item);
                        }

                    }
                    else if (item.Contains("BackupDir"))
                    {
                        if (!GetLastWordOfString(item).Contains("="))
                        {
                            tbBackupDir.Text = GetLastWordOfString(item);
                        }
                    }
                    else if (item.Contains("Opacity"))
                    {
                        sbOpacity.Value = Convert.ToInt32(GetLastWordOfString(item)) * 10;
                        label9.Text = Convert.ToString(sbOpacity.Value / 10);
                        double value = sbOpacity.Value;
                        value = value / 1000;
                        this.Opacity = value;
                    }
                    else if (item.Contains("refresh"))
                    {
                        sbRefreshrate.Value = Convert.ToInt32(Convert.ToDouble(GetLastWordOfString(item)) / 1000);
                        trefreshlog.Interval = sbRefreshrate.Value * 1000;
                        label10.Text = Convert.ToString(trefreshlog.Interval / 1000);

                    }
                    else if (item.Contains("savelogin"))
                    {
                        if (GetLastWordOfString(item) == "True")
                        {
                            cbSaveData.Checked = true;
                        }
                        else
                        {
                            cbSaveData.Checked = false;
                        }

                    }
                    else if (item.Contains("backup"))
                    {
                        if (GetLastWordOfString(item) == "True")
                        {
                            cbBackup.Checked = true;
                        }
                        else
                        {
                            cbBackup.Checked = false;
                        }
                    }
                    else if (item.Contains("ip"))
                    {
                        if (!String.IsNullOrEmpty(GetLastWordOfString(item)))
                        {
                            tbFTPIP.Text = GetLastWordOfString(item);
                            ip = GetLastWordOfString(item);
                        }

                    }
                    else if (item.Contains("RCONport"))
                    {
                        if (!String.IsNullOrEmpty(GetLastWordOfString(item)))
                        {
                            try
                            {
                                tbSrvPort.Text = ip + ":" +GetLastWordOfString(item);
                            }
                            catch (Exception)
                            {                                
                                throw;
                            }
                        }
                    }
                    else if (item.Contains("Username"))
                    {
                        tbFTPuser.Text = GetLastWordOfString(item);
                    }
                    else if (item.Contains("RCONpass"))
                    {
                        tbrconPass.Text = GetLastWordOfString(item);
                    }
                    else if (item.Contains("FTPpass"))
                    {
                        tbFTPpass.Text = GetLastWordOfString(item);
                    }
                    else if (item.Contains("ConfigFilename"))
                    {
                        tbFileName.Text = GetLastWordOfString(item);
                    }
                }
            }
            catch (Exception)
            {
                //SaveSettings();
            }

        }

        private void rtbShow_MouseDown(object sender, MouseEventArgs e)
        {
            tbMdown = true;
        }

        private void rtbShow_MouseUp(object sender, MouseEventArgs e)
        {
            tbMdown = false;
        }

        private void rtbShow_MouseLeave(object sender, EventArgs e)
        {
            tbMdown = false;
        }

    }
}
