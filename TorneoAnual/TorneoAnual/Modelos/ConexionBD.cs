using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoAnual.Modelos
{
    class ConexionBD
    {
        public ConexionBD() { }

        public static int AltaEmpleado(Usuario usuario)
        {
            int res = 0;

            try
            {
                using (var conn = new SqlConnection("Data Source = localhost; initial catalog = Checador; Integrated Security = True "))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "AltaEmpleados";
                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@ApellidoP", usuario.ApellidoP);
                        command.Parameters.AddWithValue("@ApellidoM", usuario.ApellidoM);
                        command.Parameters.AddWithValue("@Numero", usuario.Tel);
                        command.Parameters.AddWithValue("@Foto", usuario.Foto);
                        command.Parameters.AddWithValue("@Huella", usuario.Huella);

                        SqlParameter param = new SqlParameter("Id", SqlDbType.Int);
                        param.Value = 0;
                        param.Direction = ParameterDirection.Output;
                        command.Parameters.Add(param);

                        res = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta al empleado: " + ex.Message, "Error en Alta");
            }

            return res;

        }


    }
}

