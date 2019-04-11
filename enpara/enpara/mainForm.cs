using System;
using System.Threading;
using System.Windows.Forms;

namespace enpara
{
    public partial class mainForm : Form
    {
        ThreadStart uiUpdateThreadTS = null;
        Thread uiUpdateThread = null;
        Enpara en = null;

        public delegate void del_updateUI();

        public mainForm()
        {
            InitializeComponent();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            uiUpdateThreadTS = new ThreadStart(getDataFromEnparaAndUpdateUI);
            uiUpdateThread = new Thread(uiUpdateThreadTS);
            uiUpdateThread.Name = "UIUpdate";
            uiUpdateThread.IsBackground = true;
            uiUpdateThread.Start();
            en = new Enpara();

            changeTopMost(Properties.Settings.Default.alwaysOnTopFlag);
            
            
        }

        public void getDataFromEnparaAndUpdateUI()
        {
            del_updateUI DelUpdateUI = new del_updateUI(updateUI);

            while (this.IsHandleCreated)
            {
                this.BeginInvoke(DelUpdateUI);
                Thread.Sleep(Int32.Parse(Properties.Settings.Default.refreshInterval));
            }           

        }

        public void updateUI()
        {
            en.loadResult();
            this._val_enparaDollarBuy.Text = en.EnparaDollarBuy;
            this._val_enparaGoldBuy.Text = en.EnparaGoldBuy;
            this._val_enparaDollarSell.Text = en.EnparaDollarSell;
            this._val_enparaGoldSell.Text = en.EnparaGoldSell;
            
            this._val_dollarDiff.Text = en.DollarDiff;
            this._val_goldDiff.Text = en.GoldDiff;

            setTextAndTextColor(this._val_enparaDollarBuySign, en.DollarBuyChangeSign);
            setTextAndTextColor(this._val_enparaGoldBuySign, en.GoldBuyChangeSign);
            setTextAndTextColor(this._val_enparaDollarSellSign, en.DollarSellChangeSign);
            setTextAndTextColor(this._val_enparaGoldSellSign, en.GoldSellChangeSign);

        }

        public void setTextAndTextColor(System.Windows.Forms.Label l, string val)
        {
            if(Equals(val, "\u25b2"))
            {
                l.ForeColor = System.Drawing.Color.Green;
            }else if (Equals(val, "\u25bc"))
            {
                l.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                l.ForeColor = System.Drawing.Color.YellowGreen;
            }
            l.Text = val;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.qnbfinansbank.enpara.com/doviz-kur-bilgileri/doviz-altin-kurlari.aspx");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.ShowDialog();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            uiUpdateThread.Abort();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm(this);
            settings.ShowDialog();
        }

        public void changeTopMost(bool flag)
        {
            
            this.TopMost = flag;
            this.Update();
        }

        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alarmsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alarmForm af = new alarmForm();
            af.ShowDialog();
        }
    }
}
