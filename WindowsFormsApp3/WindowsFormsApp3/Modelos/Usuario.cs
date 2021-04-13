using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Modelos
{
    class Usuario
    {

        Single _FinguerPrint;
        string _imagen;


        public string nombre { get; set; }

        public string apellidoP { get; set; }

        public string apellidoM { get; set; }

        public string club { get; set; }

        public string tel { get; set; }

        public string correo { get; set; }

        public string Fecha { get; set; }

        public string CategoriaDescripcion { get; set; }

        public string CategoriaTipo { get; set; }
        public string Torneo { get; set; }

       public byte [] huella { get; set; }



        public Usuario()
        {

        }
        public Usuario (string Nombre, String CategoriaTipo, string Club, string tel, string Correo, string Apaterno, string Amaterno)
            {

            this.Nombre = Nombre;
            this.CategoriaTipo = CategoriaTipo;
            this.club = Club;
            this.tel = tel;
            this.correo = Correo;
            this.apellidoP = Apaterno;
            this.apellidoM = Amaterno;

            }

        //public string Imagen { get; set; }

    }
}
