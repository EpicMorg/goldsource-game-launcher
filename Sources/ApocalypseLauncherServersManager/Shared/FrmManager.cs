using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApocalypseLauncherApi.API;
using ApocalypseLauncherApi.API.v0;
using ApocalypseLauncherServersManager.API_v0;

namespace ApocalypseLauncherServersManager.Shared
{
    public partial class FrmManager : Form
    {
        //methods depending on model version
        private Action AddOwnServer;
        private Action UpdateBindings;
        private Action EditOwnServer;
        private Action DeleteOwnServer;

        private bool _loadedFromFile = false;
        private bool _createdFromButton = false;
        private VersionedServers _model1;

        public FrmManager()
        {
            InitializeComponent();
        }

        private void FrmManager_Load(object sender, EventArgs e) => Text = "Serverrs.json Editor [Waiting for user]";

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                ShowReadOnly = true,
                AddExtension = true,
                AutoUpgradeEnabled = true,
                Filter = @"servers.json|servers.json"
            };
            if (openFile.ShowDialog() != DialogResult.OK)
                return;
            var f = File.ReadAllText(openFile.FileName);
            ;
            var cfg = VersionedData.Load(f);
            Text = $"Serverrs.json Editor [Loaded, Api ver. {cfg.Api}]";
            switch (cfg.Api)
            {
                case VersionedServers.ApiVersion:
                {
                    var versionedServers = VersionedServers.Load(f);
                    ShowEditor_1(versionedServers);
                    break;
                }
            }
        }


        private void ShowEditor_1(VersionedServers load)
        {
            _model1 = load;
            _loadedFromFile = true;
            _createdFromButton = false;
            SetControlsEnabled(true);

            //
            AddOwnServer = AddOwnServer_1;
            EditOwnServer = EditOwnServer_1;
            DeleteOwnServer = DeleteOwnServer_1;
            UpdateBindings = UpdateBindings_1;

            UpdateBindings();
        }



        private void SetControlsEnabled(bool enabled)
        {
            buttonDelOwnServers.Enabled = enabled;
            buttonAddFriendsServers.Enabled = enabled;
            buttonAddOwnServers.Enabled = enabled;
            buttonEditOwnServers.Enabled = enabled;
            buttonSaveFile.Enabled = enabled;
        }



        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            var frmNewFile = new FrmSelectApi {ShowInTaskbar = false};
            frmNewFile.ShowDialog();
            if (frmNewFile.DialogResult == DialogResult.OK) Text = $"Serverrs.json Editor [New, Api ver. {frmNewFile.Apiversion}]";
            _createdFromButton = true;
            _loadedFromFile = false;
            buttonAddFriendsServers.Enabled = buttonAddOwnServers.Enabled = true;
            buttonSaveFile.Enabled = true;
        }


        private void buttonAddOwnServers_Click(object sender, EventArgs e)
        {
            AddOwnServer();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (_loadedFromFile && !_createdFromButton)
            {
                //сохранение в файл, который открыли
            }
            else if (!_loadedFromFile && _createdFromButton)
            {
                //вызов формы сохранения в файл (если создали через new)
            }
        }

        private void buttonEditOwnServers_Click(object sender, EventArgs e)
        {
            if (listBoxOwnServers.SelectedItem == null) return;
            EditOwnServer();

        }

        private void buttonDelOwnServers_Click(object sender, EventArgs e)
        {
            if (listBoxOwnServers.SelectedItem == null) return;
            DeleteOwnServer();
            UpdateBindings();
        }
        //versions
        #region api v1
        private void AddOwnServer_1()
        {
            using (var frmEdit = new FrmEditor())
            {
                var abc = new OwnList();
                frmEdit.Model = abc;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    _model1.Data.OwnList.Add(abc);
                    UpdateBindings();
                    //  this.....Add(abc);
                }
            }
        }
        private void EditOwnServer_1()
        {
            using (var frmEdit = new FrmEditor())
            {
                frmEdit.Model = (OwnList) listBoxOwnServers.SelectedItem;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    UpdateBindings();
                }
            }
        }
        private void DeleteOwnServer_1()
        {
            var tmpModel = (OwnList) listBoxOwnServers.SelectedItem;
            _model1.Data.OwnList.Remove(tmpModel);
        }

        private void UpdateBindings_1()
        {
            listBoxOwnServers.DataSource = null;
            listBoxOwnServers.DataSource = _model1.Data.OwnList;
            listBoxOwnServers.Text = "Own list (" + listBoxOwnServers.Items.Count + ")"; 
        }
        #endregion

    }
}