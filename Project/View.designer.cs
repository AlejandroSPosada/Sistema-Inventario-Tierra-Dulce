﻿namespace View
{
    partial class View1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View1));
            tabControl1 = new TabControl();
            tab_insertar = new TabPage();
            tabControl2 = new TabControl();
            tab_movimiento = new TabPage();
            comboBox_ins_mov_concepto = new ComboBox();
            comboBox_ins_mov_finca_destino = new ComboBox();
            comboBox_ins_mov_finca_origen = new ComboBox();
            label_mov_pes_des = new Label();
            textBox_ins_mov_peso_destino = new TextBox();
            button_ins_mov = new Button();
            textBox_ins_mov_peso_origen = new TextBox();
            label_tittle_movimiento = new Label();
            label_mov_pes_ori = new Label();
            dateTimePicker_ins_mov_fecha = new DateTimePicker();
            label_mov_fin_des = new Label();
            label_mov_con = new Label();
            label_mov_fec = new Label();
            textBox_ins_mov_chapeta = new TextBox();
            label_mov_cha = new Label();
            label_mov_fin_ori = new Label();
            tab_compra = new TabPage();
            textBox4 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            textBox7 = new TextBox();
            comboBox_ins_com_finca = new ComboBox();
            comboBox_ins_com_proveedor = new ComboBox();
            button1 = new Button();
            label_tittle_compra = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label_com_fin = new Label();
            label_com_des = new Label();
            tab_venta = new TabPage();
            comboBox_ins_ven_finca = new ComboBox();
            comboBox_ins_ven_cliente = new ComboBox();
            textBox2 = new TextBox();
            dateTimePicker_ = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label21 = new Label();
            label25 = new Label();
            button5 = new Button();
            label_tittle_venta = new Label();
            tab_visualizar = new TabPage();
            tabControl_vis_ven = new TabControl();
            tab_general = new TabPage();
            dataGridView_por_finca = new DataGridView();
            comboBox_vis_gen_informacion_por_finca = new ComboBox();
            label28 = new Label();
            label26 = new Label();
            dataGridView_general = new DataGridView();
            tabPage4 = new TabPage();
            button_vis_mov_chapeta = new Button();
            label_vis_mov_chapeta = new Label();
            textBox_vis_mov_chapeta = new TextBox();
            label_vis_mov_MOVIMIENTO = new Label();
            dataGridView_vis_mov = new DataGridView();
            tabPage5 = new TabPage();
            dataGridView_vis_com = new DataGridView();
            label_vis_com_COMPRA = new Label();
            tabPage6 = new TabPage();
            dataGridView_vis_ven = new DataGridView();
            label45 = new Label();
            tab_actualizar = new TabPage();
            tabControl3 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            textBox12 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            dateTimePicker4 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            textBox17 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox18 = new TextBox();
            dateTimePicker5 = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            tabPage3 = new TabPage();
            label17 = new Label();
            button4 = new Button();
            textBox21 = new TextBox();
            label18 = new Label();
            textBox22 = new TextBox();
            label19 = new Label();
            dateTimePicker6 = new DateTimePicker();
            label20 = new Label();
            tab_extraer = new TabPage();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tab_insertar.SuspendLayout();
            tabControl2.SuspendLayout();
            tab_movimiento.SuspendLayout();
            tab_compra.SuspendLayout();
            tab_venta.SuspendLayout();
            tab_visualizar.SuspendLayout();
            tabControl_vis_ven.SuspendLayout();
            tab_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_por_finca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_general).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_vis_mov).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_vis_com).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_vis_ven).BeginInit();
            tab_actualizar.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_insertar);
            tabControl1.Controls.Add(tab_visualizar);
            tabControl1.Controls.Add(tab_actualizar);
            tabControl1.Controls.Add(tab_extraer);
            tabControl1.Location = new Point(40, 95);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(994, 727);
            tabControl1.TabIndex = 1;
            // 
            // tab_insertar
            // 
            tab_insertar.Controls.Add(tabControl2);
            tab_insertar.Location = new Point(4, 29);
            tab_insertar.Name = "tab_insertar";
            tab_insertar.Padding = new Padding(3);
            tab_insertar.Size = new Size(986, 694);
            tab_insertar.TabIndex = 0;
            tab_insertar.Text = "insertar";
            tab_insertar.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tab_movimiento);
            tabControl2.Controls.Add(tab_compra);
            tabControl2.Controls.Add(tab_venta);
            tabControl2.Location = new Point(228, 9);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(544, 682);
            tabControl2.TabIndex = 0;
            // 
            // tab_movimiento
            // 
            tab_movimiento.Controls.Add(comboBox_ins_mov_concepto);
            tab_movimiento.Controls.Add(comboBox_ins_mov_finca_destino);
            tab_movimiento.Controls.Add(comboBox_ins_mov_finca_origen);
            tab_movimiento.Controls.Add(label_mov_pes_des);
            tab_movimiento.Controls.Add(textBox_ins_mov_peso_destino);
            tab_movimiento.Controls.Add(button_ins_mov);
            tab_movimiento.Controls.Add(textBox_ins_mov_peso_origen);
            tab_movimiento.Controls.Add(label_tittle_movimiento);
            tab_movimiento.Controls.Add(label_mov_pes_ori);
            tab_movimiento.Controls.Add(dateTimePicker_ins_mov_fecha);
            tab_movimiento.Controls.Add(label_mov_fin_des);
            tab_movimiento.Controls.Add(label_mov_con);
            tab_movimiento.Controls.Add(label_mov_fec);
            tab_movimiento.Controls.Add(textBox_ins_mov_chapeta);
            tab_movimiento.Controls.Add(label_mov_cha);
            tab_movimiento.Controls.Add(label_mov_fin_ori);
            tab_movimiento.Location = new Point(4, 29);
            tab_movimiento.Name = "tab_movimiento";
            tab_movimiento.Padding = new Padding(3);
            tab_movimiento.Size = new Size(536, 649);
            tab_movimiento.TabIndex = 0;
            tab_movimiento.Text = "movimient";
            tab_movimiento.UseVisualStyleBackColor = true;
            // 
            // comboBox_ins_mov_concepto
            // 
            comboBox_ins_mov_concepto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_mov_concepto.FormattingEnabled = true;
            comboBox_ins_mov_concepto.Location = new Point(189, 137);
            comboBox_ins_mov_concepto.Name = "comboBox_ins_mov_concepto";
            comboBox_ins_mov_concepto.Size = new Size(262, 28);
            comboBox_ins_mov_concepto.TabIndex = 36;
            // 
            // comboBox_ins_mov_finca_destino
            // 
            comboBox_ins_mov_finca_destino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_mov_finca_destino.FormattingEnabled = true;
            comboBox_ins_mov_finca_destino.Location = new Point(189, 311);
            comboBox_ins_mov_finca_destino.Name = "comboBox_ins_mov_finca_destino";
            comboBox_ins_mov_finca_destino.Size = new Size(262, 28);
            comboBox_ins_mov_finca_destino.TabIndex = 35;
            // 
            // comboBox_ins_mov_finca_origen
            // 
            comboBox_ins_mov_finca_origen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_mov_finca_origen.FormattingEnabled = true;
            comboBox_ins_mov_finca_origen.Location = new Point(189, 254);
            comboBox_ins_mov_finca_origen.Name = "comboBox_ins_mov_finca_origen";
            comboBox_ins_mov_finca_origen.Size = new Size(262, 28);
            comboBox_ins_mov_finca_origen.TabIndex = 34;
            // 
            // label_mov_pes_des
            // 
            label_mov_pes_des.AutoSize = true;
            label_mov_pes_des.Location = new Point(68, 425);
            label_mov_pes_des.Name = "label_mov_pes_des";
            label_mov_pes_des.Size = new Size(94, 20);
            label_mov_pes_des.TabIndex = 18;
            label_mov_pes_des.Text = "peso destino";
            // 
            // textBox_ins_mov_peso_destino
            // 
            textBox_ins_mov_peso_destino.Location = new Point(189, 422);
            textBox_ins_mov_peso_destino.Name = "textBox_ins_mov_peso_destino";
            textBox_ins_mov_peso_destino.Size = new Size(262, 27);
            textBox_ins_mov_peso_destino.TabIndex = 17;
            // 
            // button_ins_mov
            // 
            button_ins_mov.Location = new Point(238, 486);
            button_ins_mov.Name = "button_ins_mov";
            button_ins_mov.Size = new Size(94, 29);
            button_ins_mov.TabIndex = 15;
            button_ins_mov.Text = "insertar";
            button_ins_mov.UseVisualStyleBackColor = true;
            button_ins_mov.Click += button_insertar1_Click;
            // 
            // textBox_ins_mov_peso_origen
            // 
            textBox_ins_mov_peso_origen.Location = new Point(189, 365);
            textBox_ins_mov_peso_origen.Name = "textBox_ins_mov_peso_origen";
            textBox_ins_mov_peso_origen.Size = new Size(262, 27);
            textBox_ins_mov_peso_origen.TabIndex = 14;
            // 
            // label_tittle_movimiento
            // 
            label_tittle_movimiento.AutoSize = true;
            label_tittle_movimiento.Location = new Point(232, 38);
            label_tittle_movimiento.Name = "label_tittle_movimiento";
            label_tittle_movimiento.Size = new Size(100, 20);
            label_tittle_movimiento.TabIndex = 0;
            label_tittle_movimiento.Text = "MOVIMIENTO";
            // 
            // label_mov_pes_ori
            // 
            label_mov_pes_ori.AutoSize = true;
            label_mov_pes_ori.Location = new Point(71, 368);
            label_mov_pes_ori.Name = "label_mov_pes_ori";
            label_mov_pes_ori.Size = new Size(88, 20);
            label_mov_pes_ori.TabIndex = 13;
            label_mov_pes_ori.Text = "peso origen";
            // 
            // dateTimePicker_ins_mov_fecha
            // 
            dateTimePicker_ins_mov_fecha.Location = new Point(189, 194);
            dateTimePicker_ins_mov_fecha.Name = "dateTimePicker_ins_mov_fecha";
            dateTimePicker_ins_mov_fecha.Size = new Size(262, 27);
            dateTimePicker_ins_mov_fecha.TabIndex = 12;
            // 
            // label_mov_fin_des
            // 
            label_mov_fin_des.AutoSize = true;
            label_mov_fin_des.Location = new Point(68, 311);
            label_mov_fin_des.Name = "label_mov_fin_des";
            label_mov_fin_des.Size = new Size(94, 20);
            label_mov_fin_des.TabIndex = 7;
            label_mov_fin_des.Text = "finca destino";
            // 
            // label_mov_con
            // 
            label_mov_con.AutoSize = true;
            label_mov_con.Location = new Point(80, 140);
            label_mov_con.Name = "label_mov_con";
            label_mov_con.Size = new Size(71, 20);
            label_mov_con.TabIndex = 3;
            label_mov_con.Text = "concepto";
            // 
            // label_mov_fec
            // 
            label_mov_fec.AutoSize = true;
            label_mov_fec.Location = new Point(93, 197);
            label_mov_fec.Name = "label_mov_fec";
            label_mov_fec.Size = new Size(45, 20);
            label_mov_fec.TabIndex = 11;
            label_mov_fec.Text = "fecha";
            // 
            // textBox_ins_mov_chapeta
            // 
            textBox_ins_mov_chapeta.Location = new Point(189, 80);
            textBox_ins_mov_chapeta.Name = "textBox_ins_mov_chapeta";
            textBox_ins_mov_chapeta.Size = new Size(262, 27);
            textBox_ins_mov_chapeta.TabIndex = 1;
            // 
            // label_mov_cha
            // 
            label_mov_cha.AutoSize = true;
            label_mov_cha.Location = new Point(84, 83);
            label_mov_cha.Name = "label_mov_cha";
            label_mov_cha.Size = new Size(62, 20);
            label_mov_cha.TabIndex = 2;
            label_mov_cha.Text = "chapeta";
            // 
            // label_mov_fin_ori
            // 
            label_mov_fin_ori.AutoSize = true;
            label_mov_fin_ori.Location = new Point(71, 254);
            label_mov_fin_ori.Name = "label_mov_fin_ori";
            label_mov_fin_ori.Size = new Size(88, 20);
            label_mov_fin_ori.TabIndex = 9;
            label_mov_fin_ori.Text = "finca origen";
            // 
            // tab_compra
            // 
            tab_compra.Controls.Add(textBox4);
            tab_compra.Controls.Add(dateTimePicker3);
            tab_compra.Controls.Add(textBox7);
            tab_compra.Controls.Add(comboBox_ins_com_finca);
            tab_compra.Controls.Add(comboBox_ins_com_proveedor);
            tab_compra.Controls.Add(button1);
            tab_compra.Controls.Add(label_tittle_compra);
            tab_compra.Controls.Add(label22);
            tab_compra.Controls.Add(label23);
            tab_compra.Controls.Add(label24);
            tab_compra.Controls.Add(label_com_fin);
            tab_compra.Controls.Add(label_com_des);
            tab_compra.Location = new Point(4, 29);
            tab_compra.Name = "tab_compra";
            tab_compra.Padding = new Padding(3);
            tab_compra.Size = new Size(536, 649);
            tab_compra.TabIndex = 1;
            tab_compra.Text = "compra";
            tab_compra.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(202, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(262, 27);
            textBox4.TabIndex = 43;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(202, 203);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(262, 27);
            dateTimePicker3.TabIndex = 45;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(202, 260);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(262, 27);
            textBox7.TabIndex = 44;
            // 
            // comboBox_ins_com_finca
            // 
            comboBox_ins_com_finca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_com_finca.FormattingEnabled = true;
            comboBox_ins_com_finca.Location = new Point(202, 89);
            comboBox_ins_com_finca.Name = "comboBox_ins_com_finca";
            comboBox_ins_com_finca.Size = new Size(262, 28);
            comboBox_ins_com_finca.TabIndex = 34;
            // 
            // comboBox_ins_com_proveedor
            // 
            comboBox_ins_com_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_com_proveedor.FormattingEnabled = true;
            comboBox_ins_com_proveedor.Location = new Point(202, 147);
            comboBox_ins_com_proveedor.Name = "comboBox_ins_com_proveedor";
            comboBox_ins_com_proveedor.Size = new Size(262, 28);
            comboBox_ins_com_proveedor.TabIndex = 33;
            // 
            // button1
            // 
            button1.Location = new Point(231, 380);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 32;
            button1.Text = "insertar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label_tittle_compra
            // 
            label_tittle_compra.AutoSize = true;
            label_tittle_compra.Location = new Point(241, 32);
            label_tittle_compra.Name = "label_tittle_compra";
            label_tittle_compra.Size = new Size(69, 20);
            label_tittle_compra.TabIndex = 19;
            label_tittle_compra.Text = "COMPRA";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(87, 317);
            label22.Name = "label22";
            label22.Size = new Size(55, 20);
            label22.TabIndex = 25;
            label22.Text = "factura";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(75, 146);
            label23.Name = "label23";
            label23.Size = new Size(78, 20);
            label23.TabIndex = 22;
            label23.Text = "proveedor";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(92, 203);
            label24.Name = "label24";
            label24.Size = new Size(45, 20);
            label24.TabIndex = 28;
            label24.Text = "fecha";
            // 
            // label_com_fin
            // 
            label_com_fin.AutoSize = true;
            label_com_fin.Location = new Point(94, 89);
            label_com_fin.Name = "label_com_fin";
            label_com_fin.Size = new Size(41, 20);
            label_com_fin.TabIndex = 21;
            label_com_fin.Text = "finca";
            // 
            // label_com_des
            // 
            label_com_des.AutoSize = true;
            label_com_des.Location = new Point(60, 260);
            label_com_des.Name = "label_com_des";
            label_com_des.Size = new Size(109, 20);
            label_com_des.TabIndex = 27;
            label_com_des.Text = "peso despacho";
            // 
            // tab_venta
            // 
            tab_venta.Controls.Add(comboBox_ins_ven_finca);
            tab_venta.Controls.Add(comboBox_ins_ven_cliente);
            tab_venta.Controls.Add(textBox2);
            tab_venta.Controls.Add(dateTimePicker_);
            tab_venta.Controls.Add(label1);
            tab_venta.Controls.Add(label2);
            tab_venta.Controls.Add(label3);
            tab_venta.Controls.Add(textBox3);
            tab_venta.Controls.Add(label21);
            tab_venta.Controls.Add(label25);
            tab_venta.Controls.Add(button5);
            tab_venta.Controls.Add(label_tittle_venta);
            tab_venta.Location = new Point(4, 29);
            tab_venta.Name = "tab_venta";
            tab_venta.Size = new Size(536, 649);
            tab_venta.TabIndex = 2;
            tab_venta.Text = "venta";
            tab_venta.UseVisualStyleBackColor = true;
            // 
            // comboBox_ins_ven_finca
            // 
            comboBox_ins_ven_finca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_ven_finca.FormattingEnabled = true;
            comboBox_ins_ven_finca.Location = new Point(202, 77);
            comboBox_ins_ven_finca.Name = "comboBox_ins_ven_finca";
            comboBox_ins_ven_finca.Size = new Size(262, 28);
            comboBox_ins_ven_finca.TabIndex = 44;
            // 
            // comboBox_ins_ven_cliente
            // 
            comboBox_ins_ven_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ins_ven_cliente.FormattingEnabled = true;
            comboBox_ins_ven_cliente.Location = new Point(202, 135);
            comboBox_ins_ven_cliente.Name = "comboBox_ins_ven_cliente";
            comboBox_ins_ven_cliente.Size = new Size(262, 28);
            comboBox_ins_ven_cliente.TabIndex = 43;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 27);
            textBox2.TabIndex = 37;
            // 
            // dateTimePicker_
            // 
            dateTimePicker_.Location = new Point(202, 188);
            dateTimePicker_.Name = "dateTimePicker_";
            dateTimePicker_.Size = new Size(262, 27);
            dateTimePicker_.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 305);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 38;
            label1.Text = "factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 134);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 36;
            label2.Text = "cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 191);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 41;
            label3.Text = "fecha";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 27);
            textBox3.TabIndex = 39;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(94, 77);
            label21.Name = "label21";
            label21.Size = new Size(41, 20);
            label21.TabIndex = 35;
            label21.Text = "finca";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(60, 248);
            label25.Name = "label25";
            label25.Size = new Size(109, 20);
            label25.TabIndex = 40;
            label25.Text = "peso despacho";
            // 
            // button5
            // 
            button5.Location = new Point(225, 367);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 32;
            button5.Text = "insertar";
            button5.UseVisualStyleBackColor = true;
            // 
            // label_tittle_venta
            // 
            label_tittle_venta.AutoSize = true;
            label_tittle_venta.Location = new Point(241, 32);
            label_tittle_venta.Name = "label_tittle_venta";
            label_tittle_venta.Size = new Size(54, 20);
            label_tittle_venta.TabIndex = 19;
            label_tittle_venta.Text = "VENTA";
            // 
            // tab_visualizar
            // 
            tab_visualizar.Controls.Add(tabControl_vis_ven);
            tab_visualizar.Location = new Point(4, 29);
            tab_visualizar.Name = "tab_visualizar";
            tab_visualizar.Padding = new Padding(3);
            tab_visualizar.Size = new Size(986, 694);
            tab_visualizar.TabIndex = 1;
            tab_visualizar.Text = "visualizar";
            tab_visualizar.UseVisualStyleBackColor = true;
            // 
            // tabControl_vis_ven
            // 
            tabControl_vis_ven.Controls.Add(tab_general);
            tabControl_vis_ven.Controls.Add(tabPage4);
            tabControl_vis_ven.Controls.Add(tabPage5);
            tabControl_vis_ven.Controls.Add(tabPage6);
            tabControl_vis_ven.Location = new Point(6, 9);
            tabControl_vis_ven.Name = "tabControl_vis_ven";
            tabControl_vis_ven.SelectedIndex = 0;
            tabControl_vis_ven.Size = new Size(974, 679);
            tabControl_vis_ven.TabIndex = 1;
            // 
            // tab_general
            // 
            tab_general.AutoScroll = true;
            tab_general.AutoScrollMargin = new Size(0, 50);
            tab_general.Controls.Add(dataGridView_por_finca);
            tab_general.Controls.Add(comboBox_vis_gen_informacion_por_finca);
            tab_general.Controls.Add(label28);
            tab_general.Controls.Add(label26);
            tab_general.Controls.Add(dataGridView_general);
            tab_general.Location = new Point(4, 29);
            tab_general.Name = "tab_general";
            tab_general.Size = new Size(966, 646);
            tab_general.TabIndex = 3;
            tab_general.Text = "general";
            tab_general.UseVisualStyleBackColor = true;
            // 
            // dataGridView_por_finca
            // 
            dataGridView_por_finca.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_por_finca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_por_finca.Location = new Point(84, 576);
            dataGridView_por_finca.Name = "dataGridView_por_finca";
            dataGridView_por_finca.RowHeadersWidth = 51;
            dataGridView_por_finca.Size = new Size(818, 579);
            dataGridView_por_finca.TabIndex = 38;
            // 
            // comboBox_vis_gen_informacion_por_finca
            // 
            comboBox_vis_gen_informacion_por_finca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_vis_gen_informacion_por_finca.Location = new Point(372, 517);
            comboBox_vis_gen_informacion_por_finca.Name = "comboBox_vis_gen_informacion_por_finca";
            comboBox_vis_gen_informacion_por_finca.Size = new Size(232, 28);
            comboBox_vis_gen_informacion_por_finca.TabIndex = 37;
            comboBox_vis_gen_informacion_por_finca.SelectedIndexChanged += comboBox_vis_gen_informacion_por_finca_SelectedIndexChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(399, 479);
            label28.Name = "label28";
            label28.Size = new Size(190, 20);
            label28.TabIndex = 2;
            label28.Text = "INFORMACIÓN  POR FINCA";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(442, 47);
            label26.Name = "label26";
            label26.Size = new Size(72, 20);
            label26.TabIndex = 1;
            label26.Text = "GENERAL";
            // 
            // dataGridView_general
            // 
            dataGridView_general.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_general.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_general.Location = new Point(84, 90);
            dataGridView_general.Name = "dataGridView_general";
            dataGridView_general.RowHeadersWidth = 51;
            dataGridView_general.Size = new Size(818, 365);
            dataGridView_general.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button_vis_mov_chapeta);
            tabPage4.Controls.Add(label_vis_mov_chapeta);
            tabPage4.Controls.Add(textBox_vis_mov_chapeta);
            tabPage4.Controls.Add(label_vis_mov_MOVIMIENTO);
            tabPage4.Controls.Add(dataGridView_vis_mov);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(966, 646);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "movimient";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_vis_mov_chapeta
            // 
            button_vis_mov_chapeta.Location = new Point(676, 95);
            button_vis_mov_chapeta.Name = "button_vis_mov_chapeta";
            button_vis_mov_chapeta.Size = new Size(94, 29);
            button_vis_mov_chapeta.TabIndex = 5;
            button_vis_mov_chapeta.Text = "buscar";
            button_vis_mov_chapeta.UseVisualStyleBackColor = true;
            button_vis_mov_chapeta.Click += button_vis_mov_chapeta_Click;
            // 
            // label_vis_mov_chapeta
            // 
            label_vis_mov_chapeta.AutoSize = true;
            label_vis_mov_chapeta.Location = new Point(294, 98);
            label_vis_mov_chapeta.Name = "label_vis_mov_chapeta";
            label_vis_mov_chapeta.Size = new Size(62, 20);
            label_vis_mov_chapeta.TabIndex = 4;
            label_vis_mov_chapeta.Text = "chapeta";
            // 
            // textBox_vis_mov_chapeta
            // 
            textBox_vis_mov_chapeta.Location = new Point(385, 95);
            textBox_vis_mov_chapeta.Name = "textBox_vis_mov_chapeta";
            textBox_vis_mov_chapeta.Size = new Size(262, 27);
            textBox_vis_mov_chapeta.TabIndex = 3;
            // 
            // label_vis_mov_MOVIMIENTO
            // 
            label_vis_mov_MOVIMIENTO.AutoSize = true;
            label_vis_mov_MOVIMIENTO.Location = new Point(452, 38);
            label_vis_mov_MOVIMIENTO.Name = "label_vis_mov_MOVIMIENTO";
            label_vis_mov_MOVIMIENTO.Size = new Size(100, 20);
            label_vis_mov_MOVIMIENTO.TabIndex = 2;
            label_vis_mov_MOVIMIENTO.Text = "MOVIMIENTO";
            // 
            // dataGridView_vis_mov
            // 
            dataGridView_vis_mov.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_vis_mov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_vis_mov.Location = new Point(90, 183);
            dataGridView_vis_mov.Name = "dataGridView_vis_mov";
            dataGridView_vis_mov.RowHeadersWidth = 51;
            dataGridView_vis_mov.Size = new Size(818, 365);
            dataGridView_vis_mov.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridView_vis_com);
            tabPage5.Controls.Add(label_vis_com_COMPRA);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(966, 646);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "compra";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView_vis_com
            // 
            dataGridView_vis_com.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_vis_com.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_vis_com.Location = new Point(83, 94);
            dataGridView_vis_com.Name = "dataGridView_vis_com";
            dataGridView_vis_com.RowHeadersWidth = 51;
            dataGridView_vis_com.Size = new Size(818, 365);
            dataGridView_vis_com.TabIndex = 20;
            // 
            // label_vis_com_COMPRA
            // 
            label_vis_com_COMPRA.AutoSize = true;
            label_vis_com_COMPRA.Location = new Point(457, 44);
            label_vis_com_COMPRA.Name = "label_vis_com_COMPRA";
            label_vis_com_COMPRA.Size = new Size(69, 20);
            label_vis_com_COMPRA.TabIndex = 19;
            label_vis_com_COMPRA.Text = "COMPRA";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridView_vis_ven);
            tabPage6.Controls.Add(label45);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(966, 646);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "venta";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView_vis_ven
            // 
            dataGridView_vis_ven.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_vis_ven.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_vis_ven.Location = new Point(93, 91);
            dataGridView_vis_ven.Name = "dataGridView_vis_ven";
            dataGridView_vis_ven.RowHeadersWidth = 51;
            dataGridView_vis_ven.Size = new Size(818, 365);
            dataGridView_vis_ven.TabIndex = 20;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(457, 36);
            label45.Name = "label45";
            label45.Size = new Size(54, 20);
            label45.TabIndex = 19;
            label45.Text = "VENTA";
            // 
            // tab_actualizar
            // 
            tab_actualizar.Controls.Add(tabControl3);
            tab_actualizar.Location = new Point(4, 29);
            tab_actualizar.Name = "tab_actualizar";
            tab_actualizar.Size = new Size(986, 694);
            tab_actualizar.TabIndex = 3;
            tab_actualizar.Text = "actualizar";
            tab_actualizar.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage1);
            tabControl3.Controls.Add(tabPage2);
            tabControl3.Controls.Add(tabPage3);
            tabControl3.Location = new Point(6, 6);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(544, 685);
            tabControl3.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox12);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox13);
            tabPage1.Controls.Add(textBox14);
            tabPage1.Controls.Add(dateTimePicker4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox15);
            tabPage1.Controls.Add(textBox16);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label10);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(536, 652);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ingreso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(232, 426);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "insertar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(189, 365);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(262, 27);
            textBox12.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 41);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "INGRESO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 371);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "peso";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(189, 194);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(262, 27);
            textBox13.TabIndex = 6;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(189, 137);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(262, 27);
            textBox14.TabIndex = 4;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(189, 308);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(262, 27);
            dateTimePicker4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 200);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 7;
            label6.Text = "factura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 143);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 3;
            label7.Text = "concepto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 316);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 11;
            label8.Text = "fecha";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(189, 251);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(262, 27);
            textBox15.TabIndex = 8;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(189, 80);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(262, 27);
            textBox16.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(94, 86);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 2;
            label9.Text = "chapeta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(105, 257);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 9;
            label10.Text = "finca";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox17);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBox18);
            tabPage2.Controls.Add(dateTimePicker5);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox19);
            tabPage2.Controls.Add(textBox20);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(536, 652);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "salida";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(213, 362);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 29;
            button3.Text = "insertar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(183, 302);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(262, 27);
            textBox17.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(241, 40);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 16;
            label11.Text = "SALIDA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(99, 308);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 27;
            label12.Text = "peso";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(183, 134);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(262, 27);
            textBox18.TabIndex = 20;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(183, 246);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(262, 27);
            dateTimePicker5.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(84, 141);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 19;
            label13.Text = "concepto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(97, 254);
            label14.Name = "label14";
            label14.Size = new Size(45, 20);
            label14.TabIndex = 25;
            label14.Text = "fecha";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(183, 190);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(262, 27);
            textBox19.TabIndex = 23;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(183, 78);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(262, 27);
            textBox20.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(88, 84);
            label15.Name = "label15";
            label15.Size = new Size(62, 20);
            label15.TabIndex = 18;
            label15.Text = "chapeta";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(99, 196);
            label16.Name = "label16";
            label16.Size = new Size(41, 20);
            label16.TabIndex = 24;
            label16.Text = "finca";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(textBox21);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(textBox22);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(dateTimePicker6);
            tabPage3.Controls.Add(label20);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(536, 652);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "peso despacho";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(205, 36);
            label17.Name = "label17";
            label17.Size = new Size(123, 20);
            label17.TabIndex = 36;
            label17.Text = "PESO DESPACHO";
            // 
            // button4
            // 
            button4.Location = new Point(224, 255);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 35;
            button4.Text = "insertar";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(173, 82);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(262, 27);
            textBox21.TabIndex = 33;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(86, 85);
            label18.Name = "label18";
            label18.Size = new Size(41, 20);
            label18.TabIndex = 34;
            label18.Text = "finca";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(173, 192);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(262, 27);
            textBox22.TabIndex = 32;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(86, 195);
            label19.Name = "label19";
            label19.Size = new Size(41, 20);
            label19.TabIndex = 31;
            label19.Text = "peso";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(173, 137);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(262, 27);
            dateTimePicker6.TabIndex = 30;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(84, 141);
            label20.Name = "label20";
            label20.Size = new Size(45, 20);
            label20.TabIndex = 29;
            label20.Text = "fecha";
            // 
            // tab_extraer
            // 
            tab_extraer.Location = new Point(4, 29);
            tab_extraer.Name = "tab_extraer";
            tab_extraer.Size = new Size(986, 694);
            tab_extraer.TabIndex = 2;
            tab_extraer.Text = "extraer";
            tab_extraer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(994, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // View1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1068, 834);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "View1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Inventario";
            tabControl1.ResumeLayout(false);
            tab_insertar.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tab_movimiento.ResumeLayout(false);
            tab_movimiento.PerformLayout();
            tab_compra.ResumeLayout(false);
            tab_compra.PerformLayout();
            tab_venta.ResumeLayout(false);
            tab_venta.PerformLayout();
            tab_visualizar.ResumeLayout(false);
            tabControl_vis_ven.ResumeLayout(false);
            tab_general.ResumeLayout(false);
            tab_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_por_finca).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_general).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_vis_mov).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_vis_com).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_vis_ven).EndInit();
            tab_actualizar.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tab_insertar;
        private TabPage tab_visualizar;
        private TabPage tab_extraer;
        private TabPage tab_actualizar;
        private Label label_mov_con;
        private Label label_mov_cha;
        private TextBox textBox_ins_mov_chapeta;
        private TextBox textBox_ins_mov_peso_origen;
        private Label label_mov_pes_ori;
        private DateTimePicker dateTimePicker_ins_mov_fecha;
        private Label label_mov_fec;
        private Label label_mov_fin_ori;
        private Label label_mov_fin_des;
        private TabControl tabControl2;
        private TabPage tab_movimiento;
        private TabPage tab_compra;
        private Button button_ins_mov;
        private Button button_insetar2;
        private Label label_peso2;
        private Label label_concepto2;
        private Label label_fecha2;
        private Label label_chapeta2;
        private Label label_com_fin;
        private TabPage tab_venta;
        private Label label_tittle_movimiento;
        private Label label_salida;
        private Label label_peso_despacho;
        private PictureBox pictureBox1;
        private TabControl tabControl3;
        private TabPage tabPage1;
        private Button button2;
        private TextBox textBox12;
        private Label label4;
        private Label label5;
        private TextBox textBox13;
        private TextBox textBox14;
        private DateTimePicker dateTimePicker4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label9;
        private Label label10;
        private TabPage tabPage2;
        private Button button3;
        private TextBox textBox17;
        private Label label11;
        private Label label12;
        private TextBox textBox18;
        private DateTimePicker dateTimePicker5;
        private Label label13;
        private Label label14;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label15;
        private Label label16;
        private TabPage tabPage3;
        private Label label17;
        private Button button4;
        private TextBox textBox21;
        private Label label18;
        private TextBox textBox22;
        private Label label19;
        private DateTimePicker dateTimePicker6;
        private Label label20;
        private TextBox textBox_ins_mov_peso_destino;
        private Label label_mov_pes_des;
        private Button button1;
        private Label label_tittle_compra;
        private TextBox textBox9;
        private DateTimePicker dateTimePicker2;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox textBox11;
        private Label label_finca2;
        private Label label_com_des;
        private TextBox textBox24;
        private Button button5;
        private TextBox textBox25;
        private Label label_tittle_venta;
        private Label label29;
        private TextBox textBox26;
        private TextBox textBox27;
        private Label label30;
        private Label label31;
        private Label label32;
        private TextBox textBox28;
        private TextBox textBox29;
        private Label label33;
        private ComboBox comboBox2;
        private ComboBox comboBox_ins_com_proveedor;
        private ComboBox comboBox_ins_mov_finca_destino;
        private ComboBox comboBox_ins_mov_finca_origen;
        private ComboBox comboBox_ins_mov_concepto;
        private ComboBox comboBox_ins_ven_finca;
        private ComboBox comboBox_ins_ven_cliente;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker_;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label21;
        private Label label25;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox7;
        private ComboBox comboBox_ins_com_finca;
        private TabControl tabControl_vis_ven;
        private TabPage tab_general;
        private DataGridView dataGridView_por_finca;
        private ComboBox comboBox_vis_gen_informacion_por_finca;
        private Label label28;
        private Label label26;
        private DataGridView dataGridView_general;
        private TabPage tabPage4;
        private Button button_vis_mov_chapeta;
        private Label label_vis_mov_chapeta;
        private TextBox textBox_vis_mov_chapeta;
        private Label label_vis_mov_MOVIMIENTO;
        private DataGridView dataGridView_vis_mov;
        private TabPage tabPage5;
        private DataGridView dataGridView_vis_com;
        private Label label_vis_com_COMPRA;
        private TabPage tabPage6;
        private DataGridView dataGridView_vis_ven;
        private Label label45;
    }
}
