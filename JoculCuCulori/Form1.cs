using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JoculCuCulori
{
    public partial class Form1: Form
    {
        Graphics handler;
        Bitmap bitmap;
        Map map;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            handler = Graphics.FromImage(bitmap);
            pictureBox1.Click += PictureBox1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Map();
            map.Draw(handler);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = pictureBox1.PointToClient(MousePosition).ToString();
            Point point = pictureBox1.PointToClient(MousePosition);

            Point relpos = new Point(point.X - Map.left, point.Y - Map.top);
            int row = relpos.Y / Map.size;
            int col = relpos.X / Map.size;
            label2.Text = "Row: " + row.ToString() + " Col: " + col.ToString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Point point = pictureBox1.PointToClient(MousePosition);
            Point relpos = new Point(point.X - Map.left, point.Y - Map.top);
            int row = relpos.Y / Map.size;
            int col = relpos.X / Map.size;

            timer1.Enabled = true;
            timer2.Enabled = false;
            pictureBox1.Enabled = false;

            map.SetNull();
            map.PA(row, col, map.values[row, col]);
            map.Calculus();

            if (map.EtapR())
            {
                pictureBox1.Enabled = true;
                timer2.Enabled = false;
            }

            map.Draw(handler);
            pictureBox1.Image = bitmap;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (map.EtapR())
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            map.Draw(handler);
            pictureBox1.Image = bitmap;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (map.EtapC())
            {
                if (map.EtapR())
                {
                    pictureBox1.Enabled = true;
                    timer2.Enabled = false;
                }
                pictureBox1.Enabled = true;
                timer2.Enabled = false;
            }
            map.Draw(handler);
            pictureBox1.Image = bitmap;
        }
    }
}
