using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creamos un objeto del Form Menu para despues modificar sus propiedades
            Menu menu = new Menu();
            //Al objeto anterior le damos un titulo
            menu.Text = "Menu";
            //Un tipo de borde para el objeto menu
            menu.FormBorderStyle = FormBorderStyle.FixedDialog;
            //Le removemos el boton de minimizar al objeto menu
            menu.MinimizeBox = false;
            //Le removemos el boton de maximizar al objeto menu
            menu.MaximizeBox = false;

            //Le damos el objeto menu al cual le cambiamos sus propiedades a la aplicacion
            Application.Run(menu);
        }
    }
}
