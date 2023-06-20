using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDDrawer2
{
    public partial class Form1 : Form
    {
        public Point current = new Point(0, 0);
        public Point old = new Point(0, 0);
        public Bitmap Thisone;
        public Graphics gr;
        public Graphics _preview;
        Bitmap bitmap = Properties.Resources.Black;
        TextureBrush tBrush;
        Pen pen;
        int _paint = 1;
        int PenSize = 40;
        Image placeimage = Properties.Resources.Black;
        bool Rock = true;

        public Form1()
        {
            InitializeComponent();
            gr = panel1.CreateGraphics();
            _preview = PreviewPen.CreateGraphics();
            tBrush = new TextureBrush(Properties.Resources.Black);
            pen = new Pen(Color.Black, PenSize);
            _PenSize.Text = PenSize.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            current = e.Location;
            tBrush = new TextureBrush(bitmap);
            if (e.Button == MouseButtons.Left && _paint == 1)
            {
                current = e.Location;
                gr.FillEllipse(tBrush, (current.X - (int)PenSize / 2), (current.Y - (int)PenSize / 2), PenSize, PenSize);
                old = current;
            }
            if (e.Button == MouseButtons.Left && _paint == 2)
            {
                if (Rock == true)
                {
                    Random rnd = new Random();
                    switch (rnd.Next(1, 5))
                    {
                        case 1:
                            placeimage = Properties.Resources.Rock1;
                            break;
                        case 2:
                            placeimage = Properties.Resources.Rock2;
                            break;
                        case 3:
                            placeimage = Properties.Resources.Rock3;
                            break;
                        case 4:
                            placeimage = Properties.Resources.Rock4;
                            break;
                    }

                }
                gr.DrawImage(placeimage, (current.X - 18), (current.Y - 18), 35, 35);
            }
            if (e.Button == MouseButtons.Left && _paint == 3)
            {
                current = e.Location;
                gr.FillRectangle(tBrush, (current.X - (int)PenSize / 2), (current.Y - (int)PenSize / 2), PenSize, PenSize);
                old = current;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && _paint == 1)
            {
                current = e.Location;
                gr.FillEllipse(tBrush, (current.X - (int)PenSize/2), (current.Y - (int)PenSize / 2), PenSize, PenSize);
                old = current;
            }
            if (e.Button == MouseButtons.Left && _paint == 3)
            {
                current = e.Location;
                gr.FillRectangle(tBrush, (current.X - (int)PenSize / 2), (current.Y - (int)PenSize / 2), PenSize, PenSize);
                old = current;
            }
            Yvalue.Text = e.Location.Y.ToString();
            Xvalue.Text = e.Location.X.ToString();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            gr = panel1.CreateGraphics();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Properties.Resources.Black);
            SetPaintPreview();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Properties.Resources.CaveFloor);
            SetPaintPreview();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Properties.Resources.CaveWall);
            SetPaintPreview();
        }

        private void _Water_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Properties.Resources.Water);
            SetPaintPreview();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PenSize = (int)_PenSize.Value;
            _preview.Clear(Color.White);
            SetPaintPreview();

        }
        public void SetPaintPreview()
        {
            tBrush = new TextureBrush(bitmap);
            _preview.Clear(Color.White);
            if (_paint == 1)
            {
                _preview.FillEllipse(tBrush, (134 - PenSize), (134 - PenSize), PenSize, PenSize);
            }
            else if (_paint == 2)
            {
                
                _preview.DrawImage(placeimage, (current.X), (current.Y), 35, 35);
            }
            else if (_paint == 3)
            {
                _preview.FillRectangle(tBrush, (current.X), (current.Y), PenSize, PenSize);
            }
            
        }

        private void WoodFloor_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Properties.Resources.WoodFloor);
            SetPaintPreview();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.Black);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveMap.Filter = "Png Image (.png)|*.png";
            SaveMap.ShowDialog();
            var path = SaveMap.FileName;

            Bitmap savebit = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(savebit, new Rectangle(0, 0, panel1.Width, panel1.Height));
            bitmap.Save(path, ImageFormat.Png);
        }

        private void Chest_Click(object sender, EventArgs e)
        {
            placeimage = Properties.Resources.Chest;
            Rock = false;
            SetPaintPreview();
        }

        private void Paint_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Pintbrush_CheckedChanged(object sender, EventArgs e)
        {
            _paint = 1;
            Rock = false;
            Place.Enabled = false;
            Paint.Enabled = true;
            SetPaintPreview();
        }

        private void PlaceBrush_CheckedChanged(object sender, EventArgs e)
        {
            _paint = 2;
            Paint.Enabled = false;
            Place.Enabled = true;
            SetPaintPreview();
        }

        private void BrushLines_CheckedChanged(object sender, EventArgs e)
        {
            _paint = 3;
            Rock = false;
            Place.Enabled = false;
            Paint.Enabled = true;
            SetPaintPreview();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            placeimage = Properties.Resources.Ladder;
            Rock = false;
            SetPaintPreview();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Rock = true;
            placeimage = Properties.Resources.Rock1;
            SetPaintPreview();
        }


    }
}
