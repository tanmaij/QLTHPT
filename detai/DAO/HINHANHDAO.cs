using detai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detai.DAO
{
    class HINHANHDAO
    {
        public static DataTable GET_IMAGE(HINHANHDTO img)
        {
            DataTable dt = new DataTable();
            string sql = "select * From HINHANH WHERE MA='" + img.ma + "'";
            dt=KETNOICSDL.ExcuteQuery(sql);
            return dt;
        }
        public static void ISNERT_IMAGE(HINHANHDTO img)
        {
            string sql = "insert into HINHANH([MA],[HINH]) VALUES('" + img.ma + "','" + img.hinh + "')";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void DELETE_IMAGE(string ma)
        {
            string sql = "delete FROM HINHANH WHERE MA='"+ma+"'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static void UPDATE_IMAGE(HINHANHDTO img)
        {
            string sql = "UPDATE HINHANH set HINH='" + img.hinh + "' WHERE MA='"+img.ma+ "'";
            KETNOICSDL.ExcuteNonQuery(sql);
        }
        public static byte[] converImgToByte(string img_path)
        {
            FileStream fs;
            fs = new FileStream(img_path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        public static Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public static Image Image_Object(string ma)
        {
            Image image;
            DataTable dt = new DataTable();
            HINHANHDTO img = new HINHANHDTO();
            img.ma = ma;
            dt = HINHANHDAO.GET_IMAGE(img);
            image = ByteToImg(dt.Rows[0]["HINH"].ToString());
            return image;
        }
    }
}
