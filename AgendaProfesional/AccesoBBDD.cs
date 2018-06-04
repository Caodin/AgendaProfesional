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

        public AccesoBBDD()
        {
            //por defecto
            creaConexion();
        }

        public AccesoBBDD(String cadenaDeConexion)
        {
            this.cadenaDeConexion = cadenaDeConexion;
            creaConexion();
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        private void creaConexion()
        {
            setting = ConfigurationManager.ConnectionStrings[cadenaDeConexion];
            conn = new SqlConnection(setting.ConnectionString);
        }

        public void conectar()
        {
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
