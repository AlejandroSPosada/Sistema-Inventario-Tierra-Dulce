using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // If you have issues, switch to System.Data.SqlClient


namespace WinFormsApp1{
    public partial class Form1 : Form
    {
        string query_inf_gen = "EXEC GetDynamicAnimalReport";
        string query_show_finca = "EXEC show_animals_in_finca '1'";
        //string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        string connectionString = "Data Source=(localdb)\\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
            LoadDataIntoDataGridView(query_inf_gen, dataGridView1);
            LoadDataIntoDataGridView(query_show_finca, dataGridView2);
        }

        private void LoadDataIntoDataGridView(string query, DataGridView dataG)
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
                        dataG.DataSource = dt;  // Bind data to DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataIntoDataGridView(query_inf_gen, dataGridView1);
        }

        private void comboBox_vis_gen_inf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataIntoDataGridView(query_show_finca, dataGridView2);
        }
    }
}
