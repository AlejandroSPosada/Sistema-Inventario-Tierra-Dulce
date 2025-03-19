using Microsoft.Data.SqlClient;
using Project.MessageSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    class VentaRepository : IVentaRepository
    {
        public Venta SearchByID(string id)
        {
            using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM compra WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Venta
                            {
                                Finca = ManageError.reader_int(reader, "id_finca"),
                                IdCliente = ManageError.reader_string_id(reader, "id_cliente"),
                                Fecha = Convert.ToDateTime(reader["fecha"]),
                                PesoDespacho = ManageError.reader_int(reader, "peso_despacho"),
                                Factura = ManageError.reader_string(reader, "Factura")
                            };
                        }
                    }
                }
            }
            return null; // Return null if no record found
        }
    }
}
