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
    public partial class THEMLOP : Form
    {
        public THEMLOP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            them("10");
        }
        void them(string khoi)
        {
            string[] solop;
            DataTable dt = new DataTable();
            dt = LOPDAO.ttlopKHOI(khoi);
            int lop = 1;
            int row = 0;
            string tenlop = khoi + "A" + lop;
            int so= dt.Rows.Count + 1;
            solop = new string[so];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                solop[i] = dt.Rows[i]["MALOP"].ToString();
            }

            int num= 0;
            solop[so-1] = "";
            while ( tenlop == solop[num])
                {
                    num++;
                    lop++;
                    row++;
                    tenlop = khoi + "A" + lop;
                }
            
            LOPDTO l = new LOPDTO();
            l.malop = tenlop;
            LOPDAO.themlop(l,khoi);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            them("11");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            them("12");
        }
    }
}
