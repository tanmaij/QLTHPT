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
    public partial class QUANLYLOP : Form
    {
        string malop;
        public QUANLYLOP()
        {
            InitializeComponent();
        }

        private void mnstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void QUANLYLOP_Load(object sender, EventArgs e)
        {
            Class();
        }
        void Class()
        {
            chonToolStripMenuItem.DropDownItems.Clear();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = KHOIDAO.KHOI();
            dt2 = LOPDAO.ttlop();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ToolStripMenuItem KHOI = new ToolStripMenuItem();
                KHOI.Text = "Khối: " + dt.Rows[i]["SOKHOI"].ToString();
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    if (dt.Rows[i]["SOKHOI"].ToString() == dt2.Rows[j]["KHOI"].ToString())
                    {
                        if (dt2.Rows[j]["MaLop"].ToString() == "Null")
                        {
                        }
                        else
                        {
                            ToolStripMenuItem LOP = new ToolStripMenuItem();
                            LOP.Text = dt2.Rows[j]["MALOP"].ToString();

                            KHOI.DropDownItems.Add(LOP);
                            LOP.Click += LOP_Click;
                        }
                    }
                }

                chonToolStripMenuItem.DropDownItems.Add(KHOI);
                count();
            }


        }

        private void LOP_Click(object sender, EventArgs e)
        {
            clear();
            //  throw new NotImplementedException();
            ToolStripMenuItem ts = sender as ToolStripMenuItem;
            LOPDTO lop = new LOPDTO();
            lop.malop = ts.Text;
            this.malop = ts.Text;
            DataTable dt = new DataTable();
            dt = HOCSINHDAO.TTHSTHEOLOP(lop);
            
            loadlist(dt);
            inclass(lop.malop);
            teacher();
        }
        void loadlist(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvwhs.Items.Add(dt.Rows[i]["MAHOCSINH"].ToString());
                lvwhs.Items[i].SubItems.Add(dt.Rows[i]["hoten"].ToString());

                if (dt.Rows[i]["GIOITINH"].ToString() == "0")
                {
                    lvwhs.Items[i].SubItems.Add("Nam");
                }
                else if (dt.Rows[i]["GIOITINH"].ToString() == "1")
                {
                    lvwhs.Items[i].SubItems.Add("Nữ");

                }
                lvwhs.Items[i].SubItems.Add(dt.Rows[i]["diachi"].ToString());
            }
        }
        void teacher()
        {
            try
            {
                DataTable dt = new DataTable();
                LOPDTO lop = new LOPDTO();
                lop.malop = malop;
                dt = LOPDAO.GVCN(lop);
                try
                {
                    pictureBox1.Image = HINHANHDAO.Image_Object(dt.Rows[0][0].ToString());
                }
                catch
                {
                    pictureBox1.Image = pictureBox1.Image;
                }
                gvhoten.Text = dt.Rows[0][1].ToString();
                if (dt.Rows[0][2].ToString() == "1")
                    gvgioitinh.Text = "Nữ";
                else gvgioitinh.Text = "Nam";
                dateTimePicker1.Text = dt.Rows[0][3].ToString();
            }
            catch
            {

            }



        }
        void student()
        {
            DataTable dt = new DataTable();
            HOCSINHDTO hs = new HOCSINHDTO();
            hs.mahs = lvwhs.SelectedItems[0].Text;
            dt = HOCSINHDAO.TTHScuthe(hs);
            try
            {
                pictureBox4.Image = HINHANHDAO.Image_Object(hs.mahs);
            }
            catch
            {
                pictureBox4.Image = pictureBox4.Image;
            }
            hotenhs.Text = dt.Rows[0]["Hoten"].ToString();
            if (dt.Rows[0]["gioitinh"].ToString() == "1")
                gioitinhhs.Text = "Nữ";
            else gioitinhhs.Text = "Nam";
            dateTimePicker2.Text = dt.Rows[0]["NGAYSINH"].ToString();
        }

        private void lvwhs_Click(object sender, EventArgs e)
        {

            student();
        }
        void clear()
        {
            lvwhs.Items.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            LOPDTO lop = new LOPDTO();
            lop.malop = "Null";
            dt = HOCSINHDAO.TTHSTHEOLOP(lop);
            if (dt.Rows.Count == 0)
                MessageBox.Show("KHÔNG CÓ HỌC SINH NÀO CHƯA VÀO LỚP !");
            else
            {
                DANHSACH.DSHS ds = new DANHSACH.DSHS();
                ds.malop = this.malop;
                ds.ShowDialog();
                reload();
            }

        }

        private void chưaVàoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            DataTable dt = new DataTable();
            LOPDTO lop = new LOPDTO();
            lop.malop = "Null";
            dt = HOCSINHDAO.TTHSTHEOLOP(lop);
            loadlist(dt);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "update HOCSINH set Malop=N'Null' where MAHOCSINH='" + lvwhs.SelectedItems[0].SubItems[0].Text + "'";
            KETNOICSDL.ExcuteNonQuery(sql);
            reload();
        }
        void reload()
        {
            lvwhs.Items.Clear();
            LOPDTO lop = new LOPDTO();
            lop.malop = malop;
            DataTable dt2 = new DataTable();
            dt2 = HOCSINHDAO.TTHSTHEOLOP(lop);
            loadlist(dt2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOPDTO lop = new LOPDTO();
            lop.malop = malop;
            DataTable dt2 = new DataTable();
            dt2 = HOCSINHDAO.TTHSTHEOLOP(lop);
            string sql2 = "delete from GVCN where malop='" + lop.malop + "'";
            KETNOICSDL.ExcuteNonQuery(sql2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                string sql = "update HOCSINH set Malop=N'Null' where MAHOCSINH='" + dt2.Rows[i]["MAHOCSINH"].ToString() + "'";
                KETNOICSDL.ExcuteNonQuery(sql);
            }
            LOPDAO.xoalop(lop);
            count();
            Class();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DANHSACH.THEMLOP frm = new DANHSACH.THEMLOP();
            frm.ShowDialog();
            Class();
        }
        void count()
        {
            DataTable dt = new DataTable();
            dt = LOPDAO.ttlop();
            tonglop.Text = dt.Rows.Count.ToString();
            dt = LOPDAO.ttlopKHOI("10");
            tong10.Text = dt.Rows.Count.ToString();
            dt = LOPDAO.ttlopKHOI("11");
            tong11.Text = dt.Rows.Count.ToString();
            dt = LOPDAO.ttlopKHOI("12");
            tong12.Text = dt.Rows.Count.ToString();
        }
        void inclass(string malop)
        {
            phong.Text = malop;
            LOPDTO lop = new LOPDTO();
            DataTable dt = new DataTable();
            lop.malop = malop;
            dt = LOPDAO.ttloptheokhoi(lop);
            khoi.Text = dt.Rows[0]["KHOI"].ToString();
            tong.Text = (lvwhs.Items.Count).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DANHSACH.DANHSACHGIAOVIEN gv = new DANHSACH.DANHSACHGIAOVIEN();
            gv.malop = malop;
            gv.ShowDialog();
            teacher();
        }
    }
}
