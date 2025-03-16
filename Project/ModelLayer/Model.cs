using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Project.PresenterLayer;

namespace Project.ModelLayer
{
    class Model
    {
        public Movimiento movimiento;
        private string connectionString = "Data Source=(localdb)\\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
        private string query_inf_gen = "EXEC GetDynamicAnimalReport";
        private string get_table_finca = "SELECT*FROM finca";
        private string get_table_concepto = "SELECT*FROM concepto";
        private string get_table_proveedor = "SELECT*FROM proveedor ORDER BY 'nombre'";
        private string get_tabe_cliente = "SELECT*FROM cliente ORDER BY 'nombre'";
        public Model()
        {
            this.movimiento = new Movimiento();
        }

        public List<DataTable> Show_Initial_DataGrid_Model()
        {
            return new List<DataTable> {
            GetDataTable(get_table_finca),
            GetDataTable(get_table_concepto),
            GetDataTable(get_table_proveedor),
            GetDataTable(get_tabe_cliente),
            GetDataTable(query_inf_gen),
            GetDataTable("EXEC select_compra"),
            GetDataTable("EXEC select_venta")
            };
        }
        
        private DataTable GetDataTable(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable Show_Animals_In_Finca_Order_Model(int id)
        {
            return GetDataTable("EXEC show_animals_in_finca '" + id + "'");
        }

        public DataTable button_vis_mov_chapeta_Click_Model(string text)
        {
            string query = "EXEC show_movimientos_of_animal @Chapeta";
            return GetDataTable("EXEC show_movimientos_of_animal '" + text +"'");
        }

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
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}
