using System;
using System.Collections.Specialized;
using System.Data;
using System.Numerics;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // If you have issues, switch to System.Data.SqlClient
using Project.ModelLayer;
using Project.PresenterLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace View{
    public partial class View1 : Form
    {
        private Presenter presenter;
        public View1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            presenter.Show_Initial_Presenter();
        }

        public void Show_Initial_DataGrid_View(List<DataTable> tables)
        {
            //display
            comboBox_ins_mov_concepto.DisplayMember = "nombre";
            comboBox_ins_mov_finca_destino.DisplayMember = "nombre";
            comboBox_ins_mov_finca_origen.DisplayMember = "nombre";
            comboBox_ins_com_finca.DisplayMember = "nombre";
            comboBox_ins_com_proveedor.DisplayMember = "nombre";
            comboBox_ins_ven_finca.DisplayMember = "nombre";
            comboBox_ins_ven_cliente.DisplayMember = "nombre";
            comboBox_vis_gen_informacion_por_finca.DisplayMember = "nombre";

            //value member
            comboBox_ins_mov_concepto.ValueMember = "id";
            comboBox_ins_mov_finca_destino.ValueMember = "id";
            comboBox_ins_mov_finca_origen.ValueMember = "id";
            comboBox_ins_com_finca.ValueMember = "id";
            comboBox_ins_com_proveedor.ValueMember = "id";
            comboBox_ins_ven_finca.ValueMember = "id";
            comboBox_ins_ven_cliente.ValueMember = "id";
            comboBox_vis_gen_informacion_por_finca.ValueMember = "id";

            //0:finca, 1:concepto, 2: proveedor, 3: cliente
            comboBox_ins_mov_concepto.DataSource = tables[1].Copy();
            comboBox_ins_mov_finca_destino.DataSource = tables[0].Copy();
            comboBox_ins_mov_finca_origen.DataSource = tables[0].Copy();
            comboBox_ins_com_finca.DataSource = tables[0].Copy();
            comboBox_ins_com_proveedor.DataSource = tables[2].Copy();
            comboBox_ins_ven_finca.DataSource = tables[0].Copy();
            comboBox_ins_ven_cliente.DataSource = tables[3].Copy();
            comboBox_vis_gen_informacion_por_finca.DataSource = tables[0].Copy();

            dataGridView_general.DataSource = tables[4];

            dataGridView_vis_com.DataSource = tables[5];
            dataGridView_vis_ven.DataSource = tables[6];
        }

        private void comboBox_vis_gen_informacion_por_finca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(comboBox_vis_gen_informacion_por_finca.SelectedValue);
            presenter.Show_Animals_In_Finca_Order_Presenter(selectedId);
        }

        public void Show_Animals_In_Finca_Order_Receive(DataTable table)
        {
            dataGridView_por_finca.DataSource = table;
        }

        private void button_vis_mov_chapeta_Click(object sender, EventArgs e)
        {
            dataGridView_vis_mov.DataSource = presenter.button_vis_mov_chapeta_Click_Presenter(textBox_vis_mov_chapeta.Text);
        }

        private void button_insertar1_Click(object sender, EventArgs e)
        {
            int conceptoId = Convert.ToInt32(comboBox_ins_mov_concepto.SelectedValue);
            int fincaOrigenId = Convert.ToInt32(comboBox_ins_mov_finca_origen.SelectedValue);
            int fincaDestinoId = Convert.ToInt32(comboBox_ins_mov_finca_destino.SelectedValue);
            int PesoOrigen1 = Convert.ToInt32(textBox_ins_mov_peso_origen.Text);
            int PesoDestino1 = Convert.ToInt32(textBox_ins_mov_peso_destino.Text);

            presenter.Insert_Movimiento_Presenter(
                textBox_ins_mov_chapeta.Text,
                conceptoId,
                dateTimePicker_ins_mov_fecha.Value,
                fincaOrigenId,
                fincaDestinoId,
                PesoOrigen1,
                PesoDestino1
            );
        }
    }
}
