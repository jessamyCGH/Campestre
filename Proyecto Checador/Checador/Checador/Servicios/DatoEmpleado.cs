using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

using Checador.Modelos;
using System.Data.Common;

namespace Checador.Servicios
{
  public class DatoEmpleado
    {
        public DatoEmpleado() { }  

        public static List<Empleado> MuestraEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                using (var conn = new SqlConnection("Data Source= DESKTOP-JH5TK9P;Initial Catalog=Checador; Integrated Security= True "))
                {
                    conn.Open();
                    
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "MuestraEmpleados";

                        using (DbDataReader dr = command.ExecuteReader())
                        {
                            if(dr.HasRows)
                            {
                                while(dr.Read())
                                {
                                    Empleado emp = new Empleado();
                                    emp.Id = int.Parse(dr["Id"].ToString());
                                    emp.Nombre = dr["Nombre"].ToString();
                                    emp.ApellidoP = dr["ApellidoP"].ToString();
                                    emp.Celular = dr["Celular"].ToString();
                            //        emp.Foto = dr["Foto"].ToString();
                                    if (dr["Huella"].ToString() != "")
                                        emp.Huella = (byte[])dr["Huella"];
                                    else
                                        emp.Huella = null;

                                    listaEmpleados.Add(emp);

                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar Empleados: " + ex.Message, "Error");  
            }

            return listaEmpleados;
        }

        public static int Alta(Empleado empleado)
        {
            int res = 0;

            try
            {
                using (var conn = new SqlConnection("Data Source= DESKTOP-JH5TK9P;Initial Catalog=Checador; Integrated Security= True"))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Alta";
                        command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        command.Parameters.AddWithValue("@ApellidoP", empleado.ApellidoP);
                        command.Parameters.AddWithValue("@ApellidoM", empleado.ApellidoM);
                        command.Parameters.AddWithValue("@Correo", empleado.Correo);
                        command.Parameters.AddWithValue("@Celular", empleado.Celular);
                        command.Parameters.AddWithValue("@Club", empleado.Club);
                        command.Parameters.AddWithValue("@Foto", empleado.Foto);
                        command.Parameters.AddWithValue("@Huella", empleado.Huella);

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
