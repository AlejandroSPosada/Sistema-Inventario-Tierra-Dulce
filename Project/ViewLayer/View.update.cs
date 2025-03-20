using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace View
{
    partial class View1
    {
        public void InitializeInventoryView(List<DataTable> tables)
        {
            //display
            comboBox_ins_mov_concepto.DisplayMember = "nombre";
            comboBox_ins_mov_finca_destino.DisplayMember = "nombre";
            comboBox_ins_mov_finca_origen.DisplayMember = "nombre";
            comboBox_ins_com_finca.DisplayMember = "nombre";
            comboBox_ins_com_proveedor.DisplayMember = "nombre";
            comboBox_ins_ven_finca.DisplayMember = "nombre";
            comboBox_ins_ven_cliente.DisplayMember = "nombre";
            comboBox_ins_mov_tipo.DisplayMember = "nombre";
            comboBox_vis_gen_informacion_por_finca.DisplayMember = "nombre";
            comboBox_act_mov_concepto.DisplayMember = "nombre";
            comboBox_act_mov_finca_destino.DisplayMember = "nombre";
            comboBox_act_mov_finca_origen.DisplayMember = "nombre";
            comboBox_act_com_finca.DisplayMember = "nombre";
            comboBox_act_com_proveedor.DisplayMember = "nombre";
            comboBox_act_ven_finca.DisplayMember = "nombre";
            comboBox_act_ven_cliente.DisplayMember = "nombre";

            //value member
            comboBox_ins_mov_concepto.ValueMember = "id";
            comboBox_ins_mov_finca_destino.ValueMember = "id";
            comboBox_ins_mov_finca_origen.ValueMember = "id";
            comboBox_ins_com_finca.ValueMember = "id";
            comboBox_ins_com_proveedor.ValueMember = "id";
            comboBox_ins_ven_finca.ValueMember = "id";
            comboBox_ins_ven_cliente.ValueMember = "id";
            comboBox_vis_gen_informacion_por_finca.ValueMember = "id";
            comboBox_ins_mov_tipo.ValueMember = "id";
            comboBox_act_mov_concepto.ValueMember = "id";
            comboBox_act_mov_finca_destino.ValueMember = "id";
            comboBox_act_mov_finca_origen.ValueMember = "id";
            comboBox_act_com_finca.ValueMember = "id";
            comboBox_act_com_proveedor.ValueMember = "id";
            comboBox_act_ven_finca.ValueMember = "id";
            comboBox_act_ven_cliente.ValueMember = "id";

            //0:finca, 1:concepto, 2: proveedor, 3: cliente, 7: tipo
            comboBox_ins_mov_concepto.DataSource = tables[1].Copy();
            comboBox_ins_mov_finca_destino.DataSource = tables[0].Copy();
            comboBox_ins_mov_finca_origen.DataSource = tables[0].Copy();
            comboBox_ins_com_finca.DataSource = tables[0].Copy();
            comboBox_ins_com_proveedor.DataSource = tables[2].Copy();
            comboBox_ins_ven_finca.DataSource = tables[0].Copy();
            comboBox_ins_ven_cliente.DataSource = tables[3].Copy();
            comboBox_vis_gen_informacion_por_finca.DataSource = tables[0].Copy();
            comboBox_ins_mov_tipo.DataSource = tables[7].Copy();
            comboBox_act_mov_concepto.DataSource = tables[1].Copy();
            comboBox_act_mov_finca_destino.DataSource = tables[0].Copy();
            comboBox_act_mov_finca_origen.DataSource = tables[0].Copy();
            comboBox_act_com_finca.DataSource = tables[0].Copy();
            comboBox_act_com_proveedor.DataSource = tables[2].Copy();
            comboBox_act_ven_finca.DataSource = tables[0].Copy();
            comboBox_act_ven_cliente.DataSource = tables[3].Copy();

            dataGridView_general.DataSource = tables[4];

            dataGridView_vis_com.DataSource = tables[5];
            dataGridView_vis_ven.DataSource = tables[6];
        }

        public void button_vis_actualizar_información_Response(List<DataTable> tables)
        {
            //1 general, 2 compra, 3 venta
            dataGridView_general.DataSource = tables[0];
            dataGridView_vis_com.DataSource = tables[1];
            dataGridView_vis_ven.DataSource = tables[2];

        }
        public void ShowAnimalPorFincaView(DataTable table)
        {
            dataGridView_por_finca.DataSource = table;
        }

        public void button_act_mov_id_movimiento_Response(Movimiento myMovimiento)
        {
            labbel_act_mov_chapeta.Text = myMovimiento.Chapeta;
            comboBox_act_mov_concepto.SelectedValue = myMovimiento.Concepto;
            dateTimePicker_act_mov_fecha.Value = myMovimiento.Fecha;
            comboBox_act_mov_finca_origen.SelectedValue = myMovimiento.FincaOrigen;
            comboBox_act_mov_finca_destino.SelectedValue = myMovimiento.FincaDestino;
            textBox_act_mov_peso_origen.Text = myMovimiento.PesoOrigen.ToString();
            textBox_act_mov_peso_destino.Text = myMovimiento.PesoDestino.ToString();
        }

        public void button_act_com_id_compra_Response(Compra myCompra)
        {
            comboBox_act_com_finca.SelectedValue = myCompra.Finca;
            comboBox_act_com_proveedor.SelectedValue = myCompra.IdProveedor;
            dateTimePicker_act_com_fecha.Value = myCompra.Fecha;
            textBox_act_com_peso_despacho.Text = myCompra.PesoDespacho.ToString();
            textBox_act_com_factura.Text = myCompra.Factura;
        }

        public void button_act_com_id_venta_Response(Venta myVenta)
        {
            comboBox_act_ven_finca.SelectedValue = myVenta.Finca;
            comboBox_act_ven_cliente.SelectedValue = myVenta.IdCliente;
            textBox_act_ven_peso_despacho.Text = myVenta.PesoDespacho.ToString();
            textBox_act_ven_factura.Text = myVenta.Factura;
        }
    }
}
