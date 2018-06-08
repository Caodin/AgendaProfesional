using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProfesional
{
    public partial class PantallaAdmin : Form
    {
        AccesoBBDD acceso = new AccesoBBDD();
        Login login;
        PantallaProfesional pantallaProfesional;
        int id_Profesional;

        public PantallaAdmin(Login login, PantallaProfesional pantallaProfesional, int id_Profesional)
        {
            this.login = login;
            this.pantallaProfesional = pantallaProfesional;
            this.id_Profesional = id_Profesional;

            InitializeComponent();

            string query = "select ID_paciente as idPaciente, concat(nombre , ' ' , apellidos) as nombrePaciente from dbo.pacientes";
            SqlCommand command= new SqlCommand(query, acceso.getConnection());
            //Mostrarlos en la grid
            try
            {
                //Abrir la conexión
                acceso.conectar();
                //Ejecutar comando
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_Paciente.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                    cmb_IdPaciente.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
                //Cerrar el Datareader
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar" +
                ex.Message);
            }            finally            {
                acceso.desconectar();
            }
        }

        private void btn_CitasDia2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_citasDiaID]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                SqlDataReader dr = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                this.dgv_citas.DataSource = dt;

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar: " + ex.Message);
            }
            finally
            {
                acceso.desconectar();
            }
        }

        private void btn_Salir3_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_LogOut]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@ID_profesional", SqlDbType.Int));
            sqlCommand.Parameters["@ID_profesional"].Value = id_Profesional;

            try
            {
                acceso.conectar();

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar: " + ex.Message);
            }
            finally
            {
                acceso.desconectar();
            }

            pantallaProfesional.Close();
            login.Close();
            this.Close();
        }

        private void btn_CancelarCita_Click(object sender, EventArgs e)
        {
            int fila_Elegida = -1;
            int id_Cita = -1;

            try
            {
                fila_Elegida = dgv_citas.SelectedRows[0].Index;
                id_Cita = (int) dgv_citas[0, fila_Elegida].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("¡No ha elegido ninguna fila!");
            }

            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_cancelarCita]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            sqlCommand.Parameters["@id"].Value = id_Cita;

            if (id_Cita != -1)
            {
                try
                {
                    acceso.conectar();

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido conectar: " + ex.Message);
                }
                finally
                {
                    acceso.desconectar();
                    
                    btn_CitasDia2.PerformClick();
                }
            }
        }

        private void btn_CitasSemanaID_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_citasSemanaID]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                SqlDataReader dr = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                this.dgv_citas.DataSource = dt;

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar: " + ex.Message);
            }
            finally
            {
                acceso.desconectar();
            }
        }

        private void btn_Atras2_Click(object sender, EventArgs e)
        {
            this.Close();
            pantallaProfesional.Show();
        }

        private void btn_NuevaCita_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Paciente = int.Parse(cmb_IdPaciente.Items[cmb_Paciente.SelectedIndex].ToString());
                string fecha = dtp_fecha.Value.ToString();
                string observaciones = txt_Observaciones.Text;

                if (fecha != null && fecha != "" && observaciones != null)
                {
                    SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_NuevaCita]", acceso.getConnection());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@idPa", SqlDbType.Int));
                    sqlCommand.Parameters.Add(new SqlParameter("@idPro", SqlDbType.Int));
                    sqlCommand.Parameters.Add(new SqlParameter("@ci", SqlDbType.DateTime));
                    sqlCommand.Parameters.Add(new SqlParameter("@ob", SqlDbType.VarChar, 200));
                    sqlCommand.Parameters["@idPa"].Value = id_Paciente;
                    sqlCommand.Parameters["@idPro"].Value = id_Profesional;
                    sqlCommand.Parameters["@ci"].Value = new DateTimeConverter().ConvertFromString(fecha);
                    sqlCommand.Parameters["@ob"].Value = observaciones;
                    try
                    {
                        acceso.conectar();

                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido conectar: " + ex.Message);
                    }
                    finally
                    {
                        acceso.desconectar();

                        btn_CitasDia2.PerformClick();
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Debes escoger valores antes de introducir una fecha");
            }
        }
    }
}
