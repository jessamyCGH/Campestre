using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Modelos
{
    class Usuario
    {
        public string Nombre { get; set; }

        public string Apaterno { get; set; }

        public string Amaterno { get; set; }

        public string Club { get; set; }

        public string Celular { get; set; }

        public string Correo { get; set; }

        public string Fecha { get; set; }

        public string CategoriaDescripcion { get; set; }

        public string CategoriaTipo { get; set; }


        public Usuario()
        {

        }
        public Usuario (string Nombre, String CategoriaTipo, string Club, string Celular, string Correo, string Apaterno, string Amaterno)
            {

            this.Nombre = Nombre;
            this.CategoriaTipo = CategoriaTipo;
            this.Club = Club;
            this.Celular = Celular;
            this.Correo = Correo;
            this.Apaterno = Apaterno;
            this.Amaterno = Amaterno;

            }

        //public string Imagen { get; set; }

    }
}
