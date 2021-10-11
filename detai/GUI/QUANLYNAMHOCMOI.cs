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
    public partial class QUANLYNAMHOCMOI : Form
    {
        public QUANLYNAMHOCMOI()
        {
            InitializeComponent();
        }

        private void QUANLYNAMHOCMOI_Load(object sender, EventArgs e)
        {
            button1.Text = "QUẢN LÝ KHÁCH HÀNG";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.Image = Image.FromFile("icon.jpg");
            button1.ImageAlign =ContentAlignment.TopCenter;
        }
    }
}
