using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Project.PresenterLayer;

namespace Project.ModelLayer
{
    class Model
    {
        Presenter presenter;
        private string connectionString = "Data Source=(localdb)\\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
        private string query_inf_gen = "EXEC GetDynamicAnimalReport";
        private string get_table_finca = "SELECT*FROM finca";
        private string get_table_concepto = "SELECT*FROM concepto";
        private string get_table_proveedor = "SELECT*FROM proveedor ORDER BY 'nombre'";
        private string get_tabe_cliente = "SELECT*FROM cliente ORDER BY 'nombre'";
        public Model(Presenter presenter)
        {
            this.presenter = presenter;
        }

        public List<DataTable> Show_Initial_DataGrid_Model()
        {
            return new List<DataTable> { 
            GetDataTable(query_inf_gen)
            };
        }
        public List<DataTable> Show_Initial_ComboBox_Model()
        {
            //let's get with id and name: finca, concepto, proveedor, cliente 
            return new List<DataTable> {
            GetDataTable(get_table_finca),
            GetDataTable(get_table_concepto),
            GetDataTable(get_table_proveedor),
            GetDataTable(get_tabe_cliente),
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
    }
}
