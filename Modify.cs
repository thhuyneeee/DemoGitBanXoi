using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiBanXoi
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; // dung de truy van lenh insert, update,..
        SqlDataReader dataReader; // dung de doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string query)// check tai khoan
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }

                sqlConnection.Close();
            }

            return taiKhoans;
        }
        public void Command(string query) // dung de dang ki tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();// thuc thi cau truy van
                sqlConnection.Close();
            }
        }
       
    }
}

