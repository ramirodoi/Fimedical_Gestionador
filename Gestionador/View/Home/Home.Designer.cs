namespace Gestionador.View.Home
{
    partial class home
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
            this.btnPacientes = new System.Windows.Forms.Button();
            this.imgLogo = new Gestionador.View.Common.CustomPictureBox();
            this.btnHClinica = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.btnMedicas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.SystemColors.Control;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(93, 348);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(150, 50);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.Pacientes_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Location = new System.Drawing.Point(26, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(440, 330);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnHClinica
            // 
            this.btnHClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHClinica.Location = new System.Drawing.Point(249, 348);
            this.btnHClinica.Name = "btnHClinica";
            this.btnHClinica.Size = new System.Drawing.Size(150, 50);
            this.btnHClinica.TabIndex = 1;
            this.btnHClinica.Text = "Historia Clínica";
            this.btnHClinica.UseVisualStyleBackColor = true;
            this.btnHClinica.Click += new System.EventHandler(this.btnHClinica_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamientos.Location = new System.Drawing.Point(93, 404);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(150, 50);
            this.btnTratamientos.TabIndex = 2;
            this.btnTratamientos.Text = "Tratamientos";
            this.btnTratamientos.UseVisualStyleBackColor = true;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnMedicas
            // 
            this.btnMedicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicas.Location = new System.Drawing.Point(93, 460);
            this.btnMedicas.Name = "btnMedicas";
            this.btnMedicas.Size = new System.Drawing.Size(150, 50);
            this.btnMedicas.TabIndex = 4;
            this.btnMedicas.Text = "Médicas";
            this.btnMedicas.UseVisualStyleBackColor = true;
            this.btnMedicas.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(249, 404);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(150, 50);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(492, 522);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnMedicas);
            this.Controls.Add(this.btnTratamientos);
            this.Controls.Add(this.btnHClinica);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnPacientes);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPacientes;
        private Common.CustomPictureBox imgLogo;
        private System.Windows.Forms.Button btnHClinica;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.Button btnMedicas;
        private System.Windows.Forms.Button btnProductos;
    }
}