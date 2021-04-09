using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using WindowsFormsApp3.Modelos;

namespace WindowsFormsApp3
{
    class Conexion
    {
        string cadena = @"Data Source= {nombrePC};Initial Catalog=TorneoAnual; Integrated Security= True";
        public SqlConnection conectarBDT = new SqlConnection();

        public Conexion()
        {
            conectarBDT.ConnectionString = cadena;
        }

        

        public SqlDataReader buscar(string Nombrer)
        {
            {
                cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
                conectarBDT.ConnectionString = cadena;
                conectarBDT.Open();
                SqlCommand command = new SqlCommand("SELECT Nombre, Club, Celular, Correo, Paterno, Materno from dbo.Usuario where Nombre like", conectarBDT);

                SqlDataReader reader = command.ExecuteReader();

                return reader;

            }


        }

        public ObservableCollection<string> obtenerCategoriasGolf()
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Categoria", conectarBDT);

            SqlDataReader reader = command.ExecuteReader();

            ObservableCollection<string> categorias = new ObservableCollection<string>();

            while (reader.Read())
            {
                if (reader["Tipo"].Equals("G"))
                {
                    categorias.Add((string)reader["descripcion"]);
                }
            } 

            conectarBDT.Close();

            return categorias;

        }

        public ObservableCollection<string> obtenerCategoriasTennis()
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Categoria", conectarBDT);

            SqlDataReader reader = command.ExecuteReader();

            ObservableCollection<string> categorias = new ObservableCollection<string>();

            while (reader.Read())
            {
                if (reader["Tipo"].Equals("T"))
                {
                    categorias.Add((string)reader["descripcion"]);

                }
            }

            conectarBDT.Close();

            return categorias;

        }

        public ObservableCollection<string> obtenerTorneosActuales()
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Torneo", conectarBDT);

            SqlDataReader reader = command.ExecuteReader();

            ObservableCollection<string> torneos = new ObservableCollection<string>();

            while (reader.Read())
            {
                torneos.Add((string)reader["descripcion"]);
            }

             conectarBDT.Close();

            return torneos;
        }
    }
}
