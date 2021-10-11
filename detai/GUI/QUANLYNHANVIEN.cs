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
    public partial class QUANLYNHANVIEN : Form
    {
        public QUANLYNHANVIEN()
        {
            InitializeComponent();
        }

        private void QUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
            loadnhanvien();
            loadtreeview(tv1);
        }
        public void loadtreeview( TreeView tv)
        {
            DataTable dtcv = new DataTable();
            dtcv = CHUCVUDAO.POSITION_SCHOOL();
            DataTable dtnv = new DataTable();
            dtnv = NHANVIENDAO.THOGNTINNHANVIEN();
            TreeNode chucvunode = new TreeNode();
            int sochucvu = dtcv.Rows.Count;
            int sonv = dtnv.Rows.Count;
            for (int i=0; i<sochucvu; i++)
            {
                if ((dtcv.Rows[i]["machucvu"].ToString()) != "HT" && (dtcv.Rows[i]["machucvu"].ToString()) != "PHT" && (dtcv.Rows[i]["machucvu"].ToString()) != "GVBM")
                {
                    chucvunode = tv.Nodes.Add(dtcv.Rows[i]["tenchucvu"].ToString());
                    chucvunode.Tag = (dtcv.Rows[i]["machucvu"].ToString());
                    for (int j = 0; j < sonv; j++)
                    {
                        if (dtcv.Rows[i]["machucvu"].ToString() == dtnv.Rows[j]["MACHUCVU"].ToString())
                        {
                            TreeNode nvnode = new TreeNode();
                            nvnode = chucvunode.Nodes.Add(dtnv.Rows[j]["tennv"].ToString());
                            nvnode.Tag = dtnv.Rows[j]["manv"].ToString();

                        }
                    }
                }
                
                
            }
        }
        public void loadnhanvien()
        {
            DataTable dt = new DataTable();

            CHUCVUDTO cv = new CHUCVUDTO();
            dt = NHANVIENBUS.THONGTINNHANVIEN();

            int sogv = dt.Rows.Count;
            int i;
            for (i = 0; i < sogv; i++)
            {
                listView2.Items.Add((i + 1).ToString());
                listView2.Items[i].SubItems.Add(dt.Rows[i]["TENNV"].ToString());
                listView2.Items[i].Tag = dt.Rows[i]["MANV"].ToString();
                if (dt.Rows[i]["GIOITINH"].ToString() == "0")
                {
                    listView2.Items[i].SubItems.Add("Nam");
                }
                else if (dt.Rows[i]["GIOITINH"].ToString() == "1")
                {
                    listView2.Items[i].SubItems.Add("Nữ");

                }
                DataTable dtcv = new DataTable();

                cv.macv = dt.Rows[i]["MACHUCVU"].ToString();
                dtcv = CHUCVUDAO.TENCHUCVU(cv);
                listView2.Items[i].SubItems.Add(dtcv.Rows[0]["TENCHUCVU"].ToString());


            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            NHANVIENDTO nv = new NHANVIENDTO();
            try
            {
                nv.manv = listView2.SelectedItems[0].Tag.ToString();
            }
            catch
            {
                nv.manv = listView2.Items[0].Tag.ToString();
            }
            listView2.Items.Clear();
            HINHANHDAO.DELETE_IMAGE(nv.manv);
            NHANVIENBUS.xoanv(nv);
            tv1.Nodes.Clear();
            loadtreeview(tv1);
            loadnhanvien();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string[] sonv;
            DataTable dt = new DataTable();
            dt = NHANVIENDAO.THOGNTINNHANVIEN();
            int lop = 1;
            int row = 0;
            string manv = "NV" + lop;
            int so = dt.Rows.Count + 1;
            sonv = new string[so];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sonv[i] = dt.Rows[i]["MANV"].ToString();
            }

            int num = 0;
            sonv[so - 1] = "";
            while (manv == sonv[num])
            {
                num++;
                lop++;
                row++;
                manv = "HS" + lop;
            }
            //CHINHSUAHOCSINH.NV ttnv = new CHINHSUAHOCSINH.NV();
            CHINHSUAHOCSINH.THEMNV ttnv = new CHINHSUAHOCSINH.THEMNV();
            ttnv.manv = manv;
            ttnv.ShowDialog();
            listView2.Items.Clear();
            loadnhanvien();
            tv1.Nodes.Clear();
            loadtreeview(tv1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHINHSUAHOCSINH.NV ttnv = new CHINHSUAHOCSINH.NV();
            ttnv.manv = listView2.SelectedItems[0].Tag.ToString();
            ttnv.ShowDialog();
            listView2.Items.Clear();
            loadnhanvien();
            tv1.Nodes.Clear();
            loadtreeview(tv1);
        }
        
        private void listView2_Click(object sender, EventArgs e)
        {
            lbhoten.Text = listView2.SelectedItems[0].SubItems[1].Text;
            lbgt.Text = listView2.SelectedItems[0].SubItems[2].Text;
            DataTable dt = new DataTable();

            NHANVIENDTO nv = new NHANVIENDTO();
            nv.manv = listView2.SelectedItems[0].Tag.ToString();
            dt = NHANVIENDAO.ttctnv(nv);
            lbngsinh.Text = (String.Format("{0:dd/MM/yyyy}", dt.Rows[0]["NGAYSINH"].ToString()));

        }
    }
}
