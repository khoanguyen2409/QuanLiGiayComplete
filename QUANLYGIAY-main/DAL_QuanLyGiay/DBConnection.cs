using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DBConnection
    {
        String SQLConnect = @"Data Source=DESKTOP-CI36P6F;Initial Catalog=QUANLYGIAY_MAIN;Integrated Security=True";
    
        public SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(SQLConnect);
            return conn;
        }
    }
}
