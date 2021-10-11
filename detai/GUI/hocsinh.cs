using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detai.GUI
{
    public partial class hocsinh : Form
    {
        public hocsinh(string n)
        {

            
            InitializeComponent();
            lbmahs.Text = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gIAODIỆNCHÍNHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cHỌNGIAODIỆNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hỌCPHÍToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LavenderBlush;
            button2.Location= new Point(125, 55);
            button2.ForeColor = Color.Black;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Pink;
            button2.Location = new Point(136, 63);
            button2.ForeColor = Color.White;
        }

        private void xEMTHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hocsinh_Load(object sender, EventArgs e)
        {
            
            ptrGT.Image = Image.FromFile("hocsinh.png");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void chứcNăngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mthd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbmahs_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
