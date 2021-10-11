using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detai.DTO;
using System.Data;

namespace detai.DAO
{
    class TAIKHOANDAO
    {
        public static DataTable CHECK()
        {
            string sql = "SELECT * FROM TAIKHOAN";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable KTRATAIKHOAN(string loatk)
        {
            string sql = "SELECT * FROM TAIKHOAN WHERE LOAITK='"+loatk+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static void TAOTAIKHOAN(String TENDANGNHAP,String MATKHAU, String LOAITAIKHOAN,String MA)
        {
            string sql = "INSERT INTO TAIKHOAN(tendangnhap,matkhau,loaitk,ma) VALUES('"+TENDANGNHAP+"','"+MATKHAU+"','"+LOAITAIKHOAN+"','"+MA+"')";
            
            KETNOICSDL.ExcuteQuery(sql);
            
        }
        public static void up(String TENDANGNHAP,String MATKHAU)
        {
            string sql = "update taikhoan set matkhau='"+MATKHAU+"'where tendangnhap='"+TENDANGNHAP+"'";
            KETNOICSDL.ExcuteQuery(sql);

        }
        public static void DELETE(String TENDANGNHAP)
        {
            string sql = "delete from taikhoan where tendangnhap='" + TENDANGNHAP + "'";

            KETNOICSDL.ExcuteQuery(sql);

        }

    }
}
