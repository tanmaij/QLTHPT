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
    public partial class TTGV : Form
    {
        public string ma;
        public TTGV()
        {
            InitializeComponent();
        }

        private void TTGV_Load(object sender, EventArgs e)
        {
            hienthongtin();
        }
        public void hienthongtin()
        {
              GIAOVIENDTO gv = new GIAOVIENDTO();
                gv.magv = ma;
                DataTable dt = new DataTable();
                dt = GIAOVIENDAO.ttctgv(gv);
                lbmaso.Text = ma;
                hoten.Text = dt.Rows[0]["TENGV"].ToString();
                if (dt.Rows[0]["GIOITINH"].ToString() == "0")
                    rbnam.Checked = true;
                else if (dt.Rows[0]["GIOITINH"].ToString() == "1")
                    rbnu.Checked = true;
                datengaysinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
                diachi.Text = dt.Rows[0]["DIACHI"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["NGAYVAOTRUONG"].ToString();
                try
                {
                    pictureBox2.Image = HINHANHDAO.Image_Object(ma);
                }
                catch
                {
                    pictureBox2.Image = Image.FromFile("gvcn.png");
                }
            cbbchucvu.Text= dt.Rows[0]["MACV"].ToString();

        }
    }
}
