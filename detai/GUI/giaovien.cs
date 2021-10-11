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

namespace detai.GUI
{
    public partial class giaovien : Form
    {
        public string magv;
        public giaovien()
        {
            InitializeComponent();
        }

        private void giaovien_Load(object sender, EventArgs e)
        {
            
            lbmahs.Text = magv;
            GIAOVIENDTO gv = new GIAOVIENDTO();
            gv.magv = magv;
            DataTable dt = new DataTable();
            dt=GIAOVIENDAO.ttctgv(gv);
            lbtengv.Text = dt.Rows[0]["TENGV"].ToString();
            try
            {
                ptrGT.Image = HINHANHDAO.Image_Object(magv);
            }
            catch
            {
                ptrGT.Image = Image.FromFile("gvnam.png");
            }
            if(checkCHUNHIEM(magv)==false)
            {
                btnhanhkiem.Enabled = false;
                btnhocba.Enabled = false;
            }
            else { }
        }
        bool checkCHUNHIEM(string magv)
        {
            DataTable dt = new DataTable();
            dt = GIAOVIENDAO.GVCN(magv);
            if (dt.Rows.Count == 0)
                return false;
            else return true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TTGV ttgv = new TTGV();
            ttgv.ma = magv;
            ttgv.Show();
        }
    }
}
