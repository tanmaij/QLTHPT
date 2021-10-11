using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detai.DAO;
using detai.DTO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace detai.BUS
{
    class GIAOVIENBUS
    {
        public static DataTable THONGTINGIAOVIEN()
        {
            DataTable dt = new DataTable();
            dt = GIAOVIENDAO.THOGNTINGIAOVIEN();
            return dt;
        }

        public static void xoagv(GIAOVIENDTO gv)
        {
            if (MessageBox.Show("CÓ THẬT SỰ MUỐN XÓA KHÔNG?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    GIAOVIENDAO.xoagv(gv);

                }
                catch
                {
                    MessageBox.Show("KHÔNG XÓA ĐƯỢC");
                }
        
        }
        public static DataTable laymonhoc10()
        {
            DataTable dt = new DataTable();
            
            dt = MONHOCDAO.THOGNTINMONHOCKHOI10();
            return dt;

        }
        public static DataTable laymonhoc11()
        {
            DataTable dt = new DataTable();

            dt = MONHOCDAO.THOGNTINMONHOCKHOI11();
            return dt;

        }
        public static DataTable laymonhoc12()
        {
            DataTable dt = new DataTable();

            dt = MONHOCDAO.THOGNTINMONHOCKHOI12();
            return dt;

        }

        public static DataTable KHOI()
        {
            DataTable dt = new DataTable();
            dt = KHOIDAO.KHOI();
            return dt;
        }
    }
}
