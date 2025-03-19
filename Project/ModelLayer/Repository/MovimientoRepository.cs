using Microsoft.Data.SqlClient;
using Project.MessageSystem;
using Project.ModelLayer.EntityModel;
using Project.ModelLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    class MovimientoRepository : IMovimientoRepository
    {
        public Movimiento SearchByID(string id)
        {
            using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM movimiento WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Movimiento
                            {
                                Chapeta = reader["id_animal"].ToString(),
                                Concepto = ManageError.reader_int(reader, "id_concepto"),
                                Fecha = Convert.ToDateTime(reader["fecha"]),
                                FincaOrigen = ManageError.reader_int(reader, "id_finca_origen"),
                                FincaDestino = ManageError.reader_int(reader, "id_finca_destino"),
                                PesoOrigen = ManageError.reader_int(reader, "peso_origen"),
                                PesoDestino = ManageError.reader_int(reader, "peso_destino")
                            };
                        }
                    }
                }
            }
            return null; // Return null if no record found
        }
    }
}
