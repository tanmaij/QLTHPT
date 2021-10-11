using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detai.DTO;
using System.Data;
namespace detai.DAO
{
    class MONHOCDAO
    {
        public static DataTable THOGNTINMONHOCKHOI10()
        {
            string sql = " SELECT * FROM MONHOC WHERE KHOI=10";
            
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            
            return dt;
        }
        public static DataTable THOGNTINMONHOCKHOI11()
        {
            string sql = " SELECT * FROM MONHOC WHERE KHOI=11";

            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);

            return dt;
        }
        public static DataTable THOGNTINMONHOCKHOI12()
        {
            string sql = " SELECT * FROM MONHOC WHERE KHOI=12";

            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);

            return dt;
        }

    }
}
