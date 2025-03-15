using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Project.ModelLayer;
using View;
using System.Collections;

namespace Project.PresenterLayer
{
    class Presenter
    {
        private readonly View1 view;
        string connectionString = "Data Source=(localdb)\\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";

        public Presenter(View1 view)
        {
            this.view = view;
        }
        public void Show_all_initial_information()
        {
            string query_inf_gen = "EXEC GetDynamicAnimalReport";
            string query_show_finca = "EXEC show_animals_in_finca '1'";
            DataTable table1 = GetDataTable(query_inf_gen);
            DataTable table2 = GetDataTable(query_show_finca);
            view.LoadDataIntoDataGrideView(table1, table2);
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
    }
}
