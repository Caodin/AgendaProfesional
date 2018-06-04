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
            this.lbl = new System.Windows.Forms.Label();
            this.btn_CitasSemanaID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atras2
            // 
            this.btn_Atras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras2.Location = new System.Drawing.Point(45, 30);
            this.btn_Atras2.Name = "btn_Atras2";
            this.btn_Atras2.Size = new System.Drawing.Size(75, 50);
            this.btn_Atras2.TabIndex = 0;
            this.btn_Atras2.Text = "Atrás";
            this.btn_Atras2.UseVisualStyleBackColor = true;
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
            this.btn_CancelarCita.Location = new System.Drawing.Point(45, 98);
            this.btn_CancelarCita.Name = "btn_CancelarCita";
            this.btn_CancelarCita.Size = new System.Drawing.Size(75, 50);
            this.btn_CancelarCita.TabIndex = 3;
            this.btn_CancelarCita.Text = "Cancelar cita";
            this.btn_CancelarCita.UseVisualStyleBackColor = true;
            this.btn_CancelarCita.Click += new System.EventHandler(this.btn_CancelarCita_Click);
            // 
            // btn_CitasDia2
            // 
            this.btn_CitasDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CitasDia2.Location = new System.Drawing.Point(245, 207);
            this.btn_CitasDia2.Name = "btn_CitasDia2";
            this.btn_CitasDia2.Size = new System.Drawing.Size(175, 50);
            this.btn_CitasDia2.TabIndex = 4;
            this.btn_CitasDia2.Text = "Ver citas del día";
            this.btn_CitasDia2.UseVisualStyleBackColor = true;
            this.btn_CitasDia2.Click += new System.EventHandler(this.btn_CitasDia2_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(524, 263);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(229, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Añadir cita, Añadir paciente, apadir profesional ";
            // 
            // btn_CitasSemanaID
            // 
            this.btn_CitasSemanaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CitasSemanaID.Location = new System.Drawing.Point(245, 263);
            this.btn_CitasSemanaID.Name = "btn_CitasSemanaID";
            this.btn_CitasSemanaID.Size = new System.Drawing.Size(175, 50);
            this.btn_CitasSemanaID.TabIndex = 6;
            this.btn_CitasSemanaID.Text = "Ver citas semana";
            this.btn_CitasSemanaID.UseVisualStyleBackColor = true;
            this.btn_CitasSemanaID.Click += new System.EventHandler(this.btn_CitasSemanaID_Click);
            // 
            // PantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.btn_CitasSemanaID);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_CitasDia2);
            this.Controls.Add(this.btn_CancelarCita);
            this.Controls.Add(this.dgv_citas);
            this.Controls.Add(this.btn_Salir3);
            this.Controls.Add(this.btn_Atras2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaAdmin";
            this.Text = "PantallaAdmin";
            this.Load += new System.EventHandler(this.btn_CitasDia2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atras2;
        private System.Windows.Forms.Button btn_Salir3;
        private System.Windows.Forms.DataGridView dgv_citas;
        private System.Windows.Forms.Button btn_CancelarCita;
        private System.Windows.Forms.Button btn_CitasDia2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn_CitasSemanaID;
    }
}