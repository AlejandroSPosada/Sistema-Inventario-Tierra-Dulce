using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // If you have issues, switch to System.Data.SqlClient
using Project.PresenterLayer;


namespace View{
    public partial class View1 : Form
    {
        Presenter presenter;
        public View1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            presenter.Show_all_initial_information();
        }

        public void LoadDataIntoDataGrideView(DataTable all_fincas_table, DataTable specific_table)
        {
            dataGridView1.DataSource = all_fincas_table;
            dataGridView2.DataSource = specific_table;
        }
    }
}
