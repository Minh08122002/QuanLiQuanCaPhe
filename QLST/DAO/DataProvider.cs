using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        
        
        string conn = @"Data Source=.\DESKTOP-VL7UGOA\SQLEXPRESS; Initial Catalog=QLCF; Integrated Security=True";
        private static DataProvider instance;
        public static DataProvider Instance { get{
                if (instance == null)
                    instance = new DataProvider();
                return instance; } }
        
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                
                sqlconn.Open();
                SqlCommand comm = new SqlCommand(query, sqlconn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                
                adapter.Fill(data);
                sqlconn.Close();
            }
            return data;
        }
        
        public int ExecuteNonQuery(string query, object[] parameter=null)
        {
            int count = 0;
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                SqlCommand comm = new SqlCommand(query, sqlconn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                count = comm.ExecuteNonQuery();
                sqlconn.Close();
            }
            return count;
        }
        public object ExecuteScalar(string query, object[] parameter=null)
        {
            object data = 0;
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                SqlCommand comm = new SqlCommand(query, sqlconn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = comm.ExecuteScalar();
                sqlconn.Close();
            }
            return data;
        }

    }
}
