using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<float> L, D;
        public void pictureBox1_Click(object sender, Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, g.DpiX, g.DpiY, 2, 2);
            L.Add(g.DpiX);
            D.Add(g.DpiY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
