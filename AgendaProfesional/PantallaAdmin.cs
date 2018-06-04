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
    public partial class PantallaAdmin: Form
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
    }
}
