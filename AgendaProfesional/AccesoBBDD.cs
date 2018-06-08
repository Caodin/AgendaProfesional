using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProfesional
{
    public class AccesoBBDD
    {
        //Leer archivo configuracion
        static ConnectionStringSettings setting;
        //Cadena de conexión por defecto
        String cadenaDeConexion = "ClinicaConnectionString";
        //conectar con la base de datos
        SqlConnection conn;

        //Crea el acceso a la BBDD que estará por defecto, Clinica, y conecta con creaConexion
        public AccesoBBDD()
        {
            //por defecto
            creaConexion();
        }

        //Crea el acceso a la base de datos que le indiquemos, si quisiéramos, y conecta con creaConexion
        public AccesoBBDD(String cadenaDeConexion)
        {
            this.cadenaDeConexion = cadenaDeConexion;
            creaConexion();
        }

        //Devuelve la conexión concreta que tenemos configurada, para los SQL string o procedimientos, ...
        public SqlConnection getConnection()
        {
            return conn;
        }

        //Conectamos, usando la conexión que hemos definido
        private void creaConexion()
        {
            setting = ConfigurationManager.ConnectionStrings[cadenaDeConexion];
            conn = new SqlConnection(setting.ConnectionString);
        }

        //Abre la conexión, necesario para ejecutar cualquier cosa
        public void conectar()
        {
            conn.Open();
        }

        //Cierra la conexión, para no dejar conexiones abiertas
        public void desconectar()
        {
            conn.Close();
        }
    }
}
