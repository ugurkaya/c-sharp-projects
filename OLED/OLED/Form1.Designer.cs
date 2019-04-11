namespace OLED
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._rb_erase = new System.Windows.Forms.RadioButton();
            this._rb_draw = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._label_xCoordinate = new System.Windows.Forms.Label();
            this._label_yCoordinate = new System.Windows.Forms.Label();
            this._button_loadBitmap = new System.Windows.Forms.Button();
            this._button_saveBitmap = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._button_clear = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rb_erase);
            this.groupBox1.Controls.Add(this._rb_draw);
            this.groupBox1.Location = new System.Drawing.Point(917, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing";
            // 
            // _rb_erase
            // 
            this._rb_erase.AutoSize = true;
            this._rb_erase.Location = new System.Drawing.Point(6, 42);
            this._rb_erase.Name = "_rb_erase";
            this._rb_erase.Size = new System.Drawing.Size(52, 17);
            this._rb_erase.TabIndex = 4;
            this._rb_erase.Text = "Erase";
            this._rb_erase.UseVisualStyleBackColor = true;
            // 
            // _rb_draw
            // 
            this._rb_draw.AutoSize = true;
            this._rb_draw.Checked = true;
            this._rb_draw.Location = new System.Drawing.Point(6, 19);
            this._rb_draw.Name = "_rb_draw";
            this._rb_draw.Size = new System.Drawing.Size(50, 17);
            this._rb_draw.TabIndex = 3;
            this._rb_draw.TabStop = true;
            this._rb_draw.Text = "Draw";
            this._rb_draw.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1041, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1041, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // _label_xCoordinate
            // 
            this._label_xCoordinate.AutoSize = true;
            this._label_xCoordinate.Location = new System.Drawing.Point(1064, 31);
            this._label_xCoordinate.Name = "_label_xCoordinate";
            this._label_xCoordinate.Size = new System.Drawing.Size(13, 13);
            this._label_xCoordinate.TabIndex = 2;
            this._label_xCoordinate.Text = "0";
            // 
            // _label_yCoordinate
            // 
            this._label_yCoordinate.AutoSize = true;
            this._label_yCoordinate.Location = new System.Drawing.Point(1064, 59);
            this._label_yCoordinate.Name = "_label_yCoordinate";
            this._label_yCoordinate.Size = new System.Drawing.Size(13, 13);
            this._label_yCoordinate.TabIndex = 2;
            this._label_yCoordinate.Text = "0";
            // 
            // _button_loadBitmap
            // 
            this._button_loadBitmap.Location = new System.Drawing.Point(939, 107);
            this._button_loadBitmap.Name = "_button_loadBitmap";
            this._button_loadBitmap.Size = new System.Drawing.Size(75, 23);
            this._button_loadBitmap.TabIndex = 3;
            this._button_loadBitmap.Text = "Load Bitmap";
            this._button_loadBitmap.UseVisualStyleBackColor = true;
            this._button_loadBitmap.Click += new System.EventHandler(this._button_loadBitmap_Click);
            // 
            // _button_saveBitmap
            // 
            this._button_saveBitmap.Location = new System.Drawing.Point(1020, 107);
            this._button_saveBitmap.Name = "_button_saveBitmap";
            this._button_saveBitmap.Size = new System.Drawing.Size(75, 23);
            this._button_saveBitmap.TabIndex = 3;
            this._button_saveBitmap.Text = "Save Bitmap";
            this._button_saveBitmap.UseVisualStyleBackColor = true;
            this._button_saveBitmap.Click += new System.EventHandler(this._button_saveBitmap_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Bitmap Files|*.bmp";
            // 
            // _button_clear
            // 
            this._button_clear.Location = new System.Drawing.Point(939, 136);
            this._button_clear.Name = "_button_clear";
            this._button_clear.Size = new System.Drawing.Size(75, 23);
            this._button_clear.TabIndex = 3;
            this._button_clear.Text = "Clear";
            this._button_clear.UseVisualStyleBackColor = true;
            this._button_clear.Click += new System.EventHandler(this._button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 476);
            this.Controls.Add(this._button_saveBitmap);
            this.Controls.Add(this._button_clear);
            this.Controls.Add(this._button_loadBitmap);
            this.Controls.Add(this._label_yCoordinate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._label_xCoordinate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "OLED";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _rb_erase;
        private System.Windows.Forms.RadioButton _rb_draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _label_xCoordinate;
        private System.Windows.Forms.Label _label_yCoordinate;
        private System.Windows.Forms.Button _button_loadBitmap;
        private System.Windows.Forms.Button _button_saveBitmap;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button _button_clear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.IO.Ports.SerialPort serialPort;
    }
}

