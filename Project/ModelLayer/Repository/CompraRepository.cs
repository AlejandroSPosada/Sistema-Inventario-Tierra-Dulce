using Microsoft.Data.SqlClient;
using Project.MessageSystem;
using Project.ModelLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    class CompraRepository : ICompraRepository
    {
        public Compra SearchByID(string id)
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
                            return new Compra
                            {
                                Finca = ManageError.reader_int(reader, "id_finca"),
                                IdProveedor = ManageError.reader_string_id(reader, "id_proveedor"),
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

        public void DeleteByID(string id)
        {
            string query = "DELETE FROM compra WHERE id = @id";
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

        public void UpdateByID(Compra compra, string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SqlHelper.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("update_compra", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@id_finca", compra.Finca);
                        cmd.Parameters.AddWithValue("@id_proveedor", compra.IdProveedor);
                        cmd.Parameters.AddWithValue("@peso_despacho", compra.PesoDespacho);
                        cmd.Parameters.AddWithValue("@fecha", compra.Fecha);
                        cmd.Parameters.AddWithValue("@factura", compra.Factura);
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
