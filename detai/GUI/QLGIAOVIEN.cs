using detai.BUS;
using detai.DAO;
using detai.DTO;
using detai.GUI.CHINHSUAHOCSINH;
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
    public partial class QLGIAOVIEN : Form
    {
        public QLGIAOVIEN()
        {
            InitializeComponent();
        }

        private void QLGIAOVIEN_Load(object sender, EventArgs e)
        {
            loadgiaovien();
            khoitao();
            
        }
        public void khoitao()
        {
            try
            {

                lvwGIAOVIEN.Items[0].Selected = true;
            }
            catch
            {

            }
        }
        public void loadgiaovien()
        {
            DataTable dt = new DataTable();
            
            CHUCVUDTO cv = new CHUCVUDTO();
           dt = GIAOVIENBUS.THONGTINGIAOVIEN();
          
            int sogv = dt.Rows.Count;
            int i;
            for (i = 0; i < sogv; i++)
            {
                lvwGIAOVIEN.Items.Add((i+1).ToString());
                lvwGIAOVIEN.Items[i].SubItems.Add(dt.Rows[i]["TENGV"].ToString());
                lvwGIAOVIEN.Items[i].Tag = dt.Rows[i]["MAGV"].ToString();
                if (dt.Rows[i]["GIOITINH"].ToString() == "0")
                {
                    lvwGIAOVIEN.Items[i].SubItems.Add("Nam");
                }
                else if (dt.Rows[i]["GIOITINH"].ToString() == "1")
                {
                    lvwGIAOVIEN.Items[i].SubItems.Add("Nữ");

                }
                DataTable dtcv = new DataTable();
                
                cv.macv=dt.Rows[i]["CHUCVU"].ToString();
                dtcv = CHUCVUDAO.TENCHUCVU(cv);
                try
                {
                    lvwGIAOVIEN.Items[i].SubItems.Add(dtcv.Rows[0]["TENCHUCVU"].ToString());
                }
                catch { lvwGIAOVIEN.Items[i].SubItems.Add("null"); }
                

            }
        }

        private void lvwGIAOVIEN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwGIAOVIEN_Click(object sender, EventArgs e)
        {
            lbhoten.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[1].Text;
            lbgioitinh.Text = lvwGIAOVIEN.SelectedItems[0].SubItems[2].Text;
            DataTable dt = new DataTable();

            GIAOVIENDTO gv = new GIAOVIENDTO();
            gv.magv = lvwGIAOVIEN.SelectedItems[0].Tag.ToString();
            dt = GIAOVIENDAO.ttctgv(gv);
            lbngaysinh2.Text = (String.Format("{0:dd/MM/yyyy}", dt.Rows[0]["NGAYSINH"].ToString()));
            try
            {
                pictureBox1.Image = HINHANHDAO.Image_Object(gv.magv);
            }
            catch
            {
                pictureBox1.Image = Image.FromFile("gvcn.png");
            }
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbcapnhat_Click(object sender, EventArgs e)
        {
            GV ttgv;
            try
            {
                ttgv = new GV(lvwGIAOVIEN.SelectedItems[0].Tag.ToString());
            }
            catch
            {
                ttgv = new GV(lvwGIAOVIEN.Items[0].Tag.ToString());
            }
            
            ttgv.ShowDialog();
            lvwGIAOVIEN.Items.Clear();
            loadgiaovien();
            khoitao();
        }
        public void dem()
        {
            DataTable dt = new DataTable();
            CHUCVUDTO cv = new CHUCVUDTO();
            dt = GIAOVIENDAO.demgv();
            lbtongv.Text = dt.Rows[0][0].ToString();
            cv.macv = "GVBM";
            dt = GIAOVIENDAO.demgvchucvu(cv);
            lbtonggvbm.Text= dt.Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GIAOVIENDTO gv = new GIAOVIENDTO();
                try
                {
                    gv.magv = lvwGIAOVIEN.SelectedItems[0].Tag.ToString();
                }
                catch
                {
                    gv.magv = lvwGIAOVIEN.Items[0].Tag.ToString();
                }
                lvwGIAOVIEN.Items.Clear();
                HINHANHDAO.DELETE_IMAGE(gv.magv);
                GIAOVIENDAO.xoagv(gv);
               
                loadgiaovien();
                khoitao();
            }
            catch { MessageBox.Show("KHÔNG XÓA DC"); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string[] sonv;
            DataTable dt = new DataTable();
            dt = GIAOVIENDAO.THOGNTINGIAOVIEN();
            int lop = 1;
            int row = 0;
            string manv = "GV" + lop;
            int so = dt.Rows.Count + 1;
            sonv = new string[so];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sonv[i] = dt.Rows[i]["MAGV"].ToString();
            }

            int num = 0;
            sonv[so - 1] = "";
            while (manv == sonv[num])
            {
                num++;
                lop++;
                row++;
                manv = "GV" + lop;
            }
            GV ttgv = new GV(null);
            ttgv.mq = manv;
            ttgv.ShowDialog();
            lvwGIAOVIEN.Items.Clear();
            loadgiaovien();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mthd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void count()
        {

        }
    }
}
