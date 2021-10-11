using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace detai.DAO
{
    class KETNOICSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @" Data Source = Q;Initial Catalog=QLTHPT;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == System.Data.ConnectionState.Closed)
                    cnn.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Ket noi khong thanh cong");
            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable ExcuteQuery(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ExcuteNonQuery(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
