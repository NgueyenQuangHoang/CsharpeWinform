using System.Data;
using System.Data.SqlClient;

namespace QuanLyMatHang.Classes
{
    class DataBaseProcess
    {
        // Sửa chuỗi kết nối cho phù hợp với máy bạn
        string strConnect = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=BanHang;Integrated Security=true";

        SqlConnection sqlConnect = null;

        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }

        public DataTable DataReader(string sqlSelect)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }

        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
    }
}