using Microsoft.Data.SqlClient; // If you have issues, switch to System.Data.SqlClient
using Project.PresenterLayer;
using Project.MessageSystem;
using System.Data;


namespace View{
    public partial class View1 : Form
    {
        private Presenter presenter;
        public View1()
        {
            InitializeComponent();
            presenter = new Presenter(this, new RepositoryFactory());
            presenter.InitializeInventoryPresenter();
        }

        private void comboBox_vis_gen_informacion_por_finca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(comboBox_vis_gen_informacion_por_finca.SelectedValue);
            presenter.ShowAnimalesFincaPresenter(selectedId);
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
            int PesoOrigen1 = ManageError.string_int(textBox_ins_mov_peso_origen.Text, "peso origen no válido.");
            int PesoDestino1 = ManageError.string_int(textBox_ins_mov_peso_destino.Text, "peso destino no válido");
            int tipo = Convert.ToInt32(comboBox_ins_mov_tipo.SelectedValue);

            presenter.Insert_Movimiento_Presenter(
                textBox_ins_mov_chapeta.Text,
                conceptoId,
                dateTimePicker_ins_mov_fecha.Value,
                fincaOrigenId,
                fincaDestinoId,
                PesoOrigen1,
                PesoDestino1,
                tipo
            );
        }

        private void button_ins_com_Click(object sender, EventArgs e)
        {
            int fincaId = Convert.ToInt32(comboBox_ins_com_finca.SelectedValue);
            string proveedorId = Convert.ToString(comboBox_ins_com_proveedor.SelectedValue);
            int peso = ManageError.string_int(textBox_ins_com_peso_despacho.Text, "Peso no válido");
            presenter.Insert_Compra_Presenter(
                fincaId,
                proveedorId,
                dateTimePicker_ins_mov_fecha.Value,
                peso,
                textBox_ins_com_factura.Text
            );
        }

        private void button_ins_ven_Click(object sender, EventArgs e)
        {
            int fincaId = Convert.ToInt32(comboBox_ins_ven_finca.SelectedValue);
            string clienteId = Convert.ToString(comboBox_ins_ven_cliente.SelectedValue);
            int peso = ManageError.string_int(textBox_ins_ven_peso_despacho.Text, "Peso invalido.");
            presenter.Insert_Venta_Presenter(
                fincaId,
                clienteId,
                dateTimePicker_ins_mov_fecha.Value,
                peso,
                textBox_ins_com_factura.Text
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.ExportExcelPresenter();
        }

        private void button_act_mov_id_movimiento_Click(object sender, EventArgs e)
        {
            string idMovimiento = textBox_act_mov_id_movimiento.Text;
            presenter.GetMovimientoById(idMovimiento);
        }
        private void button_act_com_id_compra_Click(object sender, EventArgs e)
        {
            string idCompra = textBox_act_com_id_compra.Text;
            presenter.GetCompraById(idCompra);
        }
        private void button_act_com_id_venta_Click(object sender, EventArgs e)
        {
            string idVenta = textBox1.Text;
            presenter.GetVentaById(idVenta);
        }
    }
}
