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
    public partial class quanlyhethong : Form
    {
        public quanlyhethong()
        {
            InitializeComponent();
        }

        private void quanlyhethong_Load(object sender, EventArgs e)
        {
            ptrgv.Image = Image.FromFile("Teachers-icon.png");
            ptrhs.Image = Image.FromFile("iconstudien.png");
            ptrnv.Image = Image.FromFile("Preppy-icon.png");
            ptrnh.Image = Image.FromFile("Study-icon.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            QUANLYLOP lop = new QUANLYLOP();
            lop.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLGIAOVIEN gv =new QLGIAOVIEN();
            gv.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            QUANLYNHANVIEN gv = new QUANLYNHANVIEN();
            gv.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QUANLYHOCSINH gv = new QUANLYHOCSINH();
            gv.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QUANLYTAIKHOAN tk = new QUANLYTAIKHOAN();
            
            tk.Show();
           // this.Hide();
        }
    }
}
