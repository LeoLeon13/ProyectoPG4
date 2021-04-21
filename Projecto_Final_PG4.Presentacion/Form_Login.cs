using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projecto_Final_PG4.Presentacion.SRComunicacionPersona;

namespace Projecto_Final_PG4.Presentacion
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
            txt_Password.MaxLength = 8;

        }

        /*LogicPersonas persona = new LogicaPersonas();
        LogicaAutoClientes logicaAutoCli = new LogicaAutoClientes();
        LogicaServicios logicaServicios = new LogicaServicios();*/

        //private MensajeSocket mensajeSocket = new MensajeSocket();
        //private SocketCliente cliente = new SocketCliente();
        private string usuario;
        private string pass;
        public static char tipoUsuario;
        public static int placa;
        public static string cedula;
        public static string userinfo;
        public static string nombreUsr;
        public static string apellidoUsr;
        public static int Idcliente;
        public bool aprovado = false;

        public void login()
        {
            SRComunicacionPersona.PrimerServicioClient servicioClient = new PrimerServicioClient();
            PersonaDTO persona = new PersonaDTO();
            persona.Cedula = int.Parse(txt_User.Text).ToString();//persona.Buscar(int.Parse(txt_User.Text));
            cedula = int.Parse(txt_User.Text).ToString();
            //servicioClient.ObtenerPersonaID(int.Parse(txt_User.Text.ToString()));
            var listapersonas = servicioClient.ObtenerPersonaID(int.Parse(cedula));//servicioClient.ObtenerTodos().lista;
            var listaClientes = servicioClient.ObtenerTodosClientes().lista;
            var listaServicios = servicioClient.ObtenerTodosServicio().lista;

            //List<PersonaDTO> listaPersonas = new List<PersonaDTO>().ToList();//cliente.ClienteObjeto(mensajeSocket).ListaPersonas;
            //List<AutoClienteDTO> listaAutoCli = new List<AutoClienteDTO>().ToList();//logicaAutoCli.BuscarTodos2();
            //List<ServiciosDTO> listaServicios2 = new List<ServiciosDTO>().ToList();//logicaServicios.BuscarTodos();

            usuario = txt_User.Text;
            pass = txt_Password.Text;
            tipoUsuario = char.Parse(listapersonas.EsEmpleado);//char.Parse(listapersonas[0].EsEmpleado.ToString());
            nombreUsr = listapersonas.Nombre;//listapersonas[0].Nombre.ToString();
            apellidoUsr = listapersonas.Apellido;//listapersonas[0].Apellido.ToString();

            if (tipoUsuario.ToString().Equals("S"))
            {
                if (txt_Password.Text.Equals(pass) && txt_User.Text.Equals(usuario))
                {
                    //this.Close();
                    aprovado = true;
                    string mensaje = String.Format("Bienvenido {0},{1}", nombreUsr,apellidoUsr);
                    MessageBox.Show(mensaje, "Sistema de mantenimiento de autos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalida intente de nuevo", "Error al ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (listapersonas != null)
                {
                    //PersonaDTO personaEncontrada = listapersonas[0];
                    usuario = listapersonas.Cedula;//listapersonas[0].Cedula.ToString();
                    pass = listapersonas.Pass;//listapersonas[0].Pass.ToString();
                    tipoUsuario = char.Parse(listapersonas.EsEmpleado);//char.Parse(listapersonas[0].EsEmpleado.ToString());

                    for (int i = 0; i < listaClientes.Length; i++)
                    {
                        cedula = listaClientes[i].Cedula.ToString();//int.Parse(listaClientes[i].Cedula.ToString());


                        if (usuario.Equals(cedula.ToString()))
                        {
                            placa = int.Parse(listaClientes[i].Placa.ToString());
                            Idcliente = int.Parse(cedula);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Al buscar usuario la lista esta vacia revisar");
                }

                if (txt_Password.Text.Equals(pass) && txt_User.Text.Equals(usuario))
                {
                    aprovado = true;
                    string mensaje = String.Format("Bienvenido {0},{1}", nombreUsr,apellidoUsr);
                    MessageBox.Show(mensaje, "Sistema de mantenimiento de autos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalida intente de nuevo", "Error al ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login();
            if (aprovado == true)
            {
                this.Close();
            }
            userinfo = txt_User.Text;
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aprovado == true)
            {

            }
            else
            {
                var res = MessageBox.Show(this, "Se cerra el sistema por completo enverdad desea Salir", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res != DialogResult.No)
                {
                    //Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void chbx_MostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_MostrarPass.Checked)
            {
                string a = txt_Password.Text;
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void limpiar()
        {
            txt_User.Text = "";
            txt_Password.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();

                if (aprovado == true)
                {
                    this.Close();
                }
            }
        }

        private void txt_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    if ((int)System.Convert.ToChar(e.KeyChar) == 13)
                    {
                        txt_Password.Focus();
                    }
                    e.Handled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error al validar el parametro #1 seleccion de Int o String",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
