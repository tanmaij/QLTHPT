using detai.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace detai.DAO
{
    class THISINHDAO
    {
        public static void themts(THISINHDTO ts)
        {
            string sql = "insert into THISINHTHITUYEN([MATHISINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI]) VALUES('" +ts.mats + "',N'" + ts.tents + "','" + ts.ngaysinh + "'," + ts.gioitinh + ",N'"+ts.diachi+"')";
            string sql1 = "insert into DIEMTUYENSINH([MATHISINH]) VALUES('" + ts.mats + "')";
            KETNOICSDL.ExcuteQuery(sql);
            KETNOICSDL.ExcuteQuery(sql1);
        }
        public static void NHAPDIEM(DIEMTHISINHDTO ts)
        {
            string sql = "update DIEMTUYENSINH set DIEMTOAN=" + ts.DIEMTOAN + ",DIEMNGUVAN=" + ts.DIEMNV + ",DIEMTIENGANH=" + ts.DIEMAV + ",DIEMTONG=" + ts.DIEMTONG + "where MATHISINH='" + ts.mats + "'";

            KETNOICSDL.ExcuteQuery(sql);
           
        }
        public static DataTable THONGTINTHISINH()
        {
            string sql = "select * from THISINHTHITUYEN";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
