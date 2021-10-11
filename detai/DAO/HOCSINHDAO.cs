
using detai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DAO
{
    class HOCSINHDAO
    {
        public static DataTable TTHS()
        {
            string sql = "SELECT * FROM HOCSINH";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable TTHSTHEOLOP(LOPDTO lop)
        {
            string sql = "SELECT * FROM HOCSINH WHERE MALOP='"+lop.malop+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable TTHScuthe(HOCSINHDTO hs)
        {
            string sql = "SELECT * FROM HOCSINH WHERE MAHOCSINH='"+hs.mahs+"'";
            DataTable dt = new DataTable();
            dt = KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static void capnhat(HOCSINHDTO hs,LOPDTO lop)
        {
            string sql = "update HOCSINH set HoTen=N'" + hs.tenhs + "',NgaySinh='" + hs.ngaysinh + "',DiaChi=N'" + hs.diachi + "',GIOITINH='" + hs.gioitinh + "',MALOP=N'"+lop.malop+"' where MaHOCSINH='" + hs.mahs + "'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void Them(HOCSINHDTO hs, LOPDTO lop)
        {
            string sql = "Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'"+hs.mahs+"',N'"+hs.tenhs+"','"+hs.ngaysinh+"',"+hs.gioitinh+",N'"+hs.diachi+"',N'"+lop.malop+"')";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
    }
}
