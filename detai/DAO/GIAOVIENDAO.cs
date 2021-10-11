using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detai.DTO;
using System.Data;

namespace detai.DAO
{
    class GIAOVIENDAO
    {
        public static DataTable THOGNTINGIAOVIEN()
        {
            string sql = " SELECT * FROM GIAOVIEN";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable GVCN(string magv)
        {
            string sql = " SELECT * FROM GVCN WHERE MAGV='" + magv + "'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ttctgv(GIAOVIENDTO gv)
        {
            string sql = " SELECT * FROM GIAOVIEN WHERE MAGV='" + gv.magv + "'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable THONGTINMONGIAOVIEN(GIAOVIENDTO gv)
        {
            
            string sql = "SELECT M.MAMH,TENMH from GIAOVIEN G, MONHOC M,GVDAYMONHOC G1 WHERE G.MAGV=G1.MAGV AND G1.MAMH=M.MAMH AND G.MAGV='"+gv.magv+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void capnhat(GIAOVIENDTO gv,CHUCVUDTO cv)
        {
            string sql = "UPDATE GIAOVIEN SET TENGV='" + gv.tengv + "',CHUCVU='"+cv.macv+"',NGAYSINH='"+gv.ngaysinh+ "',GIOITINH="+gv.gioitinh+",DIACHI='"+gv.diachi+"',NGAYVAOTRUONG='"+gv.ngayvaotruong+"' WHERE MAGV='"+gv.magv+"'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void themgv(GIAOVIENDTO gv,CHUCVUDTO cv)
        {
            string sql = "insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[GIOITINH],[DIACHI],[CHUCVU],[NGAYVAOTRUONG]) VALUES('" + gv.magv + "',N'" + gv.tengv + "',N'" + gv.ngaysinh + "'," + gv.gioitinh + ",N'" + gv.diachi + "',N'"+cv.macv+"','" + gv.ngayvaotruong + "')";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void tinhngay(GIAOVIENDTO gv)
        {
           string sql= "update GIAOVIEN set NGAYDADAY=" + gv.ngaydaday + "where MAGV='" + gv.magv + "'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void themmonchogv(GIAOVIENDTO gv, MONHOCDTO mh)
        {
            string sql="insert into GVDAYMONHOC([MAGV],[MAMH]) VALUES ('" +gv.magv+"','"+mh.mamh+"')";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void xoamon(GIAOVIENDTO gv, MONHOCDTO mh)
        {
            string sql = "delete from GVDAYMONHOC where MAGV='" + gv.magv + "'and MAMH= '"+mh.mamh+"'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void xoagv(GIAOVIENDTO gv)
        {
            string sql2 = "delete from GVCN where MAGV='" + gv.magv + "'";
            string sql = "delete from GIAOVIEN where MAGV='" + gv.magv + "'";
            string sql3 = "delete from TAIKHOAN where TENDANGNHAP='" + gv.magv + "'";
            KETNOICSDL.ExcuteNonQuery(sql2);
            KETNOICSDL.ExcuteNonQuery(sql);
            KETNOICSDL.ExcuteNonQuery(sql3);
        }
        public static DataTable demgv()
        {
            string sql = "  SELECT count(MAGV) from GIAOVIEN";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable demgvchucvu(CHUCVUDTO cv)
        {
            string sql = "SELECT count(MAGV) from GIAOVIEN WHERE CHUCVU='"+cv.macv+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
