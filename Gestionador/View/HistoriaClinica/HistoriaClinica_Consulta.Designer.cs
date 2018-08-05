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
            this.dpFechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.cbMedica = new System.Windows.Forms.ComboBox();
            this.lblNombreTratamiento = new System.Windows.Forms.Label();
            this.lblFechaTratamiento = new System.Windows.Forms.Label();
            this.lblNombreMedica = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.gbTratamiento = new System.Windows.Forms.GroupBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHClinica)).BeginInit();
            this.gbTratamiento.SuspendLayout();
            this.gbPaciente.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dgHClinica.Location = new System.Drawing.Point(12, 315);
            this.dgHClinica.Name = "dgHClinica";
            this.dgHClinica.ReadOnly = true;
            this.dgHClinica.Size = new System.Drawing.Size(922, 415);
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
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            this.Medica.HeaderText = "Médica";
            this.Medica.Name = "Medica";
            this.Medica.ReadOnly = true;
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
            this.MedioPago.HeaderText = "Medio de Pago";
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.ReadOnly = true;
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Location = new System.Drawing.Point(129, 18);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(276, 28);
            this.cbTratamiento.Sorted = true;
            this.cbTratamiento.TabIndex = 1;
            // 
            // dpFechaTratamiento
            // 
            this.dpFechaTratamiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaTratamiento.Location = new System.Drawing.Point(606, 253);
            this.dpFechaTratamiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dpFechaTratamiento.MinDate = new System.DateTime(2018, 7, 15, 0, 0, 0, 0);
            this.dpFechaTratamiento.Name = "dpFechaTratamiento";
            this.dpFechaTratamiento.Size = new System.Drawing.Size(100, 26);
            this.dpFechaTratamiento.TabIndex = 2;
            // 
            // cbMedica
            // 
            this.cbMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedica.FormattingEnabled = true;
            this.cbMedica.Location = new System.Drawing.Point(129, 22);
            this.cbMedica.Name = "cbMedica";
            this.cbMedica.Size = new System.Drawing.Size(276, 28);
            this.cbMedica.TabIndex = 3;
            // 
            // lblNombreTratamiento
            // 
            this.lblNombreTratamiento.AutoSize = true;
            this.lblNombreTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTratamiento.Location = new System.Drawing.Point(54, 26);
            this.lblNombreTratamiento.Name = "lblNombreTratamiento";
            this.lblNombreTratamiento.Size = new System.Drawing.Size(69, 20);
            this.lblNombreTratamiento.TabIndex = 8;
            this.lblNombreTratamiento.Text = "Nombre:";
            // 
            // lblFechaTratamiento
            // 
            this.lblFechaTratamiento.AutoSize = true;
            this.lblFechaTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTratamiento.Location = new System.Drawing.Point(542, 259);
            this.lblFechaTratamiento.Name = "lblFechaTratamiento";
            this.lblFechaTratamiento.Size = new System.Drawing.Size(58, 20);
            this.lblFechaTratamiento.TabIndex = 9;
            this.lblFechaTratamiento.Text = "Fecha:";
            // 
            // lblNombreMedica
            // 
            this.lblNombreMedica.AutoSize = true;
            this.lblNombreMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedica.Location = new System.Drawing.Point(59, 30);
            this.lblNombreMedica.Name = "lblNombreMedica";
            this.lblNombreMedica.Size = new System.Drawing.Size(69, 20);
            this.lblNombreMedica.TabIndex = 10;
            this.lblNombreMedica.Text = "Nombre:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(54, 33);
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
            this.cbPaciente.Location = new System.Drawing.Point(129, 25);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(276, 28);
            this.cbPaciente.Sorted = true;
            this.cbPaciente.TabIndex = 14;
            // 
            // gbTratamiento
            // 
            this.gbTratamiento.Controls.Add(this.cbTratamiento);
            this.gbTratamiento.Controls.Add(this.lblNombreTratamiento);
            this.gbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTratamiento.Location = new System.Drawing.Point(12, 168);
            this.gbTratamiento.Name = "gbTratamiento";
            this.gbTratamiento.Size = new System.Drawing.Size(458, 59);
            this.gbTratamiento.TabIndex = 16;
            this.gbTratamiento.TabStop = false;
            this.gbTratamiento.Text = "Tratamiento";
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.lblPaciente);
            this.gbPaciente.Controls.Add(this.cbPaciente);
            this.gbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaciente.Location = new System.Drawing.Point(12, 12);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(458, 72);
            this.gbPaciente.TabIndex = 17;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.cbProducto);
            this.gbProducto.Controls.Add(this.lblNombreProducto);
            this.gbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.Location = new System.Drawing.Point(12, 233);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(458, 59);
            this.gbProducto.TabIndex = 18;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(129, 18);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(276, 28);
            this.cbProducto.Sorted = true;
            this.cbProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(54, 26);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(69, 20);
            this.lblNombreProducto.TabIndex = 8;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(784, 736);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 50);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(784, 259);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 50);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreMedica);
            this.groupBox1.Controls.Add(this.cbMedica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médica";
            // 
            // HistoriaClinica_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 798);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dpFechaTratamiento);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.lblFechaTratamiento);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.gbTratamiento);
            this.Controls.Add(this.dgHClinica);
            this.Name = "HistoriaClinica_Consulta";
            this.Text = "HistoriaClinica_Alta";
            ((System.ComponentModel.ISupportInitialize)(this.dgHClinica)).EndInit();
            this.gbTratamiento.ResumeLayout(false);
            this.gbTratamiento.PerformLayout();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHClinica;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.DateTimePicker dpFechaTratamiento;
        private System.Windows.Forms.ComboBox cbMedica;
        private System.Windows.Forms.Label lblNombreTratamiento;
        private System.Windows.Forms.Label lblFechaTratamiento;
        private System.Windows.Forms.Label lblNombreMedica;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.GroupBox gbTratamiento;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
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
        private System.Windows.Forms.GroupBox groupBox1;

    }
}