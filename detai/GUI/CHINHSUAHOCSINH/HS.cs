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

namespace detai.GUI.CHINHSUAHOCSINH
{
    public partial class HS : Form
    {
        public string mahs;
        public string img_path;
        public HS(string v)
        {
            InitializeComponent();
            lbmaso.Text = v;
        }

        
        private void HS_Load(object sender, EventArgs e)
        {
            load();
            hienlop();
            hienthongtin();
        }
        public void hienthongtin()
        {
            HOCSINHDTO hs = new HOCSINHDTO();
            hs.mahs = lbmaso.Text;
            DataTable dt = new DataTable();
            dt = HOCSINHDAO.TTHScuthe(hs);
            hoten.Text = dt.Rows[0]["HOTEN"].ToString();
            if (dt.Rows[0]["GIOITINH"].ToString() == "0")
                rbnam.Checked = true;
            else if (dt.Rows[0]["GIOITINH"].ToString() == "1")
                rbnu.Checked = true;
            datengaysinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
            diachi.Text= dt.Rows[0]["DIACHI"].ToString();
            cblop.Text= dt.Rows[0]["MALOP"].ToString();
            try
            {
                pictureBox2.Image = HINHANHDAO.Image_Object(mahs);
            }
            catch
            {
                pictureBox2.Image = Image.FromFile("hinh/hs/001.jpg");
            }
        }
        public void hienlop()
        {
            DataTable dt = new DataTable();
            dt =LOPDAO.ttlop();
            cblop.DataSource = dt;
            cblop.DisplayMember = "MALOP";
            cblop.ValueMember = "MALOP";
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                HINHANHDTO img = new HINHANHDTO();
                HOCSINHDTO hs = new HOCSINHDTO();
                LOPDTO lop = new LOPDTO();
                hs.mahs = lbmaso.Text;
                hs.tenhs = hoten.Text;
                hs.ngaysinh = (String.Format("{0:MM/dd/yyyy}", datengaysinh.Value));
                hs.diachi = diachi.Text;
                if (rbnam.Checked == true)
                    hs.gioitinh = 0;
                else hs.gioitinh = 1;
                lop.malop = cblop.SelectedValue.ToString();
                HOCSINHBUS.capnhat(hs, lop);
                img.ma = hs.mahs;
                try
                {
                    img.hinh = Convert.ToBase64String(HINHANHDAO.converImgToByte(img_path));

                    HINHANHDAO.UPDATE_IMAGE(img);
                }
                catch { }
                this.Close();
            }
            catch { }
            
        }
        void load()
        {
            DataTable dt = new DataTable();
            dt = LOPDAO.ttlop();
            cblop.DataSource = dt;
            cblop.DisplayMember = "MALOP";
            cblop.ValueMember = "MALOP";
        }
        private void HS_Leave(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                HOCSINHDTO hs = new HOCSINHDTO();
                hs.mahs = lbmaso.Text;
                string sql = "delete from HOCSINH where MAHOCSINH='" + hs.mahs + "'";
                TAIKHOANDAO.DELETE(hs.mahs);
                HINHANHDAO.DELETE_IMAGE(hs.mahs);

                KETNOICSDL.ExcuteNonQuery(sql);
                this.Close();
            }
            catch { MessageBox.Show("SAI"); }
        }
    }
}
