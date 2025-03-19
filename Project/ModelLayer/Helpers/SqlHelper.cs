using Microsoft.Data.SqlClient;
using Project.ModelLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Project.ModelLayer.Helpers
{
    public static class SqlHelper
    {
        public const string connectionString = "Data Source=(localdb)\\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
        public const string ProcedureGetDynamicAnimalReport = "EXEC GetDynamicAnimalReport";
        public const string ProcedureSelectCompra = "EXEC select_compra";
        public const string ProcedureSelectVenta = "EXEC select_venta";
        public const string FuncAnimalExists = "SELECT dbo.fn_AnimalExists(@Chapeta)";
        public const string Finca = "SELECT*FROM finca";
        public const string Concepto = "SELECT*FROM concepto";
        public const string Proveedor = "SELECT*FROM proveedor ORDER BY nombre"; 
        public const string Cliente = "SELECT*FROM cliente ORDER BY nombre";
        public const string AnimalTipo = "SELECT*FROM animal_tipo";
        public const string SearchIDMovimiento = "SELECT * FROM movimiento WHERE id = @id";
        public const string SearchIDCompra = "SELECT * FROM compra WHERE id = @id";
        public const string SearchIDVenta = "SELECT * FROM venta WHERE id = @id";

        public static DataTable GetDataTable(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public static SqlDataReader SearchByID(string idMovimiento, string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idMovimiento);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show($"No se encontró un movimiento con ID {idMovimiento}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return null;
                            }

                            if (reader.Read())
                            {
                                return reader;
                            }
                        }
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recuperar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}