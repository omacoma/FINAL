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


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class point{
            int x,y;
        }
        List<point> L;
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, g.DpiX, g.DpiY, 2, 2);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
