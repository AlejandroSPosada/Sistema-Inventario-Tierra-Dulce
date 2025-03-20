using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MessageSystem
{
    public static class ManageError
    {
        public static int reader_int(SqlDataReader reader, string get)
        {
            return !reader.IsDBNull(reader.GetOrdinal(get)) ? Convert.ToInt32(reader[get]) : 0;
        }

        public static string reader_string_id(SqlDataReader reader, string get)
        {
            return !reader.IsDBNull(reader.GetOrdinal(get)) ? reader[get].ToString() : "-1";
        }

        public static string reader_string(SqlDataReader reader, string get)
        {
            return !reader.IsDBNull(reader.GetOrdinal(get)) ? reader[get].ToString() : "No especificado";
        }
    }
}
