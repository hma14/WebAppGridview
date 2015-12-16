using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ChangeGridviewRowBkColor
{
    public class DataAccess
    {
        SqlConnection sqlconn;
        public DataAccess()
        {
            try {
                if (sqlconn == null)
                {
                    sqlconn = new SqlConnection(connectionString());
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();
                    }
                }
            } catch
            {
                throw;
            }
        }

        public void OpenConnection()
        {
            try {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                }
            }
            catch
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
            catch
            {
                throw;
            }
        }
     
        string connectionString()
        {
            return ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString;
        }

        public DataSet GetData(int rows)
        {
            using (SqlCommand sqlcommand = new SqlCommand("uspGetPhoneNumbers", sqlconn))
            {
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.AddWithValue("@rows", rows);

                 SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}