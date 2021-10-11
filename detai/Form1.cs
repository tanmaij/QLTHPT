using detai.BUS;
using detai.DAO;
using detai.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //HIỆN RA FORM THÊM GV
       /* public void MONHOCGV()
        {
            DataTable dt = new DataTable();
            dt = GIAOVIENBUS.MONHOC();
            monhoc.DataSource = dt;
            monhoc.DisplayMember = "TENMH";
            monhoc.ValueMember = "TENMH";
        } */


        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void TXTHOTEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTTHEM_Click(object sender, EventArgs e)
        {
            
            GIAOVIENDTO gv = new GIAOVIENDTO();
            gv.magv = TXTMAGV.Text;
            gv.tengv = TXTHOTEN.Text;
            
           // GIAOVIENDAO.themgv(gv);
        }
    }
}
