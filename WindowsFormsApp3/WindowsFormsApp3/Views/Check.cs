using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Check : Form
    {
        //La variable menuAnterior guardara el menu el cual pasamos para llegar a esta pantalla
        Menu menuAnterior;

        //Generamos un objeto de la clase Conexion para por der hacer llamadas a la base de datos
        Conexion conexion;

        //Generamos una variable la cual nos ayudara a conocer en que menu estamos
        //La variable empezara con el valor Inaguracion debido a que el Frame inica en ese Menu
        string menuSeleccionado = "Inaguracion";

        //La siguiente variable guardara el nombre del usuario seleccionado
        string itemSeleccionado = "";

        //La siguiente variable guardara el id del usuario seleccionado en los Menus
        int id;

        //Esta variable solo se utilizara en el menu de Cerveza para llevar la cuenta del usuario
        int countCervezas;

        //El valor menu sera el form anterior
        public Check(Menu menu)
        {
            InitializeComponent();

            //Inicializamos el objeto Conexion
            conexion = new Conexion();

            //Con el metodo getAllUsers() obtendremos todos los nombres registrados en la base de datos
            //para acomodarlos en nuestro comboBox
            cbBoxNombre.Items.AddRange(conexion.getAllNamesUsers().ToArray());

            //El siguiente metodo ubicara nuestro Form en medio de la pantalla del usuario
            this.CenterToScreen();

            //Ocultamos el boton con el cual se registrara una entrega
            btnEntregado.Visible = false;

            //menuAnterior guarda el menu el cual pasamos para llegar a esta pantalla
            menuAnterior = menu;

            //Creamos el evento de cierre del Form
            this.FormClosing += Check_FormClosing;

            //Generamos el evento para detectar cuando el valor seleccionado en el combobox cambie
            cbBoxNombre.SelectedValueChanged += CbBoxNombre_SelectedValueChanged;

        }

        private void CbBoxNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            //Tomaremos el nombre seleccionado en el comboBox
            itemSeleccionado = (string) cbBoxNombre.SelectedItem;

            //Le hacemos un split por espacios para que nos quede un arreglo con los nombres del usuario
            var array = itemSeleccionado.Split(' ');

            //Utilizaremos el siguiente for para conjuntar todos los nombres del usuario en un string
            //debido a que un usuario puede tener muchos nombres
            string nombres = "";
            for (int i = 0; i < array.Length-2; i++)
            {
                nombres += array[i] + " ";
            }

            //Le removemos el espacio que se le agrega al ultimo del for
            nombres = nombres.Remove(nombres.Length-1, 1);

            //Buscamos en la base de datos su id y lo guardamos 
            //sabiendo que el penultimo valor del arreglo es el apellido paterno y el ultimo el materno
            id = conexion.getIdUser(nombres, array[array.Length-2], array[array.Length-1]);

            //Usaremos un switch para conocer en que Menu se encuentra
            bool res;
            switch (menuSeleccionado)
            {
                case "Inaguracion":
                    //Verificaremos si ya la fue entregado Inaguracion
                    res = conexion.getEntregadoInaguracion(id);
                    ChecarEntregado(res);
                    break;

                case "Alimentos":
                    //Verificaremos si ya la fue entregado Alimentos
                    res = conexion.getEntregadoAlimentos(id);
                    ChecarEntregado(res);
                    break;

                case "Cerveza":
                    //Verificaremos si ya la fue entregado Alimentos
                    countCervezas = conexion.getEntregadoCerveza(id);
                    if (countCervezas == 0)
                    {
                        ChecarEntregado(false);
                    }
                    else
                    {
                        ChecarEntregado(true);
                        btnEntregado.Text = "Tomara otras 2";
                        btnEntregado.Visible = true;
                        btnEntregado.Enabled = true;
                    }
                    break;
                case "Tennis":
                    break;
                case "Golf":
                    break;
                case "Concierto":
                    break;
                case "Clausura":
                    break;
            }
        }

        void ChecarEntregado(bool res)
        {
            //res contiene un bool (true / false) el cual lo retorna nuestra Conexion
            if (res)
            {
                //En dado caso de haber sido entregado 
                //Encenderemos el boton de Check y mostraremos un mensaje
                btnTrue.Enabled = true;
                lblEntregado.Text = "Producto entregado";
                btnFalse.Enabled = false;
                btnEntregado.Visible = false;
                btnEntregado.Enabled = false;
            }
            else
            {
                //En dado caso de NO haber sido entregado 
                //Apagaremos el boton de Check y mostraremos un mensaje
                //Encenderemos el boton de la tacha
                //Habilitaremos un boton el cual nos dira cuando ya haya sido entregado
                btnEntregado.Visible = true;
                btnEntregado.Enabled = true;
                btnEntregado.Text = "Marcar como entregado";
                btnFalse.Enabled = true;
                lblEntregado.Text = "Producto NO entregado";
                btnTrue.Enabled = false;
            }
        }

        void reiniciarComponentes()
        {
            //Este metodo reiniciara los componentes tal y como empezaron al principio de abrir el Frame
            //Se utilizara para los cambios de Menus
            btnTrue.Enabled = false;
            btnFalse.Enabled = false;
            btnEntregado.Visible = false;
            btnEntregado.Enabled = false;
            lblEntregado.Text = "Verificando entrega";
            cbBoxNombre.Text = "";
        }

        private void Check_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mostramos el menu que anteriormente pasamos
            menuAnterior.Visible = true;
        }

        private void btnInaguracion_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnInaguracion
            lblTitulo.Text = btnInaguracion.Text;

            //Intercambiamos el valor de menuSeleccionado por Inaguracion
            menuSeleccionado = "Inaguracion";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnAlimentos
            lblTitulo.Text = btnAlimentos.Text;

            //Intercambiamos el valor de menuSeleccionado por Alimentos
            menuSeleccionado = "Alimentos";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnCerveza_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnCerveza
            lblTitulo.Text = btnCerveza.Text;

            //Intercambiamos el valor de menuSeleccionado por Cerveza
            menuSeleccionado = "Cerveza";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnTennis
            lblTitulo.Text = btnTennis.Text;

            //Intercambiamos el valor de menuSeleccionado por Tennis
            menuSeleccionado = "Tennis";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnGolf_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnGolf
            lblTitulo.Text = btnGolf.Text;

            //Intercambiamos el valor de menuSeleccionado por Golf
            menuSeleccionado = "Golf";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnConcierto
            lblTitulo.Text = btnConcierto.Text;

            //Intercambiamos el valor de menuSeleccionado por Concierto
            menuSeleccionado = "Concierto";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnClausura_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnClausura
            lblTitulo.Text = btnClausura.Text;

            //Intercambiamos el valor de menuSeleccionado por Clausura
            menuSeleccionado = "Clausura";

            //Reiniciamos los componentes para los cambios de Menus
            reiniciarComponentes();
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            //Usaremos un switch para conocer en que Menu se encuentra
            switch (menuSeleccionado)
            {
                case "Inaguracion":
                    //Le agregaremos la entrega en la base de datos al usuario de Inaguracion
                    conexion.setEntregadoInaguracion(id);
                    ChecarEntregado(true);
                    break;

                case "Alimentos":
                    //Le agregaremos la entrega en la base de datos al usuario de Alimentos
                    conexion.setEntregadoAlimentos(id);
                    ChecarEntregado(true);
                    break;

                case "Cerveza":
                    conexion.setEntregadoCerveza(id, countCervezas += 2);
                    ChecarEntregado(true);
                    btnEntregado.Text = "Tomara otras 2";
                    btnEntregado.Visible = true;
                    btnEntregado.Enabled = true;
                    break;

                case "Tennis":
                    break;

                case "Golf":
                    break;

                case "Concierto":
                    break;

                case "Clausura":
                    break;
            }
        }
    }
}
