using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Project.PresenterLayer;
using Project.ModelLayer.Helpers;
using Project.ModelLayer.EntityModel;
namespace Project.ModelLayer
{
    class Model
    {   
        public Movimiento movimiento;
        private string connectionString = "Data Source=(localdb)\\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";

        public Model()
        {
            this.movimiento = new Movimiento();
        }

        public List<DataTable> InitializeInventoryModel()
        {
            return new List<DataTable> {
                SqlHelper.GetDataTable(SqlHelper.Finca),
                SqlHelper.GetDataTable(SqlHelper.Concepto),
                SqlHelper.GetDataTable(SqlHelper.Proveedor),
                SqlHelper.GetDataTable(SqlHelper.Cliente),
                SqlHelper.GetDataTable(SqlHelper.ProcedureGetDynamicAnimalReport),
                SqlHelper.GetDataTable(SqlHelper.ProcedureSelectCompra),
                SqlHelper.GetDataTable(SqlHelper.ProcedureSelectVenta),
                SqlHelper.GetDataTable(SqlHelper.AnimalTipo)
            };
        }

        public DataTable Show_Animals_In_Finca_Order_Model(int id)
        {
            return SqlHelper.GetDataTable("EXEC show_animals_in_finca '" + id + "'");
        }

        public DataTable button_vis_mov_chapeta_Click_Model(string text)
        {
            return SqlHelper.GetDataTable("EXEC show_movimientos_of_animal '" + text + "'");
        }
        //INSERT PART
        public bool InsertMovimiento(Movimiento movimiento)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert_movimiento", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input_id_animal", movimiento.Chapeta);
                    cmd.Parameters.AddWithValue("@input_id_concepto", movimiento.Concepto);
                    cmd.Parameters.AddWithValue("@input_fecha", movimiento.Fecha);
                    cmd.Parameters.AddWithValue("@input_id_finca_origen", movimiento.FincaOrigen);
                    cmd.Parameters.AddWithValue("@input_peso_origen", movimiento.PesoOrigen);
                    cmd.Parameters.AddWithValue("@input_id_finca_destino", movimiento.FincaDestino);
                    cmd.Parameters.AddWithValue("@input_id_peso_destino", movimiento.PesoDestino);
                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public bool InsertCompra(Compra compra)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert_compra", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input_id_finca", compra.Finca);
                    cmd.Parameters.AddWithValue("@input_id_proveedor", compra.IdProveedor);
                    cmd.Parameters.AddWithValue("@input_peso_despacho", compra.PesoDespacho);
                    cmd.Parameters.AddWithValue("@input_fecha", compra.Fecha);
                    cmd.Parameters.AddWithValue("@input_factura", compra.Factura);
              
                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public bool InsertVenta(Venta venta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert_venta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input_id_finca", venta.Finca);
                    cmd.Parameters.AddWithValue("@input_id_cliente", venta.IdCliente);
                    cmd.Parameters.AddWithValue("@input_peso_despacho", venta.PesoDespacho);
                    cmd.Parameters.AddWithValue("@input_fecha", venta.Fecha);
                    cmd.Parameters.AddWithValue("@input_factura", venta.Factura);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public bool AnimalExists(string chapeta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT dbo.fn_AnimalExists(@Chapeta)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Chapeta", chapeta);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result == 1;  
                }
            }
        }

        public bool InsertAnimal(string idAnimal, int tipo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO animal(id, id_tipo) VALUES(@IdAnimal, @Tipo);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAnimal", idAnimal);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;  
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public void ExportExcelModel()
        {
            string connectionString = @"Data Source=(localdb)\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
            string query = "EXEC movimiento_names";

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                if (dataTable.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Save an Excel File",
                        FileName = "Movimientos.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dataTable, "Movimientos");
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Excel file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data found to export!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ExecuteStoredProcedure(string procedureName, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
