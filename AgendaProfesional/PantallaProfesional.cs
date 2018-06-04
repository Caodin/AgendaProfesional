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
    public partial class PantallaProfesional : Form
    {
        AccesoBBDD acceso = new AccesoBBDD();
        Login login;
        int id_Profesional;

        public PantallaProfesional(Login login, int id_Profesional)
        {
            this.login = login;
            this.id_Profesional = id_Profesional;

            InitializeComponent();
        }

        private void btn_CitasDia_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_citasDia]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            
            try
            {
                acceso.conectar();

                SqlDataReader dr = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                this.dtg_Citas.DataSource = dt;

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

        private void btn_CitasSemana_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_citasSemana]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;


            try
            {
                acceso.conectar();

                SqlDataReader dr = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                this.dtg_Citas.DataSource = dt;

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

        private void btn_VerHistorial_Click(object sender, EventArgs e)
        {
            {
                SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_VerHistorial]", acceso.getConnection());
                sqlCommand.CommandType = CommandType.StoredProcedure;

                
                //txb_Historial

                try
                {
                    acceso.conectar();

                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dr.Close();

                    txt_NombrePaciente.Text = (String) dt.Rows[0].ItemArray.GetValue(0);
                    txt_ApellidoPaciente.Text = (String) dt.Rows[0].ItemArray.GetValue(1);
                    txt_ApellidoMedico.Text = (String) dt.Rows[0].ItemArray.GetValue(2);
                    txt_Observaciones.Text = (String) dt.Rows[0].ItemArray.GetValue(3);

                   
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

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            PantallaAdmin pantallaAdmin = new PantallaAdmin(login, this, id_Profesional);
            this.Hide();
            pantallaAdmin.Show();
        }

        private void btn_salir2_Click(object sender, EventArgs e)
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

            login.Close();
            this.Close();
        }
    }
}
