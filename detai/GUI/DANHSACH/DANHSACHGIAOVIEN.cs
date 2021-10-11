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

namespace detai.GUI.DANHSACH
{
    public partial class DANHSACHGIAOVIEN : Form
    {
        public string malop;
        public DANHSACHGIAOVIEN()
        {
            InitializeComponent();
        }

        private void DANHSACHGIAOVIEN_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            dt = GIAOVIENDAO.THOGNTINGIAOVIEN();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // listView1.Items = dt.Rows[i]["MAHOCSINH"];

                listView1.Items.Add(dt.Rows[i]["TENGV"].ToString());
                listView1.Items[i].Tag = dt.Rows[i]["MAGV"].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into GVCN([MAGV],[MALOP]) VALUES (N'" + listView1.SelectedItems[0].Tag + "',N'" + malop + "')";
                KETNOICSDL.ExcuteNonQuery(sql);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không Được!!!!!!!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
