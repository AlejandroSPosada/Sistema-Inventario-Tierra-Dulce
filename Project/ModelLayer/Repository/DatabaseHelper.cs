using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.ModelLayer.Helpers;

namespace Project.ModelLayer.Repository
{
    class DatabaseHelper
    {

        public DataTable ExecuteStoredProcedure(string procedureName, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
