using System;
using System.Windows.Forms;

namespace ApocalypseLauncherServersManager.Shared
{
    public partial class FrmSelectApi : Form
    {
        public int? Apiversion;
        public FrmSelectApi()
        {
            InitializeComponent();
            comboBoxApi.SelectedIndex = 0;
          
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonApi_Click(object sender, EventArgs e)
        {
         
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (comboBoxApi.SelectedIndex)
            {
                case 0:
                {
                    Apiversion = 1;
                    break;
                 }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxApi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}