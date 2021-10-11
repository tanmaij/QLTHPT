using detai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using detai.GUI.CHINHSUAHOCSINH;
using detai.DTO;

namespace detai.GUI
{
    public partial class QUANLYHOCSINH : Form
    {
        Button[] btn;
        Label[] maso;
        public QUANLYHOCSINH()
        {
            InitializeComponent();

        }

        private void QUANLYHOCSINH_Load(object sender, EventArgs e)
        {
            chonlop();
            loadhs();
        }

        private void QUANLYHOCSINH_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            HS tths = new HS(btn.Tag.ToString());
            tths.mahs = btn.Tag.ToString();
            tths.Location = new Point(btn.Location.X, btn.Location.Y);
            tths.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
            loadhs();

        }
        public void loadhs()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = new DataTable();
            dt = HOCSINHDAO.TTHS();
            int slhs = dt.Rows.Count;
            btn = new Button[slhs];
            maso = new Label[slhs];
            for (int i = 0; i < slhs; i++)
            {
                maso[i] = new Label();
                maso[i].Text = dt.Rows[i]["MAHOCSINH"].ToString();
                maso[i].Location = new Point(250, 120);
                maso[i].Font = new Font("Arial", 12, FontStyle.Bold);
                maso[i].Width = 82;
                maso[i].Height = 25;

                Panel pnl = new Panel();
                pnl.BackColor = Color.White;
                pnl.Width = 400;
                pnl.Height = 300;
                PictureBox ptr = new PictureBox();
                ptr.Height = 152;
                ptr.Width = 150;

                ptr.Location = new Point(20, 39);
                try
                {
                    ptr.Image = HINHANHDAO.Image_Object(maso[i].Text);

                }
                catch
                {
                    ptr.Image = Image.FromFile("hinh/hs/001.jpg");
                }
                Label lbten = new Label();
                lbten.Text = dt.Rows[i]["HOTEN"].ToString();
                lbten.Location = new Point(180, 42);
                lbten.Font = new Font("Arial", 20, FontStyle.Bold);
                lbten.Width = 250;
                lbten.Height = 39;
                Label lbm = new Label() { Text = "Mã Số: " };
                lbm.Location = new Point(180, 120);
                lbm.Font = new Font("Arial", 12, FontStyle.Bold);
                lbm.Width = 70;
                lbm.Height = 25;


                Label lblop = new Label() { Text = "Lớp:" };
                lblop.Location = new Point(180, 188);
                lblop.Font = new Font("Arial", 12, FontStyle.Bold);
                lblop.Width = 82;
                lblop.Height = 25;
                Label lbmalop = new Label() { Text = dt.Rows[i]["MALOP"].ToString() };
                lbmalop.Location = new Point(270, 188);
                lbmalop.Font = new Font("Arial", 12, FontStyle.Bold);
                lbmalop.Width = 82;
                lbmalop.Height = 25;

                btn[i] = new Button() { Text = "Chỉnh Sửa", Location = new Point(170, 235), BackColor = Color.White };
                btn[i].Width = 100;
                btn[i].Height = 50;
                btn[i].Tag = maso[i].Text;
                btn[i].Font = new Font("Arial", 9, FontStyle.Bold);
                btn[i].Click += QUANLYHOCSINH_Click;
                pnl.Controls.Add(btn[i]);
                pnl.Controls.Add(ptr);
                pnl.Controls.Add(lbten);
                pnl.Controls.Add(lbm);
                pnl.Controls.Add(maso[i]);
                pnl.Controls.Add(lblop);
                pnl.Controls.Add(lbmalop);
                if (i % 2 != 0)
                {
                    pnl.BackColor = Color.LightCyan;
                }
                else pnl.BackColor = Color.LavenderBlush;
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }


        public void chonlop()
        {
            DataTable dt = new DataTable();
            dt = LOPDAO.ttlop();
            cblop.DataSource = dt;
            cblop.DisplayMember = "MALOP";
            cblop.ValueMember = "MALOP";

        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectwheremalop(cblop.SelectedValue.ToString());

        }
        public void selectwheremalop(string malop)
        {
            flowLayoutPanel1.Controls.Clear();
            LOPDTO lop = new LOPDTO();
            lop.malop = malop;
            DataTable dt = new DataTable();
            dt = HOCSINHDAO.TTHSTHEOLOP(lop);
            int slhs = dt.Rows.Count;
            btn = new Button[slhs];
            maso = new Label[slhs];
            for (int i = 0; i < slhs; i++)
            {
                maso[i] = new Label();
                maso[i].Text = dt.Rows[i]["MAHOCSINH"].ToString();
                maso[i].Location = new Point(250, 120);
                maso[i].Font = new Font("Arial", 12, FontStyle.Bold);
                maso[i].Width = 60;
                maso[i].Height = 25;

                Panel pnl = new Panel();
                pnl.BackColor = Color.White;
                pnl.Width = 400;
                pnl.Height = 300;
                PictureBox ptr = new PictureBox();
                ptr.Height = 152;
                ptr.Width = 150;
                ptr.Location = new Point(20, 39);
                ptr.Image = Image.FromFile("hinh/hs/" + maso[i].Text + ".jpg");
                Label lbten = new Label();
                lbten.Text = dt.Rows[i]["HOTEN"].ToString();
                lbten.Location = new Point(180, 42);
                lbten.Font = new Font("Arial", 20, FontStyle.Bold);
                lbten.Width = 281;
                lbten.Height = 39;
                Label lbm = new Label() { Text = "Mã Số: " };
                lbm.Location = new Point(180, 120);
                lbm.Font = new Font("Arial", 12, FontStyle.Bold);
                lbm.Width = 70;
                lbm.Height = 25;


                Label lblop = new Label() { Text = "Lớp" };
                lblop.Location = new Point(180, 188);
                lblop.Font = new Font("Arial", 12, FontStyle.Bold);
                lblop.Width = 50;
                lblop.Height = 25;
                Label lbmalop = new Label() { Text = dt.Rows[i]["MALOP"].ToString() };
                lbmalop.Location = new Point(270, 188);
                lbmalop.Font = new Font("Arial", 12, FontStyle.Bold);
                lbmalop.Width = 82;
                lbmalop.Height = 25;

                btn[i] = new Button() { Text = "Chỉnh Sửa", Location = new Point(170, 235), BackColor = Color.White };
                btn[i].Width = 100;
                btn[i].Height = 50;
                btn[i].Font = new Font("Arial", 9, FontStyle.Bold);
                btn[i].Tag = maso[i].Text;
                btn[i].Click += QUANLYHOCSINH_Click;
                pnl.Controls.Add(btn[i]);
                pnl.Controls.Add(ptr);
                pnl.Controls.Add(lbten);
                pnl.Controls.Add(lbm);
                pnl.Controls.Add(maso[i]);
                pnl.Controls.Add(lblop);
                pnl.Controls.Add(lbmalop);
                if (i % 2 != 0)
                {
                    pnl.BackColor = Color.LightCyan;
                }
                else pnl.BackColor = Color.LavenderBlush;
                flowLayoutPanel1.Controls.Add(pnl);
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CHINHSUAHOCSINH.INSERT_STUDENT them = new INSERT_STUDENT();
            them.ShowDialog();
            loadhs();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string[] sohs;
            DataTable dt = new DataTable();
            dt = HOCSINHDAO.TTHS();
            int lop = 1;
            int row = 0;
            string mahs = "HS" + lop;
            int so = dt.Rows.Count + 1;
            sohs = new string[so];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sohs[i] = dt.Rows[i]["MAHOCSINH"].ToString();
            }

            int num = 0;
            sohs[so - 1] = "";
            while (mahs == sohs[num])
            {
                num++;
                lop++;
                row++;
                mahs = "HS" + lop;
            }

            
            CHINHSUAHOCSINH.INSERT_STUDENT them = new INSERT_STUDENT();
            them.mahs = mahs;
            them.ShowDialog();
            loadhs();
        }
    }
}
