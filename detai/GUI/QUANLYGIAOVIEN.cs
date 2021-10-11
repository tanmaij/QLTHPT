using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using detai.BUS;
using detai.DAO;
using detai.DTO;

namespace detai.GUI
{
    public partial class QUANLYGIAOVIEN : Form
    {
        public QUANLYGIAOVIEN()
        {
            InitializeComponent();
        }
        public void THONGTINGIAOVIEN()
        {
            DataTable dt = new DataTable();
            dt = GIAOVIENBUS.THONGTINGIAOVIEN();
            int sogv = dt.Rows.Count;
            int i;
            for (i = 0; i < sogv; i++)
            {
                lvwGIAOVIEN.Items.Add(dt.Rows[i]["MAGV"].ToString());
                lvwGIAOVIEN.Items[i].SubItems.Add(dt.Rows[i]["TENGV"].ToString());
                lvwGIAOVIEN.Items[i].SubItems.Add(dt.Rows[i]["NGAYSINH"].ToString());
                if (dt.Rows[i]["GIOITINH"].ToString() == "1")
                {
                    lvwGIAOVIEN.Items[i].SubItems.Add("Nam");
                }
                else if (dt.Rows[i]["GIOITINH"].ToString() == "0")
                {
                    lvwGIAOVIEN.Items[i].SubItems.Add("Nữ");

                }
                lvwGIAOVIEN.Items[i].SubItems.Add(dt.Rows[i]["DIACHI"].ToString());
                lvwGIAOVIEN.Items[i].SubItems.Add(dt.Rows[i]["NGAYVAOTRUONG"].ToString());
            }
        }
        public void KHOI()
        {
            DataTable dt = new DataTable();
            dt = GIAOVIENBUS.KHOI();
            cbKHOI.DataSource = dt;
            cbKHOI.DisplayMember = "SOKHOI";
            cbKHOI.ValueMember = "SOKHOI";
        }
        public void THONGTINMONHOC()
        {

            if (cbKHOI.Text == "10")
            {
                lstmonhoc.Items.Clear();

                DataTable dt = new DataTable();
                dt = GIAOVIENBUS.laymonhoc10();
                int somh = dt.Rows.Count;
                int i;
                for (i = 0; i < somh; i++)
                {
                    lstmonhoc.Items.Add(dt.Rows[i]["MAMH"].ToString());
                    lstmonhoc.Items[i].SubItems.Add(dt.Rows[i]["TENMH"].ToString());
                }
            }
            else if (cbKHOI.Text == "11")
            {


                lstmonhoc.Items.Clear();

                DataTable dt = new DataTable();
                dt = GIAOVIENBUS.laymonhoc11();
                int somh = dt.Rows.Count;
                int i;
                for (i = 0; i < somh; i++)
                {
                    lstmonhoc.Items.Add(dt.Rows[i]["MAMH"].ToString());
                    lstmonhoc.Items[i].SubItems.Add(dt.Rows[i]["TENMH"].ToString());
                }
            
        }
            else if (cbKHOI.Text == "12")
            {


                lstmonhoc.Items.Clear();
                DataTable dt = new DataTable();
                dt = GIAOVIENBUS.laymonhoc12();
                int somh = dt.Rows.Count;
                int i;
                for (i = 0; i < somh; i++)
                {
                    lstmonhoc.Items.Add(dt.Rows[i]["MAMH"].ToString());
                    lstmonhoc.Items[i].SubItems.Add(dt.Rows[i]["TENMH"].ToString());
                }
            }
        }
        
        private void QUANLYGIAOVIEN_Load(object sender, EventArgs e)
        {
            demo.Enabled = false;
            gbqlmon.Enabled = false;
            gbthongtingiaovien.Enabled = false;
            THONGTINGIAOVIEN();

            KHOI();
        }

        private void BTTHEM_Click(object sender, EventArgs e)
        {
            GIAOVIENDTO gv = new GIAOVIENDTO();
            DateTime now = DateTime.Now;
            gv.magv = TXTMAGV.Text;
            gv.tengv = TXTHOTEN.Text;
            gv.ngaysinh = TXTNGAYSINH.Text;
            if (RDBNAM.Checked == true)
            {
                gv.gioitinh = 1;
            }
            else if (RDBNU.Checked == true)
            { gv.gioitinh = 0;
            }
            gv.diachi = TXTDIACHI.Text;
            gv.ngayvaotruong =  TXTNGAYVAOTRUONG.Text;
            
         //   GIAOVIENDAO.themgv(gv,cv);
            lvwGIAOVIEN.Items.Clear();
            THONGTINGIAOVIEN();
            
        }

        private void cbKHOI_SelectedIndexChanged(object sender, EventArgs e)
        {

            btxoamon.Enabled=false;
            btthemmon.Enabled = true;
            THONGTINMONHOC();
        }

        private void cbKHOI_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lvwGIAOVIEN_Click(object sender, EventArgs e)
        {
            btthemmon.Enabled = false;
            btxoamon.Enabled = true;

            TXTHOTEN.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[1].Text;
            TXTMAGV.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[0].Text;
            TXTNGAYSINH.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[2].Text;
            TXTDIACHI.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[4].Text;
            TXTNGAYVAOTRUONG.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[5].Text;
            if (lvwGIAOVIEN.SelectedItems[0].SubItems[3].Text == "Nam")
            {
                RDBNAM.Checked = true;
            }
            else
            {
                RDBNU.Checked = true;
            }
            lstmonhoc.Items.Clear();
            MONCUAGV();

        }

        private void btthemmon_Click(object sender, EventArgs e)
        {
            

            GIAOVIENDTO gv = new GIAOVIENDTO();
            MONHOCDTO mh = new MONHOCDTO();
            gv.magv = TXTMAGV.Text;
            mh.mamh = lstmonhoc.SelectedItems[0].SubItems[0].Text;
            GIAOVIENDAO.themmonchogv(gv, mh);
            
        }
        public void MONCUAGV()
        {
            GIAOVIENDTO gv = new GIAOVIENDTO();
            gv.magv = TXTMAGV.Text;
            
            
            DataTable dt = new DataTable();
            dt = GIAOVIENDAO.THONGTINMONGIAOVIEN(gv);
            int somh = dt.Rows.Count;
            int i;
            for (i = 0; i < somh; i++)
            {
                lstmonhoc.Items.Add(dt.Rows[i]["MAMH"].ToString());
                lstmonhoc.Items[i].SubItems.Add(dt.Rows[i]["TENMH"].ToString());
            }
        }

        private void btxoamon_Click(object sender, EventArgs e)
        {
            lstmonhoc.Items.Clear();
            GIAOVIENDTO gv = new GIAOVIENDTO();
            MONHOCDTO mh = new MONHOCDTO();
            gv.magv = TXTMAGV.Text;
            
                mh.mamh = demo.Text;
            
      GIAOVIENDAO.xoamon(gv, mh);
         MONCUAGV();

        }

        private void lstmonhoc_Click(object sender, EventArgs e)
        {
            demo.Text= lstmonhoc.SelectedItems[0].SubItems[0].Text;
        }

        private void lvwGIAOVIEN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttthem_Click(object sender, EventArgs e)
        {
            BTTHEM.Enabled = true;
            TXTMAGV.Enabled = true;
            gbthongtingiaovien.Enabled = true;
            gbqlmon.Enabled = false;
            bttthem.Enabled = true;
        }

        private void btqlmon_Click(object sender, EventArgs e)
        {
            gbqlmon.Enabled = true;
            gbthongtingiaovien.Enabled = false;
            MessageBox.Show("Vui Lòng Chọn Khối Và Giáo Viên Cần Quản Lý","Hướng Dẫn");
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            gbqlmon.Enabled = false;
            gbthongtingiaovien.Enabled = true;
            TXTMAGV.Enabled = false;
            BTTHEM.Enabled = false;

        }
        public void cleartt()
        {
            TXTMAGV.Text = "";
            TXTHOTEN.Text = "";
            TXTDIACHI.Text = "";
            TXTNGAYSINH.Text = "";
            TXTNGAYVAOTRUONG.Text = "";
        }

        private void BTXOAGV_Click(object sender, EventArgs e)
        {
            lvwGIAOVIEN.Items.Clear();
            GIAOVIENDTO gv = new GIAOVIENDTO();
            MONHOCDTO mh = new MONHOCDTO();
            int i;
            gv.magv = TXTMAGV.Text;
            for (i=0;i<lstmonhoc.Items.Count;i++)
            {
                mh.mamh = lstmonhoc.Items[i].Text;
                GIAOVIENDAO.xoamon(gv, mh);
            }
            
            
            GIAOVIENDAO.xoagv(gv);
            THONGTINGIAOVIEN();
            THONGTINMONHOC();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui Lòng Chọn Giáo Viên Cần Xóa", "Hướng Dẫn");
            gbthongtingiaovien.Enabled = true;
            BTTHEM.Enabled = false;
            TXTMAGV.Enabled = false;
            BTXOAGV.Enabled = true;
        }
    }
}
