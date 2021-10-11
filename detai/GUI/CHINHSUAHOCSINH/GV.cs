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
using System.IO;

namespace detai.GUI.CHINHSUAHOCSINH
{
    public partial class GV : Form
    {
        public string mq;
        string ma;
        string img_path;
        public GV(string magv)
        {
            ma = magv;
            InitializeComponent();
        
        }

        private void GV_Load(object sender, EventArgs e)
        {
            position_person();
            if (ma != null)
                hienthongtin();
            else { btncapnhat.Text = "Thêm Giáo Viên"; btncapnhat.Tag =1;
                TextBox txtmaso = new TextBox() { Location = new Point(lbmaso.Location.X, lbmaso.Location.Y), Text = mq,Enabled=false };
                ma = txtmaso.Text;
                txtmaso.TextChanged += Txtmaso_TextChanged;
                panel12.Controls.Add(txtmaso);
                lbmaso.Visible=false;
            }
        }

        private void Txtmaso_TextChanged(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            TextBox txt = sender as TextBox;
            ma = txt.Text;
        }

        public void hienthongtin()
        {
            if (Convert.ToInt32( btncapnhat.Tag )!= 1)
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
                 //   btncapnhat.Image= Image.FromFile("gvcn.png");
                }
            }
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            
                CHUCVUDTO cv = new CHUCVUDTO();
                cv.macv = cbbchucvu.SelectedValue.ToString();
                HINHANHDTO img = new HINHANHDTO();
                GIAOVIENDTO gv = new GIAOVIENDTO();
                DateTime now = DateTime.Now;
                gv.magv = lbmaso.Text;
                gv.tengv = hoten.Text;
                gv.ngaysinh = datengaysinh.Text;

                if (rbnam.Checked == true)
                {
                    gv.gioitinh = 0;
                }
                else if (rbnu.Checked == true)
                {
                    gv.gioitinh = 1;
                }
                gv.diachi = diachi.Text;
                gv.ngayvaotruong = dateTimePicker1.Text;
                if (Convert.ToInt32(btncapnhat.Tag) != 1)
                {
                try
                {
                    img.hinh = Convert.ToBase64String(HINHANHDAO.converImgToByte(img_path));
                }
                catch { }
                    img.ma = ma;
                    gv.magv = ma;
                try
                {
                    HINHANHDAO.UPDATE_IMAGE(img);
                }
                catch { }
                    GIAOVIENDAO.capnhat(gv, cv);
                    this.Close();
                }
                else
                {
                try
                {
                    img.hinh = Convert.ToBase64String(HINHANHDAO.converImgToByte(img_path));
                }catch { img.hinh = ""; }
                    img.ma = ma;
                    gv.magv = ma;
                    HINHANHDAO.ISNERT_IMAGE(img);
                    GIAOVIENDAO.themgv(gv, cv);
                if (cbbchucvu.SelectedValue.ToString()=="GVBM")
                    TAIKHOANDAO.TAOTAIKHOAN(gv.magv, "1", "2", "");
                else TAIKHOANDAO.TAOTAIKHOAN(gv.magv, "1", "3", "");
                this.Close();
                }
           
          
        }

        private void hoten_TextChanged(object sender, EventArgs e)
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
        public void position_person()
        {
            DataTable dt = new DataTable();
            dt = CHUCVUDAO.POSITION_SCHOOL();
            
            cbbchucvu.DataSource = dt;
            cbbchucvu.DisplayMember = "TENCHUCVU";
            cbbchucvu.ValueMember = "MACHUCVU";
            
        }
    }
}
