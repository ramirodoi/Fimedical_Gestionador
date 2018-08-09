namespace Gestionador.View.HistoriaClinica
{
    partial class HistoriaClinica_ABM
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.imgVela = new Gestionador.View.Common.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(110, 425);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(185, 59);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(307, 498);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(185, 59);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(307, 425);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(185, 59);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // imgVela
            // 
            this.imgVela.Location = new System.Drawing.Point(32, 16);
            this.imgVela.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.imgVela.Name = "imgVela";
            this.imgVela.Size = new System.Drawing.Size(539, 395);
            this.imgVela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgVela.TabIndex = 3;
            this.imgVela.TabStop = false;
            // 
            // HistoriaClinica_ABM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(603, 648);
            this.Controls.Add(this.imgVela);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAlta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HistoriaClinica_ABM";
            this.Text = "HistoriaClinica_ABM";
            ((System.ComponentModel.ISupportInitialize)(this.imgVela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultas;
        private Common.CustomPictureBox imgVela;
    }
}