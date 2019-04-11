using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enpara
{
    public partial class settingsForm : Form
    {
        mainForm m = null;
        public settingsForm(Form sForm)
        {
            m = sForm as mainForm;

            sForm.SendToBack();

            InitializeComponent();
            
            


        }

        private void _cb_proxyFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!this._cb_proxyFlag.Checked)
            {
                this._tb_proxyAddress.Enabled = false;
                this._tb_proxyPort.Enabled = false;
                this._tb_proxyUser.Enabled = false;
                this._tb_proxyPassword.Enabled = false;
            }
            else
            {
                this._tb_proxyAddress.Enabled = true;
                this._tb_proxyPort.Enabled = true;
                this._tb_proxyUser.Enabled = true;
                this._tb_proxyPassword.Enabled = true;
            }
        }

        private void _button_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isProxyEnabledFlag = _cb_proxyFlag.Checked;
            if (_cb_proxyFlag.Checked)
            {
                Properties.Settings.Default.proxyAddress = _tb_proxyAddress.Text;
                Properties.Settings.Default.proxyPort = _tb_proxyPort.Text;
                Properties.Settings.Default.proxyUser = _tb_proxyUser.Text;
                Properties.Settings.Default.proxyPassword = _tb_proxyPassword.Text;
            }
            Properties.Settings.Default.alwaysOnTopFlag = this._cb_alwaysOnTop.Checked;
            Properties.Settings.Default.refreshInterval = this._nud_refreshInterval.Value.ToString();
            Properties.Settings.Default.requestTimeout = this._nud_requestTimeout.Value.ToString();

            
            m.changeTopMost(Properties.Settings.Default.alwaysOnTopFlag);

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void _button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            this._cb_proxyFlag.Checked = Properties.Settings.Default.isProxyEnabledFlag;
            if (this._cb_proxyFlag.Checked)
            {
                this._tb_proxyAddress.Enabled = true;
                this._tb_proxyPort.Enabled = true;
                this._tb_proxyUser.Enabled = true;
                this._tb_proxyPassword.Enabled = true;
            }
            else
            {
                this._tb_proxyAddress.Enabled = false;
                this._tb_proxyPort.Enabled = false;
                this._tb_proxyUser.Enabled = false;
                this._tb_proxyPassword.Enabled = false;
            }
            this._tb_proxyAddress.Text = Properties.Settings.Default.proxyAddress;
            this._tb_proxyPort.Text = Properties.Settings.Default.proxyPort;
            this._tb_proxyUser.Text = Properties.Settings.Default.proxyUser;
            this._tb_proxyPassword.Text = Properties.Settings.Default.proxyPassword;
            this._cb_alwaysOnTop.Checked = Properties.Settings.Default.alwaysOnTopFlag;
            this._nud_refreshInterval.Value = Decimal.Parse(Properties.Settings.Default.refreshInterval);
            this._nud_requestTimeout.Value = Decimal.Parse(Properties.Settings.Default.requestTimeout);

            
        }
    }
}
