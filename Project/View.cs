using System;
using System.Collections.Specialized;
using System.Data;
using System.Numerics;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // If you have issues, switch to System.Data.SqlClient
using Project.ModelLayer;
using Project.PresenterLayer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;


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

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowConfirmation(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public string AskForInput(string message)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(message, "User Input", "");
        }

        public int AskForIntInput(string message)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(message, "User Input", "");
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Invalid input. Defaulting to 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
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
            int PesoOrigen1 = 0;
            int PesoDestino1 = 0;
            try
            {
                PesoOrigen1 = Convert.ToInt32(textBox_ins_mov_peso_origen.Text);
            }
            catch (FormatException)
            {
                this.ShowMessage("Peso invalido.");
                return;
            }
            try
            {
                PesoDestino1 = Convert.ToInt32(textBox_ins_mov_peso_destino.Text);
            }
            catch (FormatException)
            {
                this.ShowMessage("Peso invalido.");
                return;
            }
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
            int peso = 0;
            try
            {
                peso = Convert.ToInt32(textBox_ins_com_peso_despacho.Text);
            }
            catch (FormatException)
            {
                this.ShowMessage("Peso invalido.");
                return;
            }
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
            int peso = 0;
            try
            {
                peso = Convert.ToInt32(textBox_ins_ven_peso_despacho.Text);
            }
            catch (FormatException)
            {
                this.ShowMessage("Peso invalido.");
                return;
            }
            this.ShowMessage(clienteId);
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
            string connectionString = @"Data Source=(localdb)\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
            string query = "SELECT * FROM movimiento WHERE id = @id";
            int idMovimiento = Convert.ToInt32(textBox_act_mov_id_movimiento.Text);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idMovimiento);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show($"No se encontró un movimiento con ID {idMovimiento}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            if (reader.Read())
                            {
                                textBox_act_mov_chapeta.Text = reader["id_animal"].ToString();
                                comboBox_act_mov_concepto.Text = reader["id_concepto"].ToString();
                                dateTimePicker_act_mov_fecha.Value = Convert.ToDateTime(reader["fecha"]);
                                comboBox_act_mov_finca_origen.Text = reader["id_finca_origen"].ToString();
                                comboBox_act_mov_finca_destino.Text = reader["id_finca_destino"].ToString();
                                textBox_act_mov_peso_origen.Text = reader["peso_origen"] != DBNull.Value ? reader["peso_origen"].ToString() : "";
                                textBox_act_mov_peso_destino.Text = reader["peso_destino"] != DBNull.Value ? reader["peso_destino"].ToString() : "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recuperar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_act_com_id_compra_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
            string query = "SELECT * FROM compra WHERE id = @id";
            int idMovimiento = Convert.ToInt32(textBox_act_com_id_compra.Text);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idMovimiento);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show($"No se encontró una compra con ID {idMovimiento}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            if (reader.Read())
                            {
                                comboBox_act_com_finca.Text = reader["id_finca"].ToString();
                                comboBox_act_com_proveedor.Text = reader["id_proveedor"].ToString();
                                dateTimePicker_act_com_fecha.Value = Convert.ToDateTime(reader["fecha"]);
                                textBox_act_com_peso_despacho.Text = reader["peso_despacho"] != DBNull.Value ? reader["peso_despacho"].ToString() : "";
                                textBox_act_com_factura.Text = reader["factura"] != DBNull.Value ? reader["factura"].ToString() : "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recuperar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_act_com_id_venta_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\sis_inv;Initial Catalog=sis_inv_database;Integrated Security=True;";
            string query = "SELECT * FROM venta WHERE id = @id";
            int idVenta = Convert.ToInt32(textBox1.Text);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idVenta);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show($"No se encontró una venta con ID {idVenta}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            if (reader.Read())
                            {
                                comboBox_act_ven_finca.Text = reader["id_finca"].ToString();
                                comboBox_act_ven_cliente.Text = reader["id_cliente"].ToString();
                                dateTimePicker_act_ven_fecha.Value = Convert.ToDateTime(reader["fecha"]);
                                textBox_act_ven_peso_despacho.Text = reader["peso_despacho"] != DBNull.Value ? reader["peso_despacho"].ToString() : "";
                                textBox_act_ven_factura.Text = reader["factura"] != DBNull.Value ? reader["factura"].ToString() : "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recuperar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
