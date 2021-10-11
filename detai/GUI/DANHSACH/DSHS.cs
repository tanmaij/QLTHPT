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

namespace detai.GUI.DANHSACH
{
    public partial class DSHS : Form
    {
       
        public string malop;
        public DSHS()
        {
            InitializeComponent();
        }

        private void DSHS_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            LOPDTO lop = new LOPDTO();
            lop.malop = "Null";
            dt = HOCSINHDAO.TTHSTHEOLOP(lop);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // listView1.Items = dt.Rows[i]["MAHOCSINH"];
                
                listView1.Items.Add(dt.Rows[i]["hoten"].ToString());
                listView1.Items[i].Tag = dt.Rows[i]["MAHOCSINH"].ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                string sql = "update HOCSINH set Malop=N'" + malop + "' where MAHOCSINH='" + listView1.SelectedItems[i].Tag.ToString() + "'";
                KETNOICSDL.ExcuteNonQuery(sql);
            }
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
