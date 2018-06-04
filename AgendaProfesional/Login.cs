using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace AgendaProfesional
{
    public partial class Login : Form
    {
        AccesoBBDD acceso = new AccesoBBDD();

        //profesional no válido
        const int id_ProfesionalInvalido = -1;
        //id del Profesional
        int id_Profesional = id_ProfesionalInvalido;
        //Seleccionar los campos de operación
        //string query = "SELECT * FROM Tienda.dbo.ARTICULOS ";
        //SqlCommand cmdVerRUT = new SqlCommand(query, conn);

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("[dbo].[sp_LogIn]", acceso.getConnection());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@ID_profesional", SqlDbType.Int));
            sqlCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 30));
            sqlCommand.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar, 10));
            sqlCommand.Parameters["@ID_profesional"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@email"].Value = txt_Email.Text;
            sqlCommand.Parameters["@pass"].Value = txt_Password.Text;

            try
            {
                acceso.conectar();

                sqlCommand.ExecuteNonQuery();
             
                id_Profesional = (int) sqlCommand.Parameters["@ID_profesional"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar: " + ex.Message);
            }
            finally
            {
                acceso.desconectar();
            }

            if (id_Profesional != id_ProfesionalInvalido)
            {
                MessageBox.Show("Loggin válido, bienvenido usuario " + id_Profesional);
                PantallaProfesional pantalla = new PantallaProfesional(this, id_Profesional);
                this.Hide();
                pantalla.Show();
            }
            else
            {
                MessageBox.Show("Loggin inválido, vuelva a inentarlo, por favor");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



/*private void refactorizar_Click( object sender, EventArgs e)
{
//Leer archivo configuracion
ConnectionStringSettings setting =
ConfigurationManager .ConnectionStrings[ "TiendaConnectionString" ];
//conectar con la base de datos
SqlConnection conn = new
SqlConnection (setting.ConnectionString);
//Seleccionar los campos de operación
string query = "SELECT * FROM Tienda.dbo.ARTICULOS ";
SqlCommand cmdVerRUT = new SqlCommand (query, conn);
//Mostrarlos en la grid
try
{
//Abrir la conexión
conn.Open();
//Ejecutar comando
SqlDataReader rdr = cmdVerRUT.ExecuteReader();
DataTable dt = new DataTable ();
dt.Load(rdr);
this .dataGridCampodeOperacion.DataSource = dt;
//Cierro el Datareader, cerrara tb la conexión
rdr.Close();
}
catch ( Exception ex)
{
MessageBox .Show( "No se ha podido conectar" + ex.Message);
}
}
*/