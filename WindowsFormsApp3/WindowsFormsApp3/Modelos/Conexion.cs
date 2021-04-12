using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using WindowsFormsApp3.Modelos;
using System.Windows.Forms;
using System.Data;

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



        /*public SqlDataReader buscar(string Nombrer)
        {
            {
                cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
                conectarBDT.ConnectionString = cadena;
                conectarBDT.Open();
                SqlCommand command = new SqlCommand("SELECT Nombre, Club, Celular, Correo, Paterno, Materno from dbo.Usuario where Nombre like", conectarBDT);

                SqlDataReader reader = command.ExecuteReader();

                return reader;

            }


        }*/

        public int getIdUser(string nombre, string apellidop, string apellidom)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id FROM Usuarios WHERE nombre = @nombre AND apellidoP = @apellidoP AND apellidoM = @apellidoM", conectarBDT);
            command.Parameters.AddWithValue("nombre", nombre);
            command.Parameters.AddWithValue("apellidoP", apellidop);
            command.Parameters.AddWithValue("apellidoM", apellidom);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            var x = (int)reader.GetValue(0);

            conectarBDT.Close();
            return x;
        }

        #region Inaguracion
        public bool getEntregadoInaguracion(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,fecha FROM Inaguracion WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
                conectarBDT.Close();
            {
                return false;
            }
        }

        public void setEntregadoInaguracion(int id)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Inaguracion]([id_user],[fecha])VALUES(@id_user, @fecha)", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);
            command.Parameters.AddWithValue("fecha", DateTime.Now);

            command.ExecuteReader();
            conectarBDT.Close();
        }

        #endregion

        #region Alimentos

        public bool getEntregadoAlimentos(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,fecha FROM Alimentos WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
            {
                conectarBDT.Close();
                return false;
            }
        }

        public void setEntregadoAlimentos(int id)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Alimentos]([id_user],[fecha])VALUES(@id_user, @fecha)", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);
            command.Parameters.AddWithValue("fecha", DateTime.Now);

            command.ExecuteReader();
            conectarBDT.Close();
        }

        #endregion

        #region Cerveza

        public int getEntregadoCerveza(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,countCervezas,fecha FROM Cerveza WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                var i = (int)reader["countCervezas"];
                conectarBDT.Close();
                return i;
            }
            else
            {
                conectarBDT.Close();
                return 0;
            }
        }

        public void setEntregadoCerveza(int id, int countCervezas)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,countCervezas,fecha FROM Cerveza WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                command = new SqlCommand("UPDATE [dbo].[Cerveza] SET [countCervezas] = @count WHERE id_user = @id", conectarBDT);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("count", countCervezas);

                command.ExecuteReader();
                conectarBDT.Close();
            }
            else
            {
                reader.Close();
                command = new SqlCommand("INSERT INTO [dbo].[Cerveza]([id_user],[countCervezas],[fecha])VALUES(@id_user,@countCervezas, @fecha)", conectarBDT);
                command.Parameters.AddWithValue("id_user", id);
                command.Parameters.AddWithValue("countCervezas", countCervezas);
                command.Parameters.AddWithValue("fecha", DateTime.Now);

                command.ExecuteReader();
                conectarBDT.Close();
            }
        }

        #endregion

        #region Tennis
        public bool getEntregadoTennis(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,fecha FROM Tennis WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
            {
                conectarBDT.Close();
                return false;
            }
        }

        public void setEntregadoTennis(int id)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Tennis]([id_user],[fecha])VALUES(@id_user, @fecha)", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);
            command.Parameters.AddWithValue("fecha", DateTime.Now);

            command.ExecuteReader();
            conectarBDT.Close();
        }

        #endregion

        #region Golf
        public bool getEntregadoGolf(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,fecha FROM Golf WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
            {
                conectarBDT.Close();
                return false;
            }
        }

        public void setEntregadoGolf(int id)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Golf]([id_user],[fecha])VALUES(@id_user, @fecha)", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);
            command.Parameters.AddWithValue("fecha", DateTime.Now);

            command.ExecuteReader();
            conectarBDT.Close();
        }

        #endregion

        #region Concierto
        public bool getEntregadoConcierto(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,fecha FROM Concierto WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
            {
                conectarBDT.Close();
                return false;
            }
        }

        public void setEntregadoConcierto(int id)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Concierto]([id_user],[fecha])VALUES(@id_user, @fecha)", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);
            command.Parameters.AddWithValue("fecha", DateTime.Now);

            command.ExecuteReader();
            conectarBDT.Close();
        }

        #endregion

        #region Clausura
        public bool getEntregadoClausura(int id_user)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT id_user,fecha FROM Clausura WHERE id_user = @id_user", conectarBDT);
            command.Parameters.AddWithValue("id_user", id_user);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
            {
                conectarBDT.Close();
                return false;
            }
        }

        public void setEntregadoClausura(int id)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Clausura]([id_user],[fecha])VALUES(@id_user, @fecha)", conectarBDT);
            command.Parameters.AddWithValue("id_user", id);
            command.Parameters.AddWithValue("fecha", DateTime.Now);

            command.ExecuteReader();
            conectarBDT.Close();
        }

        #endregion


        public void insertar(string nombre, string apellidoP, string apellidoM, string correo, string tel, string club, int id_cat, string huella, string imagen, int id_torneo)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            // SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Usuarios]([nombre],[apellidoP],[apellidoM],[correo],[tel],[club],[id_cat],[huella],[imagen],[id_torneo])VALUES(@nombre, @apellidoP, @apellidoM, @correo, @tel, @club, @id_cat, @huella, @imagen, @id_torneo, @fecha_registro)", conectarBDT);

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Usuarios]([nombre],[apellidoP],[apellidoM],[correo],[tel],[club],[id_cat],[huella],[imagen],[id_torneo])VALUES(@nombre, @apellidoP, @apellidoM, @correo, @tel, @club, @id_cat, @huella, @imagen, @id_torneo, @fecha_registro)", conectarBDT);
            command.Parameters.AddWithValue("nombre", nombre);
            command.Parameters.AddWithValue("apellidoP", apellidoP);
            command.Parameters.AddWithValue("apellidoM", apellidoM);
            command.Parameters.AddWithValue("correo", correo);
            command.Parameters.AddWithValue("tel", tel);
            command.Parameters.AddWithValue("club", club);
            command.Parameters.AddWithValue("id_cat", id_cat);
            command.Parameters.AddWithValue("huella", null);
            command.Parameters.AddWithValue("imagen", null);
            command.Parameters.AddWithValue("id_torneo", id_torneo);
            command.Parameters.AddWithValue("fecha_registro", DateTime.Now);

            try
            {
                command.ExecuteReader();
                conectarBDT.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }

        }

        public bool Buscar(Usuario usuario)
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT nombre FROM Clausura WHERE nombre = @nombre", conectarBDT);
            command.Parameters.AddWithValue("nombre", usuario.Nombre);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                conectarBDT.Close();
                return true;
            }
            else
            {
                conectarBDT.Close();
                return false;
            }
        }




        public ObservableCollection<string> getAllNamesUsers()
        {
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();

            SqlCommand command = new SqlCommand("SELECT nombre,apellidoP,apellidoM FROM Usuarios", conectarBDT);

            SqlDataReader reader = command.ExecuteReader();

            ObservableCollection<string> nombres = new ObservableCollection<string>();

            while (reader.Read())
            {
                string nombre = "";

                nombre += (string)reader["nombre"] + " ";
                nombre += (string)reader["apellidoP"] + " ";
                nombre += (string)reader["apellidoM"];

                nombres.Add(nombre);
            }

            conectarBDT.Close();

            return nombres;
        }

        #region categorias

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
        #endregion


        public void Insertar(string nombre, string apellidoP, string apellidoM, string correo, string tel, string club, int id_cat, string huella, string imagen, int id_torneo)
        { 
            cadena = cadena.Replace("{nombrePC}", Environment.MachineName);
            conectarBDT.ConnectionString = cadena;
            conectarBDT.Open();


            //SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Usuario]([nombre],[apellidoP],[apellidoM],[correo],[tel],[club],[id_cat],[huella],[imagen],[id_torneo])VALUES(@nombre, @apellidoP, @apellidoM,@correo, @tel, @club,@id_cat,@huella,@imagen, @id_torneo)", conectarBDT);
            SqlCommand command = new SqlCommand("sp_insertar");
            try
            {
                command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellidoP", apellidoP);
            command.Parameters.AddWithValue("@apellidoM", apellidoM);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@club", club);
            command.Parameters.AddWithValue("@id_cat", id_cat);
            command.Parameters.AddWithValue("@huella", huella);
            command.Parameters.AddWithValue("@imagen", imagen);
            command.Parameters.AddWithValue("@id_torneo", id_torneo);
            command.Parameters.AddWithValue("@fecha_registro", DateTime.Now);


           
                command.ExecuteNonQuery();
                conectarBDT.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("error " + ex.Message);
            }
            conectarBDT.Close();

        }

    }
}
