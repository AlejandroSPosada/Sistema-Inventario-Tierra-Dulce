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
        public void ShowAnimalPorFincaView(DataTable table)
        {
            dataGridView_por_finca.DataSource = table;
        }
    }
}
