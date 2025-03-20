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
                string query = "SELECT * FROM venta WHERE id = @id";
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
                                Factura = ManageError.reader_string(reader, "factura")
                            };
                        }
                    }
                }
            }
            return null; // Return null if no record found
        }

        public void DeleteByID(string id)
        {
            string query = "DELETE FROM venta WHERE id = @id";
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

        public void UpdateByID(Venta venta, string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlHelper.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("update_venta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@id_finca", venta.Finca);
                        cmd.Parameters.AddWithValue("@id_cliente", venta.IdCliente);
                        cmd.Parameters.AddWithValue("@peso_despacho", venta.PesoDespacho);
                        cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                        cmd.Parameters.AddWithValue("@factura", venta.Factura);
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
