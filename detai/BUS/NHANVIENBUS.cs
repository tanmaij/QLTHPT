using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using detai.DAO;
using detai.DTO;
using System.Windows.Forms;

namespace detai.BUS
{
    class NHANVIENBUS
    {
        public static DataTable THONGTINNHANVIEN()
        {
            DataTable dt = new DataTable();
            dt = NHANVIENDAO.THOGNTINNHANVIEN();
            return dt;
        }
        public static void xoanv(NHANVIENDTO nv)
        {
            if (MessageBox.Show("CÓ THẬT SỰ MUỐN XÓA KHÔNG?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    NHANVIENDAO.xoanv(nv);

                }
                catch
                {
                    MessageBox.Show("KHÔNG XÓA ĐƯỢC");
                }
        }
        public static void capnhatnv(NHANVIENDTO nv, CHUCVUDTO cv)
        {
            if (MessageBox.Show("CÓ THẬT SỰ MUỐN CẬP NHẬT KHÔNG?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    NHANVIENDAO.capnhatnv(nv, cv);

                }
                catch
                {
                    MessageBox.Show("KHÔNG CẬP NHẬT ĐƯỢC");
                }

        }
        public static void themnv(NHANVIENDTO nv, CHUCVUDTO cv)
        {
            if (MessageBox.Show("CÓ THẬT SỰ MUỐN THÊM KHÔNG?", "XÁC NHẬN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    NHANVIENDAO.capnhatnv(nv, cv);

                }
                catch
                {
                    MessageBox.Show("KHÔNG THÊM ĐƯỢC");
                }

        }

    }
}
