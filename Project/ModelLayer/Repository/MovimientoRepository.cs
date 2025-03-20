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
            try
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
            }
            catch {  };
            return null; // Return null if no record found
        }

        public void DeleteByID(string id)
        {
            string query = "DELETE FROM movimiento WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateByID(Movimiento movimiento, string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlHelper.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("update_movimiento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@fecha", movimiento.Fecha);
                        cmd.Parameters.AddWithValue("@id_concepto", movimiento.Concepto);
                        cmd.Parameters.AddWithValue("@id_finca_origen", movimiento.FincaOrigen);
                        cmd.Parameters.AddWithValue("@id_finca_destino", movimiento.FincaDestino);
                        cmd.Parameters.AddWithValue("@peso_origen", movimiento.PesoOrigen);
                        cmd.Parameters.AddWithValue("@peso_destino", movimiento.PesoDestino);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                ShowMessages.ShowMessage("Hubo un error con el proceso.");
            }
        }
    }
}
