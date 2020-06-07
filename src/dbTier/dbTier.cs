using System;
using System.Data;
using System.Data.SqlClient;


namespace dbTier
{
    public class PersonDAL
    {
        public string ConString = "Data Source=DESKTOP-49JJEDQ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

        SqlConnection con = new SqlConnection();

        DataTable dt = new DataTable();

        public DataTable Read()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Person",con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public DataTable Read(Int16 Id)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Person where ID= "+ Id +"", con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public void Update(string StrQuery)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Person", con);

            try
            {
                cmd.CommandText = StrQuery;
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }


        }
    }
}
