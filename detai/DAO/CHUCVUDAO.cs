using detai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DAO
{
    class CHUCVUDAO
    {
        public static DataTable TENCHUCVU(CHUCVUDTO cv)
        {
            string sql = " SELECT * FROM CHUCVU WHERE MACHUCVU='"+cv.macv+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable POSITION_SCHOOL()
        {
            string sql = " SELECT * FROM CHUCVU";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
