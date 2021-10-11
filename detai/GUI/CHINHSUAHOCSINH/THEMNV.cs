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
    
    public partial class THEMNV : Form
    {
        public string manv;
        public string img_path;
        public THEMNV()
        {
            InitializeComponent();
        }

        private void ptthem_Click(object sender, EventArgs e)
        {
            CHUCVUDTO cv = new CHUCVUDTO();
            cv.macv = cbbchucvu.SelectedValue.ToString();
            HINHANHDTO img = new HINHANHDTO();
            NHANVIENDTO nv = new NHANVIENDTO();
            
            nv.manv = txtms.Text;
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
            img.ma = txtms.Text;
            try
            {
                img.hinh = Convert.ToBase64String(HINHANHDAO.converImgToByte(img_path));
            }
            catch { img.hinh = ""; }
            nv.diachi = diachi.Text;
            
            NHANVIENDAO.themnv(nv, cv);
            HINHANHDAO.ISNERT_IMAGE(img);
            this.Close();
        }
        public void position_person()
        {
            DataTable dt = new DataTable();
            dt = CHUCVUDAO.POSITION_SCHOOL();
            cbbchucvu.DataSource = dt;
            cbbchucvu.DisplayMember = "TENCHUCVU";
            cbbchucvu.ValueMember = "MACHUCVU";

        }

        private void THEMNV_Load(object sender, EventArgs e)
        {
            txtms.Enabled = false;
            txtms.Text = manv;
            position_person();

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
