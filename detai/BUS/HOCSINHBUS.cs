using detai.DAO;
using detai.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detai.BUS
{
    class HOCSINHBUS
    {
        public static void capnhat(HOCSINHDTO hs, LOPDTO lop)
        {
            if (MessageBox.Show("CÓ THẬT SỰ MUỐN CẬP NHẬT HÔN?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    HOCSINHDAO.capnhat(hs, lop);
                }
                catch
                {
                    MessageBox.Show("KHÔNG CẬP NHẬT ĐƯỢC");
                }
        }
    }
}
