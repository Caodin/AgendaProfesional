namespace AgendaProfesional
{
    partial class PantallaProfesional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaProfesional));
            this.dtg_Citas = new System.Windows.Forms.DataGridView();
            this.btn_CitasDia = new System.Windows.Forms.Button();
            this.btn_CitasSemana = new System.Windows.Forms.Button();
            this.btn_VerHistorial = new System.Windows.Forms.Button();
            this.btn_salir2 = new System.Windows.Forms.Button();
            this.txt_NombrePaciente = new System.Windows.Forms.TextBox();
            this.txt_ApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txt_ApellidoMedico = new System.Windows.Forms.TextBox();
            this.lbl_NombrePaciente = new System.Windows.Forms.Label();
            this.lbl_ApellidosDoctor = new System.Windows.Forms.Label();
            this.lbl_Doctor = new System.Windows.Forms.Label();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Citas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Citas
            // 
            this.dtg_Citas.AllowUserToAddRows = false;
            this.dtg_Citas.AllowUserToDeleteRows = false;
            this.dtg_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Citas.Location = new System.Drawing.Point(105, 12);
            this.dtg_Citas.Name = "dtg_Citas";
            this.dtg_Citas.ReadOnly = true;
            this.dtg_Citas.Size = new System.Drawing.Size(329, 248);
            this.dtg_Citas.TabIndex = 0;
            // 
            // btn_CitasDia
            // 
            this.btn_CitasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CitasDia.Location = new System.Drawing.Point(164, 266);
            this.btn_CitasDia.Name = "btn_CitasDia";
            this.btn_CitasDia.Size = new System.Drawing.Size(218, 51);
            this.btn_CitasDia.TabIndex = 1;
            this.btn_CitasDia.Text = "Ver citas Dia";
            this.btn_CitasDia.UseVisualStyleBackColor = true;
            this.btn_CitasDia.Click += new System.EventHandler(this.btn_CitasDia_Click);
            // 
            // btn_CitasSemana
            // 
            this.btn_CitasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CitasSemana.Location = new System.Drawing.Point(164, 330);
            this.btn_CitasSemana.Name = "btn_CitasSemana";
            this.btn_CitasSemana.Size = new System.Drawing.Size(218, 51);
            this.btn_CitasSemana.TabIndex = 2;
            this.btn_CitasSemana.Text = "Ver citas Semana";
            this.btn_CitasSemana.UseVisualStyleBackColor = true;
            this.btn_CitasSemana.Click += new System.EventHandler(this.btn_CitasSemana_Click);
            // 
            // btn_VerHistorial
            // 
            this.btn_VerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerHistorial.Location = new System.Drawing.Point(519, 266);
            this.btn_VerHistorial.Name = "btn_VerHistorial";
            this.btn_VerHistorial.Size = new System.Drawing.Size(218, 51);
            this.btn_VerHistorial.TabIndex = 4;
            this.btn_VerHistorial.Text = "Ver historial";
            this.btn_VerHistorial.UseVisualStyleBackColor = true;
            this.btn_VerHistorial.Click += new System.EventHandler(this.btn_VerHistorial_Click);
            // 
            // btn_salir2
            // 
            this.btn_salir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir2.Location = new System.Drawing.Point(712, 330);
            this.btn_salir2.Name = "btn_salir2";
            this.btn_salir2.Size = new System.Drawing.Size(76, 51);
            this.btn_salir2.TabIndex = 5;
            this.btn_salir2.Text = "Salir";
            this.btn_salir2.UseVisualStyleBackColor = true;
            this.btn_salir2.Click += new System.EventHandler(this.btn_salir2_Click);
            // 
            // txt_NombrePaciente
            // 
            this.txt_NombrePaciente.Location = new System.Drawing.Point(519, 22);
            this.txt_NombrePaciente.Name = "txt_NombrePaciente";
            this.txt_NombrePaciente.Size = new System.Drawing.Size(269, 20);
            this.txt_NombrePaciente.TabIndex = 8;
            // 
            // txt_ApellidoPaciente
            // 
            this.txt_ApellidoPaciente.Location = new System.Drawing.Point(519, 48);
            this.txt_ApellidoPaciente.Name = "txt_ApellidoPaciente";
            this.txt_ApellidoPaciente.Size = new System.Drawing.Size(269, 20);
            this.txt_ApellidoPaciente.TabIndex = 9;
            // 
            // txt_ApellidoMedico
            // 
            this.txt_ApellidoMedico.Location = new System.Drawing.Point(519, 74);
            this.txt_ApellidoMedico.Name = "txt_ApellidoMedico";
            this.txt_ApellidoMedico.Size = new System.Drawing.Size(269, 20);
            this.txt_ApellidoMedico.TabIndex = 10;
            // 
            // lbl_NombrePaciente
            // 
            this.lbl_NombrePaciente.AutoSize = true;
            this.lbl_NombrePaciente.Location = new System.Drawing.Point(464, 25);
            this.lbl_NombrePaciente.Name = "lbl_NombrePaciente";
            this.lbl_NombrePaciente.Size = new System.Drawing.Size(44, 13);
            this.lbl_NombrePaciente.TabIndex = 11;
            this.lbl_NombrePaciente.Text = "Nombre";
            // 
            // lbl_ApellidosDoctor
            // 
            this.lbl_ApellidosDoctor.AutoSize = true;
            this.lbl_ApellidosDoctor.Location = new System.Drawing.Point(464, 51);
            this.lbl_ApellidosDoctor.Name = "lbl_ApellidosDoctor";
            this.lbl_ApellidosDoctor.Size = new System.Drawing.Size(49, 13);
            this.lbl_ApellidosDoctor.TabIndex = 12;
            this.lbl_ApellidosDoctor.Text = "Apellidos";
            // 
            // lbl_Doctor
            // 
            this.lbl_Doctor.AutoSize = true;
            this.lbl_Doctor.Location = new System.Drawing.Point(464, 77);
            this.lbl_Doctor.Name = "lbl_Doctor";
            this.lbl_Doctor.Size = new System.Drawing.Size(39, 13);
            this.lbl_Doctor.TabIndex = 13;
            this.lbl_Doctor.Text = "Doctor";
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.AutoSize = true;
            this.lbl_Observaciones.Location = new System.Drawing.Point(464, 110);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.lbl_Observaciones.TabIndex = 14;
            this.lbl_Observaciones.Text = "Observaciones";
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Location = new System.Drawing.Point(462, 126);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(326, 134);
            this.txt_Observaciones.TabIndex = 15;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(12, 12);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(75, 51);
            this.btn_Admin.TabIndex = 17;
            this.btn_Admin.Text = "Vista Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // PantallaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.txt_Observaciones);
            this.Controls.Add(this.lbl_Observaciones);
            this.Controls.Add(this.lbl_Doctor);
            this.Controls.Add(this.lbl_ApellidosDoctor);
            this.Controls.Add(this.lbl_NombrePaciente);
            this.Controls.Add(this.txt_ApellidoMedico);
            this.Controls.Add(this.txt_ApellidoPaciente);
            this.Controls.Add(this.txt_NombrePaciente);
            this.Controls.Add(this.btn_salir2);
            this.Controls.Add(this.btn_VerHistorial);
            this.Controls.Add(this.btn_CitasSemana);
            this.Controls.Add(this.btn_CitasDia);
            this.Controls.Add(this.dtg_Citas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaProfesional";
            this.Text = "PantallaProfesional";
            this.Load += new System.EventHandler(this.btn_CitasDia_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Citas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Citas;
        private System.Windows.Forms.Button btn_CitasDia;
        private System.Windows.Forms.Button btn_CitasSemana;
        private System.Windows.Forms.Button btn_VerHistorial;
        private System.Windows.Forms.Button btn_salir2;
        private System.Windows.Forms.TextBox txt_NombrePaciente;
        private System.Windows.Forms.TextBox txt_ApellidoPaciente;
        private System.Windows.Forms.TextBox txt_ApellidoMedico;
        private System.Windows.Forms.Label lbl_NombrePaciente;
        private System.Windows.Forms.Label lbl_ApellidosDoctor;
        private System.Windows.Forms.Label lbl_Doctor;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Button btn_Admin;
    }
}