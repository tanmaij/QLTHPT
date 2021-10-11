using detai.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.BUS
{
    class THISINHBUS
    {
        public static DataTable THONGTINTHISINH()
        {

            DataTable dt = new DataTable();
            dt = THISINHDAO.THONGTINTHISINH();
            return dt;
        }
    }
}
