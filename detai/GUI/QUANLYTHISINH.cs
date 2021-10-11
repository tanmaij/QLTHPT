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
    public partial class QUANLYTHISINH : Form
    {
        public QUANLYTHISINH()
        {
            InitializeComponent();
        }

        private void QUANLYTHISINH_Load(object sender, EventArgs e)
        {

        }

        private void BTTHEM_Click(object sender, EventArgs e)
        {
            THISINHDTO ts = new THISINHDTO();
            ts.mats = TXTMATS.Text;
            ts.tents = TXTHOTEN.Text;
            ts.ngaysinh = TXTNGAYSINH.Text;
            ts.gioitinh = int.Parse(TXTGIOITINH.Text);
            ts.diachi = TXTDIACHI.Text;
            THISINHDAO.themts(ts);

        }
    }
}
