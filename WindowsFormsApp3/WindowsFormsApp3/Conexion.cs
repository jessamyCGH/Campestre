using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    class Conexion
    {
        string cadena = @"Data Source= {nombrePC};Initial Catalog=Torneo_Golf; Integrated Security= True";
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


        public SqlDataReader obtenerCategorias()
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("Select * from dbo.Categorias", conectarBDT);

            SqlDataReader reader = command.ExecuteReader();
            
              /* while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0} {1} {2}", reader["id_cat"],reader["Descripcion"], reader["Tipo"]));
                }*/
            
           // conectarBDT.Close();
            return reader;

        }   
    }
}
