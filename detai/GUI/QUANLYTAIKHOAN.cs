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
    public partial class QUANLYTAIKHOAN : Form
    {
        public QUANLYTAIKHOAN()
        {
            InitializeComponent();
        }

        private void QUANLYTAIKHOAN_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            createheader();
            CreateOb_teacher();
            CreateOb_Student();
            CreateOb_System();
        }
        void CreateOb_teacher()
        {
            DataTable acc = new DataTable();
            acc = TAIKHOANDAO.KTRATAIKHOAN("2");
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            GIAOVIENDTO gv = new GIAOVIENDTO();
            dt2 = GIAOVIENDAO.THOGNTINGIAOVIEN();
            if (acc.Rows.Count == 0)
            { }
            else
            {
                for (int i = 0; i < acc.Rows.Count; i++)
                {
                    
                    FlowLayoutPanel Ob = new FlowLayoutPanel()
                    { Width = 640, Height = 50, ForeColor = Color.Black };
                    Ob.Name = acc.Rows[i]["TENDANGNHAP"].ToString();
                    Ob.Tag = acc.Rows[i]["MatKhau"].ToString();
                    Panel ID = new Panel()
                    { Width = 180, Height = Ob.Height, BackColor = Color.LightGreen };
                    Panel Name = new Panel() { Width = 180, Height = Ob.Height, BackColor = Color.LightPink };
                    Panel Password = new Panel() { Width = 170, Height = Ob.Height, BackColor = Color.LightSeaGreen };
                    Ob.Controls.Add(ID);
                    Ob.Controls.Add(Name);
                    Ob.Controls.Add(Password);
                    gv.magv = acc.Rows[i]["TENDANGNHAP"].ToString();
                    dt = GIAOVIENDAO.ttctgv(gv);
                    Label lbid = new Label() { Text = acc.Rows[i]["TENDANGNHAP"].ToString() };
                    Label lbname = new Label() { Text = dt.Rows[0]["TENGV"].ToString() };
                    Label lbpass = new Label() { Text = acc.Rows[i]["MATKHAU"].ToString() };
                    ID.Controls.Add(lbid);
                    Name.Controls.Add(lbname);
                    Password.Controls.Add(lbpass);
                    Button edit = new Button() { Text = "Edit", Height = 50, Width = 50, BackColor = Color.White, ForeColor = Color.Black };
                    edit.Name = acc.Rows[i]["TENDANGNHAP"].ToString();
                    edit.Tag = acc.Rows[i]["MatKhau"].ToString();
                    Ob.Controls.Add(edit);
                    edit.Click += Edit_Click1;
                    // flowLayoutPanel1.Controls.Add(Button);
                    flowLayoutPanel1.Controls.Add(Ob);
                    Ob.Click += Ob_Click;
                }
            }
            
        }

        private void Edit_Click1(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            Button btn = sender as Button;
            button2.Enabled = true;
            button3.Enabled = false;
            TXTTENDANGNHAP.Enabled = false;
            TXTTENDANGNHAP.Text = btn.Name;
            TXTMATKHAU.Text = btn.Tag.ToString();
        }

        private void Ob_Click(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            FlowLayoutPanel pnl = (FlowLayoutPanel)sender;
            TXTTENDANGNHAP.Text = pnl.Name;
            TXTMATKHAU.Text = pnl.Tag.ToString();
        }

        void CreateOb_Student()
        {
            
            DataTable acc = new DataTable();
            acc = TAIKHOANDAO.KTRATAIKHOAN("1");
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            HOCSINHDTO hs = new HOCSINHDTO();
            dt2 = HOCSINHDAO.TTHS();
            if (dt2.Rows.Count == 0)
            { }
            else
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {

                    FlowLayoutPanel Ob = new FlowLayoutPanel()
                    { Width = 640, Height = 50, ForeColor = Color.Black };
                    Ob.Name = acc.Rows[i]["TENDANGNHAP"].ToString();
                    Ob.Tag = acc.Rows[i]["MATKHAU"].ToString();
                    Panel ID = new Panel()
                    { Width = 180, Height = Ob.Height, BackColor = Color.LightGreen };
                    Panel Name = new Panel() { Width = 180, Height = Ob.Height, BackColor = Color.LightPink };
                    Panel Password = new Panel() { Width = 170, Height = Ob.Height, BackColor = Color.LightSeaGreen };
                    Ob.Controls.Add(ID);
                    Ob.Controls.Add(Name);
                    Ob.Controls.Add(Password);
                    hs.mahs = acc.Rows[i]["TENDANGNHAP"].ToString();
                    dt = HOCSINHDAO.TTHScuthe(hs);
                    Label lbid = new Label() { Text = acc.Rows[i]["TENDANGNHAP"].ToString() };
                   // Label lbname = new Label() { Text = dt.Rows[0]["HOTEN"].ToString() };
                    Label lbpass = new Label() { Text = acc.Rows[i]["MATKHAU"].ToString() };
                    Button edit = new Button() { Text="Edit", Height=50,Width=50, BackColor=Color.White,ForeColor=Color.Black };
                    edit.Name = acc.Rows[i]["TENDANGNHAP"].ToString();
                    edit.Tag = acc.Rows[i]["MatKhau"].ToString();
                    edit.Click += Edit_Click;
                    Ob.Controls.Add(edit);
                    ID.Controls.Add(lbid);
                  //  Name.Controls.Add(lbname);
                    Password.Controls.Add(lbpass);
                    
                    flowLayoutPanel2.Controls.Add(Ob);
                    Ob.Click += Ob_Click1;
                }
            }
        }
        void CreateOb_System()
        {

            DataTable acc = new DataTable();
            acc = TAIKHOANDAO.KTRATAIKHOAN("3");
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            HOCSINHDTO hs = new HOCSINHDTO();
           // dt2 = TAIKHOANDAO.TTHS();
            if (acc.Rows.Count == 0)
            { }
            else
            {
                for (int i = 0; i < acc.Rows.Count; i++)
                {

                    FlowLayoutPanel Ob = new FlowLayoutPanel()
                    { Width = 640, Height = 50, ForeColor = Color.Black };
                    Ob.Name = acc.Rows[i]["TENDANGNHAP"].ToString();
                    Ob.Tag = acc.Rows[i]["MATKHAU"].ToString();
                    Panel ID = new Panel()
                    { Width = 180, Height = Ob.Height, BackColor = Color.LightGreen };
                    Panel Name = new Panel() { Width = 180, Height = Ob.Height, BackColor = Color.LightPink };
                    Panel Password = new Panel() { Width = 170, Height = Ob.Height, BackColor = Color.LightSeaGreen };
                    Ob.Controls.Add(ID);
                    Ob.Controls.Add(Name);
                    Ob.Controls.Add(Password);
                    hs.mahs = acc.Rows[i]["TENDANGNHAP"].ToString();
                    dt = HOCSINHDAO.TTHScuthe(hs);
                    Label lbid = new Label() { Text = acc.Rows[i]["TENDANGNHAP"].ToString() };
                    
                    Label lbpass = new Label() { Text = acc.Rows[i]["MATKHAU"].ToString() };
                    Button edit = new Button() { Text = "Edit", Height = 50, Width = 50, BackColor = Color.White, ForeColor = Color.Black };
                    edit.Name = acc.Rows[i]["TENDANGNHAP"].ToString();
                    edit.Tag = acc.Rows[i]["MatKhau"].ToString();
                    edit.Click += Edit_Click;
                    Ob.Controls.Add(edit);
                    ID.Controls.Add(lbid);
                   
                    Password.Controls.Add(lbpass);

                    flowLayoutPanel4.Controls.Add(Ob);
                    Ob.Click += Ob_Click1;
                }
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            Button btn = sender as Button;
            button3.Enabled = false;
            button2.Enabled = true;
            TXTTENDANGNHAP.Enabled = false;
            TXTTENDANGNHAP.Text = btn.Name;
            TXTMATKHAU.Text = btn.Tag.ToString();
        }

        private void Ob_Click1(object sender, EventArgs e)
        {
            FlowLayoutPanel pnl =(FlowLayoutPanel)sender;
            
            TXTTENDANGNHAP.Text = pnl.Name;
            TXTMATKHAU.Text = pnl.Tag.ToString();
        }
    

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        FlowLayoutPanel header()
        {
            Color a = Color.DarkBlue;
            FlowLayoutPanel Ob = new FlowLayoutPanel()
            { Width = 640, Height = 50, ForeColor = Color.White };
            
            Panel ID = new Panel()
            { Width = 180, Height = Ob.Height, BackColor =a };
            Panel Name = new Panel() { Width = 180, Height = Ob.Height, BackColor = a};
            Panel Password = new Panel() { Width = 170, Height = Ob.Height, BackColor = a };
            Ob.Controls.Add(ID);
            Ob.Controls.Add(Name);
            Ob.Controls.Add(Password);
            
            Label lbid = new Label() { Text = "Tên Đăng Nhập", Width=this.Width+20 };
            Label lbname = new Label() { Text = "Họ Và Tên" };
            Label lbpass = new Label() { Text = "Mật Khẩu" };
            ID.Controls.Add(lbid);
            Name.Controls.Add(lbname);
            Password.Controls.Add(lbpass);
            return Ob;
            
        }
        void createheader()
        {
            pnlheader.Controls.Add(header());
            pnlheader2.Controls.Add(header());
            pnlheader3.Controls.Add(header());
        }

        private void ptrlogin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TAIKHOANDAO.up(TXTTENDANGNHAP.Text, TXTMATKHAU.Text);
                MessageBox.Show("Thành Công");
                clear(flowLayoutPanel1, flowLayoutPanel4, flowLayoutPanel4);
                CreateOb_teacher();
                CreateOb_Student();
                CreateOb_System();

            }
            catch
            {
                MessageBox.Show("Không thể đổi mật khẩu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTTENDANGNHAP.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TAIKHOANDAO.TAOTAIKHOAN(TXTTENDANGNHAP.Text, TXTMATKHAU.Text, "3", "");
                clear(flowLayoutPanel1, flowLayoutPanel4, flowLayoutPanel4);
                CreateOb_teacher();
                CreateOb_Student();
                CreateOb_System();
            }
            catch
            {
                MessageBox.Show("Không Thể Thêm");
            }
        }
        void clear(FlowLayoutPanel a,FlowLayoutPanel b,FlowLayoutPanel c)
        {
            a.Controls.Clear();
            b.Controls.Clear();
            c.Controls.Clear();
        }

    }
}
