using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL2.Data
{
    internal class Sql
    {
        private const string connectionString = "server=.;database=AdoNet;trusted_connection=True;Integrated Security=True";
        private static SqlConnection _connection = new SqlConnection(connectionString);

        public int ExecuteCommand(string cmd)
        {
            int result = 0;
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(cmd, _connection);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            try
            {
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return table;
        }
    }
}
