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
    public partial class INSERT_STUDENT : Form
    {
        public string img_path;
        public string mahs;
        public INSERT_STUDENT()
        {
            InitializeComponent();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                LOPDTO lop = new LOPDTO();
                lop.malop = cblop.SelectedValue.ToString();
                HINHANHDTO img = new HINHANHDTO();
                HOCSINHDTO nv = new HOCSINHDTO();
                DateTime now = DateTime.Now;
                nv.mahs = lbmaso.Text;
                nv.tenhs = hoten.Text;
                nv.ngaysinh = datengaysinh.Text;

                if (rbnam.Checked == true)
                {
                    nv.gioitinh = 0;
                }
                else if (rbnu.Checked == true)
                {
                    nv.gioitinh = 1;
                }
                nv.diachi = diachi.Text;
                img.ma = nv.mahs;
                try
                {
                    img.hinh = Convert.ToBase64String(HINHANHDAO.converImgToByte(img_path));
                }
                catch { img.hinh = ""; }
                TAIKHOANDAO.TAOTAIKHOAN(nv.mahs, "1", "1", "");
                HOCSINHDAO.Them(nv, lop);
                HINHANHDAO.ISNERT_IMAGE(img);
                this.Close();
            }
            catch { MessageBox.Show("SAI"); }
        }

        private void INSERT_STUDENT_Load(object sender, EventArgs e)
        {
            lbmaso.Text = mahs;
            load();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NGU");
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
        void load()
        {
            DataTable dt = new DataTable();
            dt = LOPDAO.ttlop();
            cblop.DataSource = dt;
            cblop.DisplayMember = "MALOP";
            cblop.ValueMember = "MALOP";
        }
    }
}
