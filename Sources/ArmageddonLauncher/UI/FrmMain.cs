using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ApocalypseLauncher.HELPERS;
using MetroFramework.Forms;

namespace ApocalypseLauncher.UI
{
    public partial class FrmMain : MetroForm
    {
         
        string _serverRunArgs = "";
        private const string GameExecutable = "cmd.exe";

        public FrmMain()
        {
            InitializeComponent();
            Text = _notifyIcon.Text = GloablGetAssemblers.AssemblyTitle;
            metroLabelTitleAbout.Text = GloablGetAssemblers.AssemblyProduct + @" " + GloablGetAssemblers.AssemblyVersion;
            metroLabelDescriptionAbout.Text = GloablGetAssemblers.AssemblyDescription;
            metroLabelCopyryght.Text = GloablGetAssemblers.AssemblyCopyright;
            StyleManager = metroStyleManager;
            StyleManager.Owner = this;
            Style = StyleManager.Style;
            Theme = StyleManager.Theme;
            CheckConnection(); 
            _notifyIcon.Icon = ApocalypseLauncher.Properties.Resources.hl_icon_favicon; 
            _notifyIcon.MouseClick += (_notifyIcon_MouseClick);
            Resize += (FormForTray_Resize);
            metroComboBoxServers.SelectedIndex = 0;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private FormWindowState _oldFormState;

        private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)     {
                _oldFormState = WindowState;
                WindowState = FormWindowState.Minimized;
            } else   {
                Show();
                WindowState = _oldFormState; 
            }
        }
         
        private void FormForTray_Resize(object sender, EventArgs e)   {
            if (FormWindowState.Minimized == WindowState)   { 
                Hide();
            }
        }

        //Check connection to site
        private void CheckConnection()
        {
            const string url = "https://armageddon.epicm.org/";
            var appPath = Path.GetDirectoryName(Application.ExecutablePath);
            try
            { 
                var request = (HttpWebRequest) WebRequest.Create(url);
                request.AllowAutoRedirect = false;
                request.Method = WebRequestMethods.Http.Head;
                request.Accept = @"*/*";
                var response = (HttpWebResponse) request.GetResponse();
                response.Close();
                webControl.Source = new Uri(url + "news.html"); 
            }
            catch (WebException ex)
            { 
                Console.WriteLine(ex.ToString());
                webControl.Source = new Uri("file:///" + appPath + "\\HTML\\noconnection.html");
            }

        }

        private void metroButtonPlay_Click(object sender, EventArgs e)
        {
            //Hide window is checkbox checked
            if (((metroCheckBoxHideInTrayWhenPlay.Checked && WindowState == FormWindowState.Normal) || metroCheckBoxHideInTrayWhenPlay.Checked && WindowState == FormWindowState.Maximized)) {
                _oldFormState = WindowState;
                WindowState = FormWindowState.Minimized;
                Hide();
            }

            //Show hidden launcher if player exit game (if checkbox checked)
            if (metroCheckBoxHideInTrayWhenPlay.Checked)
            {
                var process = Process.Start(GameExecutable, _serverRunArgs);
                process?.WaitForExit();
                //MessageBox.Show("true");
                Show();
                WindowState = _oldFormState; 
            }
            else if (!metroCheckBoxHideInTrayWhenPlay.Checked)
            {
                Process.Start(GameExecutable, _serverRunArgs);
            }

            //
            switch (metroComboBoxServers.SelectedIndex)
                {
                    case 0:
                        _serverRunArgs = ""; //nothing
                        break;
                    case 1:
                        _serverRunArgs = " +connect ip.games.epicm.org:1018"; //ARM
                        break;
                    case 2:
                        _serverRunArgs = " +connect ip.games.epicm.org:1347"; //VIT-C
                        break;
                    case 3:
                        _serverRunArgs = " +connect ip.games.epicm.org:1666"; //GunGame
                        break;
                    default:
                        _serverRunArgs = ""; //nothing
                        break;
                } 
              // MessageBox.Show(_serverRunArgs.ToString());
            }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        { 
            _notifyIcon.Icon = null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
