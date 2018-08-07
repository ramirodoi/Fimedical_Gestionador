namespace Gestionador.View.HistoriaClinica
{
    partial class HistoriaClinica_Consulta
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
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbMedica = new System.Windows.Forms.ComboBox();
            this.lblNombreTratamiento = new System.Windows.Forms.Label();
            this.lblFechaTratamiento = new System.Windows.Forms.Label();
            this.lblNombreMedica = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbHistoriaClinica = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHClinica)).BeginInit();
            this.gbPaciente.SuspendLayout();
            this.gbHistoriaClinica.SuspendLayout();
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
            this.dgHClinica.Location = new System.Drawing.Point(13, 280);
            this.dgHClinica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgHClinica.Name = "dgHClinica";
            this.dgHClinica.ReadOnly = true;
            this.dgHClinica.Size = new System.Drawing.Size(966, 468);
            this.dgHClinica.TabIndex = 0;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // idNombre
            // 
            this.idNombre.DataPropertyName = "idNombre";
            this.idNombre.HeaderText = "idNombre";
            this.idNombre.Name = "idNombre";
            this.idNombre.ReadOnly = true;
            this.idNombre.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 150F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // idMedica
            // 
            this.idMedica.DataPropertyName = "idMedica";
            this.idMedica.HeaderText = "idMedica";
            this.idMedica.Name = "idMedica";
            this.idMedica.ReadOnly = true;
            this.idMedica.Visible = false;
            // 
            // Medica
            // 
            this.Medica.DataPropertyName = "Medica";
            this.Medica.FillWeight = 200F;
            this.Medica.HeaderText = "Médica";
            this.Medica.Name = "Medica";
            this.Medica.ReadOnly = true;
            this.Medica.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio $";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            this.Pago.HeaderText = "Pago $";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // idMedioPago
            // 
            this.idMedioPago.DataPropertyName = "idMedioPago";
            this.idMedioPago.HeaderText = "idMedioPago";
            this.idMedioPago.Name = "idMedioPago";
            this.idMedioPago.ReadOnly = true;
            this.idMedioPago.Visible = false;
            // 
            // MedioPago
            // 
            this.MedioPago.DataPropertyName = "MedioPago";
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
            this.cbTratamiento.Location = new System.Drawing.Point(138, 99);
            this.cbTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(150, 28);
            this.cbTratamiento.Sorted = true;
            this.cbTratamiento.TabIndex = 1;
            // 
            // dpFecha
            // 
            this.dpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.Location = new System.Drawing.Point(138, 63);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFecha.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dpFecha.MinDate = new System.DateTime(2018, 7, 15, 0, 0, 0, 0);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(110, 26);
            this.dpFecha.TabIndex = 2;
            this.dpFecha.ValueChanged += new System.EventHandler(this.dpFechaTratamiento_ValueChanged);
            // 
            // cbMedica
            // 
            this.cbMedica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedica.FormattingEnabled = true;
            this.cbMedica.Location = new System.Drawing.Point(138, 25);
            this.cbMedica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMedica.Name = "cbMedica";
            this.cbMedica.Size = new System.Drawing.Size(250, 28);
            this.cbMedica.TabIndex = 3;
            // 
            // lblNombreTratamiento
            // 
            this.lblNombreTratamiento.AutoSize = true;
            this.lblNombreTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTratamiento.Location = new System.Drawing.Point(32, 107);
            this.lblNombreTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTratamiento.Name = "lblNombreTratamiento";
            this.lblNombreTratamiento.Size = new System.Drawing.Size(98, 20);
            this.lblNombreTratamiento.TabIndex = 8;
            this.lblNombreTratamiento.Text = "Tratamiento:";
            // 
            // lblFechaTratamiento
            // 
            this.lblFechaTratamiento.AutoSize = true;
            this.lblFechaTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTratamiento.Location = new System.Drawing.Point(72, 69);
            this.lblFechaTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaTratamiento.Name = "lblFechaTratamiento";
            this.lblFechaTratamiento.Size = new System.Drawing.Size(58, 20);
            this.lblFechaTratamiento.TabIndex = 9;
            this.lblFechaTratamiento.Text = "Fecha:";
            // 
            // lblNombreMedica
            // 
            this.lblNombreMedica.AutoSize = true;
            this.lblNombreMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedica.Location = new System.Drawing.Point(66, 33);
            this.lblNombreMedica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMedica.Name = "lblNombreMedica";
            this.lblNombreMedica.Size = new System.Drawing.Size(64, 20);
            this.lblNombreMedica.TabIndex = 10;
            this.lblNombreMedica.Text = "Médica:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(61, 32);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(69, 20);
            this.lblPaciente.TabIndex = 15;
            this.lblPaciente.Text = "Nombre:";
            // 
            // cbPaciente
            // 
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(138, 24);
            this.cbPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(250, 28);
            this.cbPaciente.Sorted = true;
            this.cbPaciente.TabIndex = 14;
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
            this.gbPaciente.Size = new System.Drawing.Size(420, 66);
            this.gbPaciente.TabIndex = 17;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(138, 137);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(150, 28);
            this.cbProducto.Sorted = true;
            this.cbProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(53, 145);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(77, 20);
            this.lblNombreProducto.TabIndex = 8;
            this.lblNombreProducto.Text = "Producto:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(829, 758);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 50);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(829, 220);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 50);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbHistoriaClinica
            // 
            this.gbHistoriaClinica.Controls.Add(this.cbTratamiento);
            this.gbHistoriaClinica.Controls.Add(this.lblNombreMedica);
            this.gbHistoriaClinica.Controls.Add(this.cbProducto);
            this.gbHistoriaClinica.Controls.Add(this.cbMedica);
            this.gbHistoriaClinica.Controls.Add(this.lblNombreTratamiento);
            this.gbHistoriaClinica.Controls.Add(this.lblFechaTratamiento);
            this.gbHistoriaClinica.Controls.Add(this.lblNombreProducto);
            this.gbHistoriaClinica.Controls.Add(this.dpFecha);
            this.gbHistoriaClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistoriaClinica.Location = new System.Drawing.Point(13, 90);
            this.gbHistoriaClinica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbHistoriaClinica.Name = "gbHistoriaClinica";
            this.gbHistoriaClinica.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbHistoriaClinica.Size = new System.Drawing.Size(420, 180);
            this.gbHistoriaClinica.TabIndex = 18;
            this.gbHistoriaClinica.TabStop = false;
            this.gbHistoriaClinica.Text = "Historia Clínica";
            // 
            // HistoriaClinica_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 822);
            this.Controls.Add(this.gbHistoriaClinica);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.dgHClinica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistoriaClinica_Consulta";
            this.Text = "HistoriaClinica_Alta";
            ((System.ComponentModel.ISupportInitialize)(this.dgHClinica)).EndInit();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbHistoriaClinica.ResumeLayout(false);
            this.gbHistoriaClinica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHClinica;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.ComboBox cbMedica;
        private System.Windows.Forms.Label lblNombreTratamiento;
        private System.Windows.Forms.Label lblFechaTratamiento;
        private System.Windows.Forms.Label lblNombreMedica;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbHistoriaClinica;
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