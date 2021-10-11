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
    public partial class NHANVIENTHUVIEN : Form
    {
        public NHANVIENTHUVIEN()
        {
            InitializeComponent();
        }

        private void NHANVIENTHUVIEN_Load(object sender, EventArgs e)
        {
            ptrGT.Image = Image.FromFile("nvtv.png");
           
        }
    }
}
