using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Color c = Color.FromArgb(r.Next(255), 0, 0);
                SolidBrush b = new SolidBrush(c);
                int circleSize = r.Next(20,this.Height / 6);
                e.Graphics.FillEllipse(b,
                    r.Next(this.Width - circleSize),
                    r.Next(this.Height - circleSize),
                    circleSize,
                    circleSize);
            }
        }
    }
}
