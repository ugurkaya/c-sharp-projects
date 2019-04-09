namespace enpara
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tabs_settings = new System.Windows.Forms.TabControl();
            this._tab_general = new System.Windows.Forms.TabPage();
            this._cb_alwaysOnTop = new System.Windows.Forms.CheckBox();
            this._tab_network = new System.Windows.Forms.TabPage();
            this._gb_proxy = new System.Windows.Forms.GroupBox();
            this._label_proxyPassword = new System.Windows.Forms.Label();
            this._label_proxyUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._tb_proxyPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tb_proxyUser = new System.Windows.Forms.TextBox();
            this._tb_proxyPort = new System.Windows.Forms.TextBox();
            this._tb_proxyAddress = new System.Windows.Forms.TextBox();
            this._cb_proxyFlag = new System.Windows.Forms.CheckBox();
            this._tab_notifications = new System.Windows.Forms.TabPage();
            this._button_cancel = new System.Windows.Forms.Button();
            this._button_save = new System.Windows.Forms.Button();
            this._nud_refreshInterval = new System.Windows.Forms.NumericUpDown();
            this._nud_requestTimeout = new System.Windows.Forms.NumericUpDown();
            this._label_interval = new System.Windows.Forms.Label();
            this._label_timeout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._tabs_settings.SuspendLayout();
            this._tab_general.SuspendLayout();
            this._tab_network.SuspendLayout();
            this._gb_proxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nud_refreshInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nud_requestTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabs_settings
            // 
            this._tabs_settings.Controls.Add(this._tab_general);
            this._tabs_settings.Controls.Add(this._tab_network);
            this._tabs_settings.Controls.Add(this._tab_notifications);
            this._tabs_settings.Location = new System.Drawing.Point(12, 12);
            this._tabs_settings.Name = "_tabs_settings";
            this._tabs_settings.SelectedIndex = 0;
            this._tabs_settings.Size = new System.Drawing.Size(216, 203);
            this._tabs_settings.TabIndex = 5;
            // 
            // _tab_general
            // 
            this._tab_general.Controls.Add(this.label6);
            this._tab_general.Controls.Add(this._label_timeout);
            this._tab_general.Controls.Add(this.label5);
            this._tab_general.Controls.Add(this._label_interval);
            this._tab_general.Controls.Add(this._nud_requestTimeout);
            this._tab_general.Controls.Add(this._nud_refreshInterval);
            this._tab_general.Controls.Add(this._cb_alwaysOnTop);
            this._tab_general.Location = new System.Drawing.Point(4, 22);
            this._tab_general.Name = "_tab_general";
            this._tab_general.Padding = new System.Windows.Forms.Padding(3);
            this._tab_general.Size = new System.Drawing.Size(208, 177);
            this._tab_general.TabIndex = 0;
            this._tab_general.Text = "General";
            this._tab_general.UseVisualStyleBackColor = true;
            // 
            // _cb_alwaysOnTop
            // 
            this._cb_alwaysOnTop.AutoSize = true;
            this._cb_alwaysOnTop.Location = new System.Drawing.Point(19, 36);
            this._cb_alwaysOnTop.Name = "_cb_alwaysOnTop";
            this._cb_alwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this._cb_alwaysOnTop.TabIndex = 0;
            this._cb_alwaysOnTop.Text = "Always on top";
            this._cb_alwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // _tab_network
            // 
            this._tab_network.Controls.Add(this._gb_proxy);
            this._tab_network.Location = new System.Drawing.Point(4, 22);
            this._tab_network.Name = "_tab_network";
            this._tab_network.Padding = new System.Windows.Forms.Padding(3);
            this._tab_network.Size = new System.Drawing.Size(208, 177);
            this._tab_network.TabIndex = 1;
            this._tab_network.Text = "Network";
            this._tab_network.UseVisualStyleBackColor = true;
            // 
            // _gb_proxy
            // 
            this._gb_proxy.Controls.Add(this._label_proxyPassword);
            this._gb_proxy.Controls.Add(this._label_proxyUser);
            this._gb_proxy.Controls.Add(this.label2);
            this._gb_proxy.Controls.Add(this._tb_proxyPassword);
            this._gb_proxy.Controls.Add(this.label1);
            this._gb_proxy.Controls.Add(this._tb_proxyUser);
            this._gb_proxy.Controls.Add(this._tb_proxyPort);
            this._gb_proxy.Controls.Add(this._tb_proxyAddress);
            this._gb_proxy.Controls.Add(this._cb_proxyFlag);
            this._gb_proxy.Location = new System.Drawing.Point(6, 6);
            this._gb_proxy.Name = "_gb_proxy";
            this._gb_proxy.Size = new System.Drawing.Size(194, 164);
            this._gb_proxy.TabIndex = 6;
            this._gb_proxy.TabStop = false;
            this._gb_proxy.Text = "Proxy";
            // 
            // _label_proxyPassword
            // 
            this._label_proxyPassword.AutoSize = true;
            this._label_proxyPassword.Location = new System.Drawing.Point(3, 132);
            this._label_proxyPassword.Name = "_label_proxyPassword";
            this._label_proxyPassword.Size = new System.Drawing.Size(53, 13);
            this._label_proxyPassword.TabIndex = 2;
            this._label_proxyPassword.Text = "Password";
            // 
            // _label_proxyUser
            // 
            this._label_proxyUser.AutoSize = true;
            this._label_proxyUser.Location = new System.Drawing.Point(3, 106);
            this._label_proxyUser.Name = "_label_proxyUser";
            this._label_proxyUser.Size = new System.Drawing.Size(58, 13);
            this._label_proxyUser.TabIndex = 2;
            this._label_proxyUser.Text = "Proxy User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proxy Port";
            // 
            // _tb_proxyPassword
            // 
            this._tb_proxyPassword.Location = new System.Drawing.Point(82, 129);
            this._tb_proxyPassword.MaxLength = 15;
            this._tb_proxyPassword.Name = "_tb_proxyPassword";
            this._tb_proxyPassword.PasswordChar = '*';
            this._tb_proxyPassword.Size = new System.Drawing.Size(100, 20);
            this._tb_proxyPassword.TabIndex = 4;
            this._tb_proxyPassword.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy Address";
            // 
            // _tb_proxyUser
            // 
            this._tb_proxyUser.Location = new System.Drawing.Point(82, 103);
            this._tb_proxyUser.Name = "_tb_proxyUser";
            this._tb_proxyUser.Size = new System.Drawing.Size(100, 20);
            this._tb_proxyUser.TabIndex = 3;
            this._tb_proxyUser.Text = "User";
            // 
            // _tb_proxyPort
            // 
            this._tb_proxyPort.Location = new System.Drawing.Point(82, 76);
            this._tb_proxyPort.MaxLength = 5;
            this._tb_proxyPort.Name = "_tb_proxyPort";
            this._tb_proxyPort.Size = new System.Drawing.Size(100, 20);
            this._tb_proxyPort.TabIndex = 2;
            this._tb_proxyPort.Text = "Port";
            // 
            // _tb_proxyAddress
            // 
            this._tb_proxyAddress.Location = new System.Drawing.Point(82, 50);
            this._tb_proxyAddress.Name = "_tb_proxyAddress";
            this._tb_proxyAddress.Size = new System.Drawing.Size(100, 20);
            this._tb_proxyAddress.TabIndex = 1;
            this._tb_proxyAddress.Text = "Address";
            // 
            // _cb_proxyFlag
            // 
            this._cb_proxyFlag.AutoSize = true;
            this._cb_proxyFlag.Location = new System.Drawing.Point(6, 19);
            this._cb_proxyFlag.Name = "_cb_proxyFlag";
            this._cb_proxyFlag.Size = new System.Drawing.Size(73, 17);
            this._cb_proxyFlag.TabIndex = 0;
            this._cb_proxyFlag.Text = "Use proxy";
            this._cb_proxyFlag.UseVisualStyleBackColor = true;
            // 
            // _tab_notifications
            // 
            this._tab_notifications.Location = new System.Drawing.Point(4, 22);
            this._tab_notifications.Name = "_tab_notifications";
            this._tab_notifications.Padding = new System.Windows.Forms.Padding(3);
            this._tab_notifications.Size = new System.Drawing.Size(208, 243);
            this._tab_notifications.TabIndex = 2;
            this._tab_notifications.Text = "Notifications";
            this._tab_notifications.UseVisualStyleBackColor = true;
            // 
            // _button_cancel
            // 
            this._button_cancel.Location = new System.Drawing.Point(72, 221);
            this._button_cancel.Name = "_button_cancel";
            this._button_cancel.Size = new System.Drawing.Size(75, 23);
            this._button_cancel.TabIndex = 8;
            this._button_cancel.Text = "Cancel";
            this._button_cancel.UseVisualStyleBackColor = true;
            this._button_cancel.Click += new System.EventHandler(this._button_cancel_Click);
            // 
            // _button_save
            // 
            this._button_save.Location = new System.Drawing.Point(153, 221);
            this._button_save.Name = "_button_save";
            this._button_save.Size = new System.Drawing.Size(75, 23);
            this._button_save.TabIndex = 9;
            this._button_save.Text = "Save";
            this._button_save.UseVisualStyleBackColor = true;
            this._button_save.Click += new System.EventHandler(this._button_save_Click);
            // 
            // _nud_refreshInterval
            // 
            this._nud_refreshInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._nud_refreshInterval.Location = new System.Drawing.Point(100, 69);
            this._nud_refreshInterval.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this._nud_refreshInterval.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._nud_refreshInterval.Name = "_nud_refreshInterval";
            this._nud_refreshInterval.Size = new System.Drawing.Size(54, 20);
            this._nud_refreshInterval.TabIndex = 1;
            this._nud_refreshInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // _nud_requestTimeout
            // 
            this._nud_requestTimeout.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this._nud_requestTimeout.Location = new System.Drawing.Point(100, 105);
            this._nud_requestTimeout.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this._nud_requestTimeout.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this._nud_requestTimeout.Name = "_nud_requestTimeout";
            this._nud_requestTimeout.Size = new System.Drawing.Size(54, 20);
            this._nud_requestTimeout.TabIndex = 1;
            this._nud_requestTimeout.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // _label_interval
            // 
            this._label_interval.AutoSize = true;
            this._label_interval.Location = new System.Drawing.Point(16, 71);
            this._label_interval.Name = "_label_interval";
            this._label_interval.Size = new System.Drawing.Size(82, 13);
            this._label_interval.TabIndex = 2;
            this._label_interval.Text = "Refresh Interval";
            // 
            // _label_timeout
            // 
            this._label_timeout.AutoSize = true;
            this._label_timeout.Location = new System.Drawing.Point(16, 107);
            this._label_timeout.Name = "_label_timeout";
            this._label_timeout.Size = new System.Drawing.Size(45, 13);
            this._label_timeout.TabIndex = 2;
            this._label_timeout.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ms";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 255);
            this.Controls.Add(this._button_cancel);
            this.Controls.Add(this._button_save);
            this.Controls.Add(this._tabs_settings);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this._tabs_settings.ResumeLayout(false);
            this._tab_general.ResumeLayout(false);
            this._tab_general.PerformLayout();
            this._tab_network.ResumeLayout(false);
            this._gb_proxy.ResumeLayout(false);
            this._gb_proxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nud_refreshInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nud_requestTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabs_settings;
        private System.Windows.Forms.TabPage _tab_general;
        private System.Windows.Forms.TabPage _tab_network;
        private System.Windows.Forms.GroupBox _gb_proxy;
        private System.Windows.Forms.Label _label_proxyPassword;
        private System.Windows.Forms.Label _label_proxyUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tb_proxyPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tb_proxyUser;
        private System.Windows.Forms.TextBox _tb_proxyPort;
        private System.Windows.Forms.TextBox _tb_proxyAddress;
        private System.Windows.Forms.CheckBox _cb_proxyFlag;
        private System.Windows.Forms.Button _button_cancel;
        private System.Windows.Forms.Button _button_save;
        private System.Windows.Forms.TabPage _tab_notifications;
        private System.Windows.Forms.CheckBox _cb_alwaysOnTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _label_timeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _label_interval;
        private System.Windows.Forms.NumericUpDown _nud_requestTimeout;
        private System.Windows.Forms.NumericUpDown _nud_refreshInterval;
    }
}