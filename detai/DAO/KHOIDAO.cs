using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace detai.DAO
{
    class KHOIDAO
    {
        public static DataTable KHOI()
        {
            string sql = "SELECT * FROM KHOI";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
