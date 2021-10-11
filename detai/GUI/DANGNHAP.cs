using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using detai.DAO;

namespace detai.GUI
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ptrlogin_Click(object sender, EventArgs e)
        {

        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            ptrlogin.Image = Image.FromFile("signin.jpg");
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = TAIKHOANDAO.CHECK();
            bool kiemtra=false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                label5.Text = dt.Rows[i]["TENDANGNHAP"].ToString();
                label6.Text = dt.Rows[i]["MATKHAU"].ToString();
                if (TXTTENDANGNHAP.Text == label5.Text && TXTMATKHAU.Text == label6.Text)
                {

                    if (dt.Rows[i]["LOAITK"].ToString() == "1")
                    {

                        hocsinh hs = new hocsinh(TXTTENDANGNHAP.Text);
                        hs.ShowDialog();
                        this.Hide();
                    }
                    else if (dt.Rows[i]["LOAITK"].ToString() == "2")
                    {
                        giaovien hs = new giaovien();
                        hs.magv = dt.Rows[i]["TENDANGNHAP"].ToString();
                        
                        hs.ShowDialog();
                        this.Hide();
                    }
                    else if (dt.Rows[i]["LOAITK"].ToString() == "3")
                    {
                        quanlyhethong ht2 = new quanlyhethong();
                        ht2.ShowDialog();
                        this.Hide();
                    }
                    kiemtra = true;
                    break;
                    
                }
                else kiemtra = false;
               
                
            }
            if (kiemtra == true)
            {

            }
            else
            {
                MessageBox.Show("Sai");
            }           


            
            
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
