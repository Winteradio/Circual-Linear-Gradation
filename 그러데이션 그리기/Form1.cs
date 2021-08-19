using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 그러데이션_그리기
{
    public partial class Form1 : Form
    {
        public int x, y;
        public int nBright;
        public int Cho=0;

        public double X;
        public double Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            for (y=0; y < pictureBox1.Height; y ++ )
            {
                for (x=0; x< pictureBox1.Width; x++)
                {
                    nBright = Convert.ToInt32(Math.Sqrt(Math.Pow(pictureBox1.Width/2-x,2)+Math.Pow(pictureBox1.Height/2-y,2)))*3;
                    if (nBright/255 >= 1)
                    {
                        nBright = nBright%255;
                    }
                    Pen mypen = new Pen(Color.FromArgb(nBright, 100, 100, 100), 0.1f);
                    g.DrawLine(mypen,x, y,x + 1, y +1);
                }
            }
            pictureBox1.Invalidate();
        }
    }
}
