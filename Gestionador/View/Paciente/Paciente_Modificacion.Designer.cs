namespace Gestionador.View.Pacientes
{
    partial class Paciente_Modificacion
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
            this.components = new System.ComponentModel.Container();
            this.btnVolver = new System.Windows.Forms.Button();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.PacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fimedicalDataSet = new Gestionador.FimedicalDataSet();
            this.PacientesTableAdapter = new Gestionador.FimedicalDataSetTableAdapters.PacientesTableAdapter();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fimedicalDataSet)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(830, 455);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 50);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoGridViewTextBoxColumn
            // 
            this.apellidoGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoGridViewTextBoxColumn.Name = "apellidoGridViewTextBoxColumn";
            this.apellidoGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // telefonoCelularDataGridViewTextBoxColumn
            // 
            this.telefonoCelularDataGridViewTextBoxColumn.DataPropertyName = "telefonoCelular";
            this.telefonoCelularDataGridViewTextBoxColumn.HeaderText = "telefonoCelular";
            this.telefonoCelularDataGridViewTextBoxColumn.Name = "telefonoCelularDataGridViewTextBoxColumn";
            this.telefonoCelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgPacientes
            // 
            this.dgPacientes.AllowUserToAddRows = false;
            this.dgPacientes.AllowUserToDeleteRows = false;
            this.dgPacientes.AutoGenerateColumns = false;
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.telefonoCelularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgPacientes.DataSource = this.PacientesBindingSource;
            this.dgPacientes.Location = new System.Drawing.Point(12, 155);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.ReadOnly = true;
            this.dgPacientes.Size = new System.Drawing.Size(968, 294);
            this.dgPacientes.TabIndex = 7;
            this.dgPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacientes_CellClick);
            // 
            // PacientesBindingSource
            // 
            this.PacientesBindingSource.DataMember = "Pacientes";
            this.PacientesBindingSource.DataSource = this.fimedicalDataSet;
            // 
            // fimedicalDataSet
            // 
            this.fimedicalDataSet.DataSetName = "FimedicalDataSet";
            this.fimedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PacientesTableAdapter
            // 
            this.PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(830, 99);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 50);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(110, 87);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 26);
            this.txtDni.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(63, 93);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 20);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(110, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(257, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(35, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(110, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(257, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblNombre);
            this.gbFiltros.Controls.Add(this.txtApellido);
            this.gbFiltros.Controls.Add(this.txtDni);
            this.gbFiltros.Controls.Add(this.lblApellido);
            this.gbFiltros.Controls.Add(this.lblDni);
            this.gbFiltros.Controls.Add(this.txtNombre);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(402, 137);
            this.gbFiltros.TabIndex = 9;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // Paciente_Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 522);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.btnVolver);
            this.Name = "Paciente_Modificacion";
            this.Text = "Buscar Paciente";
            this.Load += new System.EventHandler(this.Paciente_Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fimedicalDataSet)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private FimedicalDataSet fimedicalDataSet;
        private System.Windows.Forms.BindingSource PacienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.BindingSource PacientesBindingSource;
        private FimedicalDataSetTableAdapters.PacientesTableAdapter PacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gbFiltros;
    }
}