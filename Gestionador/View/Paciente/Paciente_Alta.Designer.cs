namespace Gestionador.View.Pacientes
{
    partial class Paciente_Alta
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.txtTelefonoCelular = new System.Windows.Forms.TextBox();
            this.txtTelefonoTrabajo = new System.Windows.Forms.TextBox();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.lblTelefonoCelular = new System.Windows.Forms.Label();
            this.lblTelefonoTrabajo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.dpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(405, 288);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleName = "";
            this.txtNombre.Location = new System.Drawing.Point(152, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(152, 32);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(300, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(41, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(41, 84);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(41, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(324, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(152, 111);
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoFijo.TabIndex = 9;
            // 
            // txtTelefonoCelular
            // 
            this.txtTelefonoCelular.Location = new System.Drawing.Point(152, 137);
            this.txtTelefonoCelular.Name = "txtTelefonoCelular";
            this.txtTelefonoCelular.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoCelular.TabIndex = 11;
            // 
            // txtTelefonoTrabajo
            // 
            this.txtTelefonoTrabajo.Location = new System.Drawing.Point(152, 163);
            this.txtTelefonoTrabajo.Name = "txtTelefonoTrabajo";
            this.txtTelefonoTrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoTrabajo.TabIndex = 13;
            // 
            // lblTelefonoFijo
            // 
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(41, 111);
            this.lblTelefonoFijo.Name = "lblTelefonoFijo";
            this.lblTelefonoFijo.Size = new System.Drawing.Size(71, 13);
            this.lblTelefonoFijo.TabIndex = 8;
            this.lblTelefonoFijo.Text = "Teléfono Fijo:";
            // 
            // lblTelefonoCelular
            // 
            this.lblTelefonoCelular.AutoSize = true;
            this.lblTelefonoCelular.Location = new System.Drawing.Point(41, 137);
            this.lblTelefonoCelular.Name = "lblTelefonoCelular";
            this.lblTelefonoCelular.Size = new System.Drawing.Size(87, 13);
            this.lblTelefonoCelular.TabIndex = 10;
            this.lblTelefonoCelular.Text = "Teléfono Celular:";
            // 
            // lblTelefonoTrabajo
            // 
            this.lblTelefonoTrabajo.AutoSize = true;
            this.lblTelefonoTrabajo.Location = new System.Drawing.Point(41, 163);
            this.lblTelefonoTrabajo.Name = "lblTelefonoTrabajo";
            this.lblTelefonoTrabajo.Size = new System.Drawing.Size(83, 13);
            this.lblTelefonoTrabajo.TabIndex = 12;
            this.lblTelefonoTrabajo.Text = "Téfono Trabajo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(41, 215);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Domicilio:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(41, 241);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 18;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(152, 215);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(300, 20);
            this.txtDomicilio.TabIndex = 17;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(152, 241);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(300, 20);
            this.txtLocalidad.TabIndex = 19;
            // 
            // dpFechaNacimiento
            // 
            this.dpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaNacimiento.Location = new System.Drawing.Point(152, 84);
            this.dpFechaNacimiento.MaxDate = new System.DateTime(2018, 7, 15, 0, 0, 0, 0);
            this.dpFechaNacimiento.MinDate = new System.DateTime(1900, 7, 15, 0, 0, 0, 0);
            this.dpFechaNacimiento.Name = "dpFechaNacimiento";
            this.dpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dpFechaNacimiento.TabIndex = 7;
            this.dpFechaNacimiento.Value = new System.DateTime(2018, 7, 15, 0, 0, 0, 0);
            this.dpFechaNacimiento.ValueChanged += new System.EventHandler(this.dpFechaNacimiento_ValueChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(41, 58);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(152, 58);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // Paciente_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 323);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.dpFechaNacimiento);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefonoTrabajo);
            this.Controls.Add(this.lblTelefonoCelular);
            this.Controls.Add(this.lblTelefonoFijo);
            this.Controls.Add(this.txtTelefonoTrabajo);
            this.Controls.Add(this.txtTelefonoCelular);
            this.Controls.Add(this.txtTelefonoFijo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnVolver);
            this.Name = "Paciente_Alta";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.TextBox txtTelefonoCelular;
        private System.Windows.Forms.TextBox txtTelefonoTrabajo;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.Label lblTelefonoCelular;
        private System.Windows.Forms.Label lblTelefonoTrabajo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.DateTimePicker dpFechaNacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
    }
}