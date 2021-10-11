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

namespace detai.GUI
{
    public partial class QUANLYDIEMTHISINH : Form
    {
        public QUANLYDIEMTHISINH()
        {
            InitializeComponent();
        }
        public void THONGTINTHISINH()
        {
            DataTable dt = new DataTable();
            dt = THISINHBUS.THONGTINTHISINH();
            int sots = dt.Rows.Count;
            int i;
            for (i = 0; i < sots; i++)
            {
                LVWDSTHISINH.Items.Add(dt.Rows[i]["MATHISINH"].ToString());
                LVWDSTHISINH.Items[i].SubItems.Add(dt.Rows[i]["HOTEN"].ToString());
                LVWDSTHISINH.Items[i].SubItems.Add(dt.Rows[i]["NGAYSINH"].ToString());
                if (dt.Rows[i]["GIOITINH"].ToString() == "1")
                {
                    LVWDSTHISINH.Items[i].SubItems.Add("Nam");
                }
                else
                {
                    LVWDSTHISINH.Items[i].SubItems.Add("Nữ");

                }
                LVWDSTHISINH.Items[i].SubItems.Add(dt.Rows[i]["DIACHI"].ToString());
            }
        }
        private void QUANLYDIEMTHISINH_Load(object sender, EventArgs e)
        {
            THONGTINTHISINH();
        }

        private void LVWDSTHISINH_Click(object sender, EventArgs e)
        {
            TXTMATS.Text = LVWDSTHISINH.SelectedItems[0].Text;
            lbHOTEN.Text = LVWDSTHISINH.SelectedItems[0].SubItems[1].Text;

        }

        private void QUANLYDIEMTHISINH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BTNHAPDIEM_Click(object sender, EventArgs e)
        {
            DIEMTHISINHDTO ts = new DIEMTHISINHDTO();
            ts.mats = TXTMATS.Text;
            ts.DIEMTOAN =float.Parse( TXTDIEMTOAN.Text);
            ts.DIEMNV = float.Parse(TXTDIEMNGUVAN.Text);
            ts.DIEMAV = float.Parse(TXTDIEMANHVAN.Text);
            ts.DIEMTONG = ts.DIEMTOAN * 2 + ts.DIEMNV * 2 + ts.DIEMAV;
            THISINHDAO.NHAPDIEM(ts);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void LVWDSTHISINH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
