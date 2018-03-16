using System.Windows.Forms;
using ApocalypseLauncherApi.API.v0;

namespace ApocalypseLauncherServersManager.API_v0
{
    public partial class FrmEditor : Form
    {
        private OwnList _model; 


        public OwnList Model
        {
            get { return _model; }
            set
            {
                _model = value;
                if (_model!=null)
                    UpdateBindings();
            }
        }

        private void UpdateBindings()
        {
            foreach (Control control in Controls)
            {
                control.DataBindings.Clear();
            }
            DataBindings.Clear();

            //nameof(Control.Text) == "Text"
            //nameof(Control) == "Control"
            numericUpDownServPort.DataBindings.Add(nameof(numericUpDownServPort.Value), _model, nameof(_model.Port), true, DataSourceUpdateMode.OnPropertyChanged, "");
            textBoxServApi.DataBindings.Add(nameof(Control.Text), _model, nameof(_model.ApiKey), true, DataSourceUpdateMode.OnPropertyChanged, "");
            textBoxServName.DataBindings.Add(nameof(Control.Text), _model, nameof(_model.Name), true, DataSourceUpdateMode.OnPropertyChanged, "");
            textBoxServIP.DataBindings.Add(nameof(Control.Text), _model, nameof(_model.Ip), true, DataSourceUpdateMode.OnPropertyChanged, "");
        }

        public FrmEditor()
        {
            InitializeComponent();
        } 
    }
}
