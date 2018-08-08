﻿namespace Gestionador.View.HistoriaClinica
{
    partial class HistoriaClinica_Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgHClinica = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.dpFechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.cbMedica = new System.Windows.Forms.ComboBox();
            this.txtPrecioTratamiento = new System.Windows.Forms.TextBox();
            this.txtPagoTratamiento = new System.Windows.Forms.TextBox();
            this.cbMedioPagoTratamiento = new System.Windows.Forms.ComboBox();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.lblNombreTratamiento = new System.Windows.Forms.Label();
            this.lblFechaTratamiento = new System.Windows.Forms.Label();
            this.lblMedica = new System.Windows.Forms.Label();
            this.lblPrecioTratamiento = new System.Windows.Forms.Label();
            this.lblPagoTratamiento = new System.Windows.Forms.Label();
            this.lblMedioPagoTratamiento = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.gbTratamiento = new System.Windows.Forms.GroupBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.dpFechaProducto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMedioPagoProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblFechaProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHClinica)).BeginInit();
            this.gbTratamiento.SuspendLayout();
            this.gbPaciente.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHClinica
            // 
            this.dgHClinica.AllowUserToAddRows = false;
            this.dgHClinica.AllowUserToDeleteRows = false;
            this.dgHClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHClinica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.idNombre,
            this.Nombre,
            this.Fecha,
            this.idMedica,
            this.Medica,
            this.Precio,
            this.Pago,
            this.idMedioPago,
            this.MedioPago});
            this.dgHClinica.Location = new System.Drawing.Point(13, 386);
            this.dgHClinica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgHClinica.Name = "dgHClinica";
            this.dgHClinica.ReadOnly = true;
            this.dgHClinica.Size = new System.Drawing.Size(966, 370);
            this.dgHClinica.TabIndex = 0;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // idNombre
            // 
            this.idNombre.HeaderText = "idNombre";
            this.idNombre.Name = "idNombre";
            this.idNombre.ReadOnly = true;
            this.idNombre.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 150F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // idMedica
            // 
            this.idMedica.HeaderText = "idMedica";
            this.idMedica.Name = "idMedica";
            this.idMedica.ReadOnly = true;
            this.idMedica.Visible = false;
            // 
            // Medica
            // 
            this.Medica.FillWeight = 200F;
            this.Medica.HeaderText = "Médica";
            this.Medica.Name = "Medica";
            this.Medica.ReadOnly = true;
            this.Medica.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio $";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago $";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // idMedioPago
            // 
            this.idMedioPago.HeaderText = "idMedioPago";
            this.idMedioPago.Name = "idMedioPago";
            this.idMedioPago.ReadOnly = true;
            this.idMedioPago.Visible = false;
            // 
            // MedioPago
            // 
            this.MedioPago.FillWeight = 150F;
            this.MedioPago.HeaderText = "Medio de Pago";
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.ReadOnly = true;
            this.MedioPago.Width = 150;
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Location = new System.Drawing.Point(143, 33);
            this.cbTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(200, 33);
            this.cbTratamiento.Sorted = true;
            this.cbTratamiento.TabIndex = 1;
            // 
            // dpFechaTratamiento
            // 
            this.dpFechaTratamiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaTratamiento.Location = new System.Drawing.Point(143, 71);
            this.dpFechaTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFechaTratamiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dpFechaTratamiento.MinDate = new System.DateTime(2018, 7, 15, 0, 0, 0, 0);
            this.dpFechaTratamiento.Name = "dpFechaTratamiento";
            this.dpFechaTratamiento.Size = new System.Drawing.Size(110, 30);
            this.dpFechaTratamiento.TabIndex = 2;
            // 
            // cbMedica
            // 
            this.cbMedica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedica.FormattingEnabled = true;
            this.cbMedica.Location = new System.Drawing.Point(143, 107);
            this.cbMedica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMedica.Name = "cbMedica";
            this.cbMedica.Size = new System.Drawing.Size(250, 33);
            this.cbMedica.TabIndex = 3;
            // 
            // txtPrecioTratamiento
            // 
            this.txtPrecioTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTratamiento.Location = new System.Drawing.Point(143, 145);
            this.txtPrecioTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioTratamiento.Name = "txtPrecioTratamiento";
            this.txtPrecioTratamiento.Size = new System.Drawing.Size(100, 30);
            this.txtPrecioTratamiento.TabIndex = 4;
            this.txtPrecioTratamiento.TextChanged += new System.EventHandler(this.txtPrecioTratamiento_TextChanged);
            // 
            // txtPagoTratamiento
            // 
            this.txtPagoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoTratamiento.Location = new System.Drawing.Point(326, 145);
            this.txtPagoTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPagoTratamiento.Name = "txtPagoTratamiento";
            this.txtPagoTratamiento.Size = new System.Drawing.Size(100, 30);
            this.txtPagoTratamiento.TabIndex = 5;
            this.txtPagoTratamiento.TextChanged += new System.EventHandler(this.txtPagoTratamiento_TextChanged);
            // 
            // cbMedioPagoTratamiento
            // 
            this.cbMedioPagoTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedioPagoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedioPagoTratamiento.FormattingEnabled = true;
            this.cbMedioPagoTratamiento.Location = new System.Drawing.Point(143, 181);
            this.cbMedioPagoTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMedioPagoTratamiento.Name = "cbMedioPagoTratamiento";
            this.cbMedioPagoTratamiento.Size = new System.Drawing.Size(200, 33);
            this.cbMedioPagoTratamiento.TabIndex = 6;
            // 
            // btnAgregarTratamiento
            // 
            this.btnAgregarTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(276, 219);
            this.btnAgregarTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(150, 50);
            this.btnAgregarTratamiento.TabIndex = 7;
            this.btnAgregarTratamiento.Text = "Agregar Tratamiento";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = true;
            this.btnAgregarTratamiento.Click += new System.EventHandler(this.btnAgregarTratamiento_Click);
            // 
            // lblNombreTratamiento
            // 
            this.lblNombreTratamiento.AutoSize = true;
            this.lblNombreTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTratamiento.Location = new System.Drawing.Point(66, 41);
            this.lblNombreTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTratamiento.Name = "lblNombreTratamiento";
            this.lblNombreTratamiento.Size = new System.Drawing.Size(87, 25);
            this.lblNombreTratamiento.TabIndex = 8;
            this.lblNombreTratamiento.Text = "Nombre:";
            // 
            // lblFechaTratamiento
            // 
            this.lblFechaTratamiento.AutoSize = true;
            this.lblFechaTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTratamiento.Location = new System.Drawing.Point(77, 77);
            this.lblFechaTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaTratamiento.Name = "lblFechaTratamiento";
            this.lblFechaTratamiento.Size = new System.Drawing.Size(73, 25);
            this.lblFechaTratamiento.TabIndex = 9;
            this.lblFechaTratamiento.Text = "Fecha:";
            // 
            // lblMedica
            // 
            this.lblMedica.AutoSize = true;
            this.lblMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedica.Location = new System.Drawing.Point(71, 115);
            this.lblMedica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedica.Name = "lblMedica";
            this.lblMedica.Size = new System.Drawing.Size(82, 25);
            this.lblMedica.TabIndex = 10;
            this.lblMedica.Text = "Médica:";
            // 
            // lblPrecioTratamiento
            // 
            this.lblPrecioTratamiento.AutoSize = true;
            this.lblPrecioTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTratamiento.Location = new System.Drawing.Point(65, 151);
            this.lblPrecioTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioTratamiento.Name = "lblPrecioTratamiento";
            this.lblPrecioTratamiento.Size = new System.Drawing.Size(89, 25);
            this.lblPrecioTratamiento.TabIndex = 11;
            this.lblPrecioTratamiento.Text = "Precio $:";
            // 
            // lblPagoTratamiento
            // 
            this.lblPagoTratamiento.AutoSize = true;
            this.lblPagoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoTratamiento.Location = new System.Drawing.Point(255, 151);
            this.lblPagoTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagoTratamiento.Name = "lblPagoTratamiento";
            this.lblPagoTratamiento.Size = new System.Drawing.Size(80, 25);
            this.lblPagoTratamiento.TabIndex = 12;
            this.lblPagoTratamiento.Text = "Pago $:";
            // 
            // lblMedioPagoTratamiento
            // 
            this.lblMedioPagoTratamiento.AutoSize = true;
            this.lblMedioPagoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedioPagoTratamiento.Location = new System.Drawing.Point(16, 189);
            this.lblMedioPagoTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedioPagoTratamiento.Name = "lblMedioPagoTratamiento";
            this.lblMedioPagoTratamiento.Size = new System.Drawing.Size(150, 25);
            this.lblMedioPagoTratamiento.TabIndex = 13;
            this.lblMedioPagoTratamiento.Text = "Medio de Pago:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(67, 32);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(87, 25);
            this.lblPaciente.TabIndex = 15;
            this.lblPaciente.Text = "Nombre:";
            // 
            // cbPaciente
            // 
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(177, 22);
            this.cbPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(250, 33);
            this.cbPaciente.Sorted = true;
            this.cbPaciente.TabIndex = 14;
            // 
            // gbTratamiento
            // 
            this.gbTratamiento.Controls.Add(this.cbTratamiento);
            this.gbTratamiento.Controls.Add(this.dpFechaTratamiento);
            this.gbTratamiento.Controls.Add(this.cbMedica);
            this.gbTratamiento.Controls.Add(this.lblMedioPagoTratamiento);
            this.gbTratamiento.Controls.Add(this.txtPrecioTratamiento);
            this.gbTratamiento.Controls.Add(this.lblPagoTratamiento);
            this.gbTratamiento.Controls.Add(this.txtPagoTratamiento);
            this.gbTratamiento.Controls.Add(this.lblPrecioTratamiento);
            this.gbTratamiento.Controls.Add(this.cbMedioPagoTratamiento);
            this.gbTratamiento.Controls.Add(this.lblMedica);
            this.gbTratamiento.Controls.Add(this.btnAgregarTratamiento);
            this.gbTratamiento.Controls.Add(this.lblFechaTratamiento);
            this.gbTratamiento.Controls.Add(this.lblNombreTratamiento);
            this.gbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTratamiento.Location = new System.Drawing.Point(14, 89);
            this.gbTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTratamiento.Name = "gbTratamiento";
            this.gbTratamiento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTratamiento.Size = new System.Drawing.Size(465, 290);
            this.gbTratamiento.TabIndex = 16;
            this.gbTratamiento.TabStop = false;
            this.gbTratamiento.Text = "Tratamiento";
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.lblPaciente);
            this.gbPaciente.Controls.Add(this.cbPaciente);
            this.gbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaciente.Location = new System.Drawing.Point(13, 14);
            this.gbPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPaciente.Size = new System.Drawing.Size(466, 65);
            this.gbPaciente.TabIndex = 17;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.cbProducto);
            this.gbProducto.Controls.Add(this.dpFechaProducto);
            this.gbProducto.Controls.Add(this.label1);
            this.gbProducto.Controls.Add(this.txtPrecioProducto);
            this.gbProducto.Controls.Add(this.label2);
            this.gbProducto.Controls.Add(this.txtPagoProducto);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.cbMedioPagoProducto);
            this.gbProducto.Controls.Add(this.btnAgregarProducto);
            this.gbProducto.Controls.Add(this.lblFechaProducto);
            this.gbProducto.Controls.Add(this.lblNombreProducto);
            this.gbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.Location = new System.Drawing.Point(487, 89);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducto.Size = new System.Drawing.Size(465, 290);
            this.gbProducto.TabIndex = 18;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(161, 33);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(200, 33);
            this.cbProducto.Sorted = true;
            this.cbProducto.TabIndex = 1;
            // 
            // dpFechaProducto
            // 
            this.dpFechaProducto.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaProducto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaProducto.Location = new System.Drawing.Point(161, 71);
            this.dpFechaProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFechaProducto.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dpFechaProducto.MinDate = new System.DateTime(2018, 7, 15, 0, 0, 0, 0);
            this.dpFechaProducto.Name = "dpFechaProducto";
            this.dpFechaProducto.Size = new System.Drawing.Size(110, 30);
            this.dpFechaProducto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Medio de Pago:";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(161, 140);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 30);
            this.txtPrecioProducto.TabIndex = 4;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pago $:";
            // 
            // txtPagoProducto
            // 
            this.txtPagoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoProducto.Location = new System.Drawing.Point(341, 137);
            this.txtPagoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPagoProducto.Name = "txtPagoProducto";
            this.txtPagoProducto.Size = new System.Drawing.Size(100, 30);
            this.txtPagoProducto.TabIndex = 5;
            this.txtPagoProducto.TextChanged += new System.EventHandler(this.txtPagoProducto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio $:";
            // 
            // cbMedioPagoProducto
            // 
            this.cbMedioPagoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedioPagoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedioPagoProducto.FormattingEnabled = true;
            this.cbMedioPagoProducto.Location = new System.Drawing.Point(161, 176);
            this.cbMedioPagoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMedioPagoProducto.Name = "cbMedioPagoProducto";
            this.cbMedioPagoProducto.Size = new System.Drawing.Size(200, 33);
            this.cbMedioPagoProducto.TabIndex = 6;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(291, 219);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(150, 50);
            this.btnAgregarProducto.TabIndex = 7;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblFechaProducto
            // 
            this.lblFechaProducto.AutoSize = true;
            this.lblFechaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaProducto.Location = new System.Drawing.Point(95, 77);
            this.lblFechaProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaProducto.Name = "lblFechaProducto";
            this.lblFechaProducto.Size = new System.Drawing.Size(73, 25);
            this.lblFechaProducto.TabIndex = 9;
            this.lblFechaProducto.Text = "Fecha:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(84, 41);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(87, 25);
            this.lblNombreProducto.TabIndex = 8;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(829, 766);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 50);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(671, 766);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 50);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // HistoriaClinica_Alta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(992, 822);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.gbTratamiento);
            this.Controls.Add(this.dgHClinica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistoriaClinica_Alta";
            this.Text = "HistoriaClinica_Alta";
            ((System.ComponentModel.ISupportInitialize)(this.dgHClinica)).EndInit();
            this.gbTratamiento.ResumeLayout(false);
            this.gbTratamiento.PerformLayout();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHClinica;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.DateTimePicker dpFechaTratamiento;
        private System.Windows.Forms.ComboBox cbMedica;
        private System.Windows.Forms.TextBox txtPrecioTratamiento;
        private System.Windows.Forms.TextBox txtPagoTratamiento;
        private System.Windows.Forms.ComboBox cbMedioPagoTratamiento;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.Label lblNombreTratamiento;
        private System.Windows.Forms.Label lblFechaTratamiento;
        private System.Windows.Forms.Label lblMedica;
        private System.Windows.Forms.Label lblPrecioTratamiento;
        private System.Windows.Forms.Label lblPagoTratamiento;
        private System.Windows.Forms.Label lblMedioPagoTratamiento;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.GroupBox gbTratamiento;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.DateTimePicker dpFechaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMedioPagoProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblFechaProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPago;

    }
}