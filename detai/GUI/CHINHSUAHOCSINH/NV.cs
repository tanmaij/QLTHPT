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

namespace detai.GUI.CHINHSUAHOCSINH
{
    public partial class NV : Form
    {
        public string img_path;
        public string manv;
        public NV()
        {
            
            InitializeComponent();
        }

        private void NV_Load(object sender, EventArgs e)
        {
            position_person();
            if (manv != null)
                hienthongtin();
            
        }
        public  void hienthongtin()
        {
            NHANVIENDTO nv = new NHANVIENDTO();
            nv.manv = manv;
            DataTable dt = new DataTable();
            dt = NHANVIENDAO.ttctnv(nv);
            lbmaso.Text = manv;
            hoten.Text = dt.Rows[0]["TENNV"].ToString();
            if (dt.Rows[0]["GIOITINH"].ToString() == "0")
                rbnam.Checked = true;
            else if (dt.Rows[0]["GIOITINH"].ToString() == "1")
                rbnu.Checked = true;
            datengaysinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
            diachi.Text = dt.Rows[0]["DIACHI"].ToString();
           // dateTimePicker1.Text = dt.Rows[0]["NGAYVAOTRUONG"].ToString();
        }
        public void position_person()
        {
            DataTable dt = new DataTable();
            dt = CHUCVUDAO.POSITION_SCHOOL();
            cbbchucvu.DataSource = dt;
            cbbchucvu.DisplayMember = "TENCHUCVU";
            cbbchucvu.ValueMember = "MACHUCVU";

        }
        public void loadform()

        {
            lbmaso.Text = manv;
            NHANVIENDTO nv = new NHANVIENDTO();
            nv.manv = this.manv;
            DataTable dt = new DataTable();
            dt = NHANVIENDAO.ttctnv(nv);
            lbhoten.Text = dt.Rows[0]["TENNV"].ToString();

        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            CHUCVUDTO cv = new CHUCVUDTO();
            cv.macv = cbbchucvu.SelectedValue.ToString();
            HINHANHDTO img = new HINHANHDTO();
            NHANVIENDTO nv = new NHANVIENDTO();
            DateTime now = DateTime.Now;
            nv.manv = lbmaso.Text;
            nv.tennv = hoten.Text;
            nv.ngaysinh = datengaysinh.Text;

            if (rbnam.Checked == true)
            {
                nv.gioitinh = "0";
            }
            else if (rbnu.Checked == true)
            {
                nv.gioitinh = "1";
            }
            nv.diachi = diachi.Text;
            img.ma = lbmaso.Text;
            try
            {
                img.hinh = Convert.ToBase64String(HINHANHDAO.converImgToByte(img_path));
            }
            catch { }
            nv.diachi = diachi.Text;
            HINHANHDAO.UPDATE_IMAGE(img);
            NHANVIENDAO.capnhatnv(nv, cv);
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                img_path = openFile.FileName;
                Image img = Image.FromFile(openFile.FileName);
                pictureBox2.Image = img;
            }
        }
    }
}
