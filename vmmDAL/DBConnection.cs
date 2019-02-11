using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace vmmDAL
{
    public class DBConnection
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=WINDOWS-090SA4I\FAHADSQL;Initial Catalog=VMM;Integrated Security=True");


        public SqlConnection GetConnection() 
        {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
            return connection;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            int rowAffected = -1;
            try
            {
                rowAffected = cmd.ExecuteNonQuery();
                connection.Close();
            }catch(Exception ex){ MessageBox.Show(ex.Message); }
            return rowAffected;

        }

        //public object ExeScaler(SqlCommand cmd)
        //{
        //    cmd.Connection=GetConnection();
        //    object obj=-1;
        //    obj=cmd.ExecuteScalar();
        //    connection.Close();
        //    return obj;
        //}

        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }

        public void DeleteExeReader(SqlCommand cmd) {
            cmd.Connection = GetConnection();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public DataTable ExeReader1(SqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            SqlDataReader sdr1;
            DataTable dt = new DataTable();

            sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            connection.Close();
            return dt;
        }
    }
}
