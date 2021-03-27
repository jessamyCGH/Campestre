using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Campestre
{
    class Conexion
    {
        string cadena = @"Data Source= DESKTOP-JH5TK9P;Initial Catalog=Torneo_Golf; Integrated Security= True";
        public SqlConnection conectarBDT = new SqlConnection();

        public Conexion()
        {
            conectarBDT.ConnectionString = cadena;

        }
        public void abrir()
        {

            try
            {
                conectarBDT.Open();

                Console.WriteLine(" CONEXION ESTABLECIDA ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(" ERROR AL ABRIR LA BD " + ex.Message);
            }

        }
        public void cerrar()
        {
            conectarBDT.Close();
        }

    }
}
