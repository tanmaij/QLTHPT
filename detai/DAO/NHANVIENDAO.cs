using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detai.DTO;
using System.Data;

namespace detai.DAO
{
    class NHANVIENDAO
    {
        public static DataTable THOGNTINNHANVIEN()
        {
            string sql = " SELECT * FROM NHANVIEN";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable ttctnv(NHANVIENDTO nv)
        {
            string sql = " SELECT * FROM NHANVIEN WHERE MANV='" + nv.manv + "'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static void xoanv(NHANVIENDTO nv)
        {
            string sql = "delete from NHANVIEN where MANV='" + nv.manv + "'";

            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void capnhatnv(NHANVIENDTO nv, CHUCVUDTO cv)
        {
            string sql = "UPDATE NHANVIEN SET TENNV='" + nv.tennv + "',MACHUCVU='" + cv.macv + "',NGAYSINH='" + nv.ngaysinh + "',GIOITINH=" + nv.gioitinh + ",DIACHI='" + nv.diachi + "'  WHERE MANV='" + nv.manv + "'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void themnv(NHANVIENDTO nv, CHUCVUDTO cv)
        {
            string sql = "insert into NHANVIEN([MANV],[TENNV],[GIOITINH],[DIACHI],[MACHUCVU]) VALUES('" + nv.manv + "',N'" + nv.tennv + "'," + nv.gioitinh + ",N'" + nv.diachi + "',N'" + cv.macv + "')";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
    }
}
