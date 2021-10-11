using detai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DAO
{
    class LOPDAO
    {
        public static DataTable ttlop()
        {
            string sql = "SELECT * FROM LOP";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable ttloptheokhoi(LOPDTO lop)
        {
            string sql = "SELECT * FROM LOP WHERE MALOP='"+lop.malop+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable ttlopKHOI(string khoi)
        {
            string sql = "SELECT * FROM LOP where KHOI="+khoi+"";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable GVCN(LOPDTO lop)
        {
            string sql = "SELECT G.MAGV,TENGV,GIOITINH,ngaysinh FROM GVCN cn,GIAOVIEN g WHERE MALOP='"+lop.malop+"' and cn.Magv=g.magv";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static void themlop(LOPDTO lop,string khoi)
        {
            string sql = "Insert into lop([MALOP],[khoi]) VALUES (N'"+lop.malop+"',"+khoi+")";
            KETNOICSDL.ExcuteNonQuery(sql);
            
        }
        public static void xoalop(LOPDTO lop)
        {
            string sql = "delete from lop where malop='" + lop.malop + "'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
    }
}
