namespace AgendaProfesional
{
    partial class PantallaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaAdmin));
            this.btn_Atras2 = new System.Windows.Forms.Button();
            this.btn_Salir3 = new System.Windows.Forms.Button();
            this.dgv_citas = new System.Windows.Forms.DataGridView();
            this.btn_CancelarCita = new System.Windows.Forms.Button();
            this.btn_CitasDia2 = new System.Windows.Forms.Button();
            this.btn_CitasSemanaID = new System.Windows.Forms.Button();
            this.cmb_Paciente = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.btn_NuevaCita = new System.Windows.Forms.Button();
            this.cmb_IdPaciente = new System.Windows.Forms.ComboBox();
            this.lbl_consultas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Atras2
            // 
            this.btn_Atras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras2.Location = new System.Drawing.Point(35, 319);
            this.btn_Atras2.Name = "btn_Atras2";
            this.btn_Atras2.Size = new System.Drawing.Size(75, 50);
            this.btn_Atras2.TabIndex = 0;
            this.btn_Atras2.Text = "Atrás";
            this.btn_Atras2.UseVisualStyleBackColor = true;
            this.btn_Atras2.Click += new System.EventHandler(this.btn_Atras2_Click);
            // 
            // btn_Salir3
            // 
            this.btn_Salir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir3.Location = new System.Drawing.Point(713, 329);
            this.btn_Salir3.Name = "btn_Salir3";
            this.btn_Salir3.Size = new System.Drawing.Size(75, 50);
            this.btn_Salir3.TabIndex = 1;
            this.btn_Salir3.Text = "Salir";
            this.btn_Salir3.UseVisualStyleBackColor = true;
            this.btn_Salir3.Click += new System.EventHandler(this.btn_Salir3_Click);
            // 
            // dgv_citas
            // 
            this.dgv_citas.AllowUserToAddRows = false;
            this.dgv_citas.AllowUserToDeleteRows = false;
            this.dgv_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_citas.Location = new System.Drawing.Point(185, 30);
            this.dgv_citas.Name = "dgv_citas";
            this.dgv_citas.ReadOnly = true;
            this.dgv_citas.Size = new System.Drawing.Size(578, 159);
            this.dgv_citas.TabIndex = 2;
            // 
            // btn_CancelarCita
            // 
            this.btn_CancelarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarCita.Location = new System.Drawing.Point(35, 142);
            this.btn_CancelarCita.Name = "btn_CancelarCita";
            this.btn_CancelarCita.Size = new System.Drawing.Size(144, 50);
            this.btn_CancelarCita.TabIndex = 3;
            this.btn_CancelarCita.Text = "Cancelar cita seleccionada";
            this.btn_CancelarCita.UseVisualStyleBackColor = true;
            this.btn_CancelarCita.Click += new System.EventHandler(this.btn_CancelarCita_Click);
            // 
            // btn_CitasDia2
            // 
            this.btn_CitasDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CitasDia2.Location = new System.Drawing.Point(35, 30);
            this.btn_CitasDia2.Name = "btn_CitasDia2";
            this.btn_CitasDia2.Size = new System.Drawing.Size(144, 50);
            this.btn_CitasDia2.TabIndex = 4;
            this.btn_CitasDia2.Text = "Ver citas del día";
            this.btn_CitasDia2.UseVisualStyleBackColor = true;
            this.btn_CitasDia2.Click += new System.EventHandler(this.btn_CitasDia2_Click);
            // 
            // btn_CitasSemanaID
            // 
            this.btn_CitasSemanaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CitasSemanaID.Location = new System.Drawing.Point(35, 86);
            this.btn_CitasSemanaID.Name = "btn_CitasSemanaID";
            this.btn_CitasSemanaID.Size = new System.Drawing.Size(144, 50);
            this.btn_CitasSemanaID.TabIndex = 6;
            this.btn_CitasSemanaID.Text = "Ver citas semana";
            this.btn_CitasSemanaID.UseVisualStyleBackColor = true;
            this.btn_CitasSemanaID.Click += new System.EventHandler(this.btn_CitasSemanaID_Click);
            // 
            // cmb_Paciente
            // 
            this.cmb_Paciente.FormattingEnabled = true;
            this.cmb_Paciente.Location = new System.Drawing.Point(21, 19);
            this.cmb_Paciente.Name = "cmb_Paciente";
            this.cmb_Paciente.Size = new System.Drawing.Size(210, 21);
            this.cmb_Paciente.TabIndex = 7;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_fecha.Location = new System.Drawing.Point(21, 46);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(210, 20);
            this.dtp_fecha.TabIndex = 8;
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Location = new System.Drawing.Point(21, 72);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(210, 65);
            this.txt_Observaciones.TabIndex = 10;
            // 
            // btn_NuevaCita
            // 
            this.btn_NuevaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaCita.Location = new System.Drawing.Point(237, 72);
            this.btn_NuevaCita.Name = "btn_NuevaCita";
            this.btn_NuevaCita.Size = new System.Drawing.Size(175, 50);
            this.btn_NuevaCita.TabIndex = 11;
            this.btn_NuevaCita.Text = "Nueva Cita";
            this.btn_NuevaCita.UseVisualStyleBackColor = true;
            this.btn_NuevaCita.Click += new System.EventHandler(this.btn_NuevaCita_Click);
            // 
            // cmb_IdPaciente
            // 
            this.cmb_IdPaciente.Enabled = false;
            this.cmb_IdPaciente.FormattingEnabled = true;
            this.cmb_IdPaciente.Location = new System.Drawing.Point(237, 19);
            this.cmb_IdPaciente.Name = "cmb_IdPaciente";
            this.cmb_IdPaciente.Size = new System.Drawing.Size(92, 21);
            this.cmb_IdPaciente.TabIndex = 12;
            this.cmb_IdPaciente.Visible = false;
            // 
            // lbl_consultas
            // 
            this.lbl_consultas.AutoSize = true;
            this.lbl_consultas.Location = new System.Drawing.Point(182, 9);
            this.lbl_consultas.Name = "lbl_consultas";
            this.lbl_consultas.Size = new System.Drawing.Size(53, 13);
            this.lbl_consultas.TabIndex = 13;
            this.lbl_consultas.Text = "Consultas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.cmb_Paciente);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.cmb_IdPaciente);
            this.groupBox1.Controls.Add(this.txt_Observaciones);
            this.groupBox1.Controls.Add(this.btn_NuevaCita);
            this.groupBox1.Location = new System.Drawing.Point(193, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 150);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programar nueva cita";
            // 
            // PantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(861, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_consultas);
            this.Controls.Add(this.btn_CitasSemanaID);
            this.Controls.Add(this.btn_CitasDia2);
            this.Controls.Add(this.btn_CancelarCita);
            this.Controls.Add(this.dgv_citas);
            this.Controls.Add(this.btn_Salir3);
            this.Controls.Add(this.btn_Atras2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaAdmin";
            this.Text = "PantallaAdmin";
            this.Load += new System.EventHandler(this.btn_CitasDia2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atras2;
        private System.Windows.Forms.Button btn_Salir3;
        private System.Windows.Forms.DataGridView dgv_citas;
        private System.Windows.Forms.Button btn_CancelarCita;
        private System.Windows.Forms.Button btn_CitasDia2;
        private System.Windows.Forms.Button btn_CitasSemanaID;
        private System.Windows.Forms.ComboBox cmb_Paciente;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Button btn_NuevaCita;
        private System.Windows.Forms.ComboBox cmb_IdPaciente;
        private System.Windows.Forms.Label lbl_consultas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}