using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLED
{
    public partial class Form1 : Form
    {
        Bitmap drawnBmp = null;
        

        string _filename = null;

        bool start = false;
        bool isMoved = false;

        enum bufferEnum { reset = 0, set };

        byte[,] _buffer = new byte[128,64];

        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
            drawnBmp = new Bitmap(128, 64, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            

        }

        int x = 0;
        int y = 0;
        Graphics gp;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            start = false;
            if (!isMoved)
            {
                if (_rb_draw.Checked)
                {
                    //normalizePosition(e.X, e.Y, out x, out y);
                    gp.FillRectangle(Brushes.Black, x + 1, y + 1, 6, 6);
                    updateBufferAt(x / 7, y / 7, bufferEnum.set);
                    drawnBmp.SetPixel(x / 7, y / 7, Color.White);
                }
                else
                {
                    //normalizePosition(e.X, e.Y, out x, out y);
                    gp.FillRectangle(Brushes.White, x + 1, y + 1, 6, 6);
                    updateBufferAt(x / 7, y / 7, bufferEnum.reset);
                    drawnBmp.SetPixel(x / 7, y / 7, Color.White);

                }
            }
            x = 0;
            y = 0;
            isMoved = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.Y > 0 && e.X < 896 && e.Y < 447)
            {
                normalizePosition(e.X, e.Y, out x, out y);
                if (start)
                {
                    if (_rb_draw.Checked)
                    {
                        //normalizePosition(e.X, e.Y, out x, out y);
                        gp.FillRectangle(Brushes.Red, x + 1, y + 1, 6, 6);
                        updateBufferAt(x / 7, y / 7, bufferEnum.set);
                    }
                    else
                    {
                        //normalizePosition(e.X, e.Y, out x, out y);
                        gp.FillRectangle(Brushes.White, x + 1, y + 1, 6, 6);
                        updateBufferAt(x / 7, y / 7, bufferEnum.reset);
                    }
                    
                }

                isMoved = true;
            }

            _label_xCoordinate.Text = (x/7).ToString();
            _label_yCoordinate.Text = (y/7).ToString();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            start = true;
            isMoved = false;
        }

        void updateBufferAt (int x, int y, bufferEnum b)
        {
            _buffer[x, y] = (byte)b;
        }

        void normalizePosition (int x, int y, out int newX, out int newY)
        {
            newX = x - x % 7;
            newY = y - y % 7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            clearPanel();
        }

        private void _button_loadBitmap_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                _filename = openFileDialog.FileName;
            }

            
            
        }

        private void _button_saveBitmap_Click(object sender, EventArgs e)
        {
            drawnBmp.Save("C:\\Users\\u00747649\\source\\repos\\OLED\\testfile.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        void clearPanel()
        {
            gp.FillRectangle(Brushes.White, 0, 0, 897, 449);
            for (int i = 0; i < 897; i += 7)
            {
                gp.DrawLine(new Pen(Color.LightGray, 1), i, 0, i, 448);
            }
            for (int j = 0; j < 449; j += 7)
            {
                gp.DrawLine(new Pen(Color.LightGray, 1), 0, j, 896, j);
            }
        }

        private void _button_clear_Click(object sender, EventArgs e)
        {
            clearPanel();
        }

        void serialInit()
        {
            string[] ports = SerialPort.GetPortNames();
        }
    }
}