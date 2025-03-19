using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    class AnimalRepository : IAnimalRepository
    {
        public bool IdExists(string id)
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SqlHelper.FuncAnimalExists, conn))
                {
                    cmd.Parameters.AddWithValue("@Chapeta", id);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result == 1;
                }
            }
        }
    }
}
