using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Projecto_Final_PG4.Entidades;
//using Projecto_Final_PG4.Logica;

namespace Projecto_Final_PG4.Presentacion
{
    public partial class Automotores : Form
    {
        public Automotores()
        {
            InitializeComponent();
            //cargar_datagrid();
            lbl_IDAutomotores.Visible = false;
            txt_ID.Visible = false;
            lbl_AutoCliente.Visible = false;
            txt_ID_AutoMotor.Visible = false;
        }

        private void Automotores_Load(object sender, EventArgs e)
        {
            /*cbx_Tipo_Vehiculo.SelectedIndex = 0;
            cbx_Clientes.SelectedIndex = 0;
            txt_ID.Enabled = false;
            txt_ID_AutoMotor.Enabled = false;
            cbx_TipoVehiculoM.Enabled = false;
            cbx_Tipo_Vehiculo.Enabled = true;
            inavilitar();
            cargar_clientes();
            cargar_datagrid();

            txt_ID_AutoMotor.Text = "";*/
        }

        /*private LogicaAutomotores_ LogicaAut = new Logica.LogicaAutomotores_();
        private LogicaAutoClientes LogicaAuCli = new Logica.LogicaAutoClientes();
        private LogicaPersonas LogiPer = new Logica.LogicaPersonas();*/


        private void cargar_clientes()
        {
            /*List<Persona> datos = LogiPer.BuscarTodos();
            foreach (var item in datos)
            {
                cbx_Clientes.Items.Add(item.Cedula.Trim().ToString());
            }

            cbx_Clientes.SelectedIndex = 0;*/
        }

        private void Validar_Agregar()
        {

            string TipoVehiculo = cbx_Tipo_Vehiculo.SelectedItem.ToString();


            if (TipoVehiculo.Equals("Motos"))
            {
                string Cliente = cbx_Clientes.SelectedItem.ToString();
                string Mensajero = cbx_EsMensajero.SelectedItem.ToString();
                string Clasica = cbx_EsClasica.SelectedItem.ToString();
                string Manual = cbx_Manual.SelectedItem.ToString();
                string nulo1 = "X";
                string nulo3 = "X";
                string nulo4 = "X";

                if (txt_Placa.Text == string.Empty || txt_Marca.Text == string.Empty || txt_Modelo.Text == string.Empty
                                       || txt_Combustible.Text == string.Empty || txt_Cilindraje.Text == string.Empty || Manual.Equals("Seleccione")
                                       || Mensajero.Equals("Seleccione") || Clasica.Equals("Seleccione") || Cliente.Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                        "Favor revisar los campos solicitados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Automotores_ Auto = new Automotores_
                    //(
                    //txt_Placa.Text,
                    //txt_Marca.Text,
                    //txt_Modelo.Text,
                    //txt_Combustible.Text,
                    //int.Parse(txt_Cilindraje.Text),
                    //char.Parse(nulo1),
                    //char.Parse(Manual),
                    //char.Parse(nulo3),
                    //char.Parse(nulo4),
                    //char.Parse(Mensajero),
                    //char.Parse(Clasica),
                    //TipoVehiculo
                    //);

                    //Auto_Cliente AutoCliente = new Auto_Cliente
                    //    (
                    //        Cliente,
                    //        txt_Placa.Text
                    //    );

                    //LogicaAuCli.Insertar(AutoCliente);
                    //LogicaAut.Insertar(Auto);
                    MessageBox.Show("Se Agrego Correctamente el Registro");
                    LimpiarDatos();
                    cargar_datagrid();
                }
            }

            if (TipoVehiculo.Equals("Camiones"))
            {
                string Cliente = cbx_Clientes.SelectedItem.ToString();
                string Manual = cbx_Manual.SelectedItem.ToString();
                string TransEspecial = cbx_TransEspecial.SelectedItem.ToString();
                string TieneContenedor = cbx_TieneContenedor.SelectedItem.ToString();
                string nulo1 = "X";
                string nulo2 = "X";
                string nulo3 = "X";

                if (txt_Placa.Text == string.Empty || txt_Marca.Text == string.Empty || txt_Modelo.Text == string.Empty
                                       || txt_Combustible.Text == string.Empty || txt_Cilindraje.Text == string.Empty || Manual.Equals("Seleccione")
                                       || TransEspecial.Equals("Seleccione") || TieneContenedor.Equals("Seleccione") || Cliente.Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                        "Favor revisar los campos solicitados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Automotores_ Auto = new Automotores_
                    //(
                    //txt_Placa.Text,
                    //txt_Marca.Text,
                    //txt_Modelo.Text,
                    //txt_Combustible.Text,
                    //int.Parse(txt_Cilindraje.Text),
                    //char.Parse(nulo1),
                    //char.Parse(Manual),
                    //char.Parse(TransEspecial),
                    //char.Parse(TieneContenedor),
                    //char.Parse(nulo2),
                    //char.Parse(nulo3),
                    //TipoVehiculo
                    //);

                    //Auto_Cliente AutoCliente = new Auto_Cliente
                    //    (
                    //        Cliente,
                    //        txt_Placa.Text
                    //    );

                    //LogicaAuCli.Insertar(AutoCliente);
                    //LogicaAut.Insertar(Auto);
                    MessageBox.Show("Se Agrego Correctamente el Registro");
                    LimpiarDatos();
                    cargar_datagrid();
                }
            }

            if (TipoVehiculo.Equals("Autos"))
            {
                string Cliente = cbx_Clientes.SelectedItem.ToString();
                string TransPublico = cbx_TransPublico.SelectedItem.ToString();
                string Manual = cbx_Manual.SelectedItem.ToString();

                string nulo1 = "X";
                string nulo2 = "X";
                string nulo3 = "X";
                string nulo4 = "X";

                if (txt_Placa.Text == string.Empty || txt_Marca.Text == string.Empty || txt_Modelo.Text == string.Empty
                                       || txt_Combustible.Text == string.Empty || txt_Cilindraje.Text == string.Empty || Manual.Equals("Seleccione")
                                       || TransPublico.Equals("Seleccione") || Cliente.Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                        "Favor revisar los campos solicitados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Automotores_ Auto = new Automotores_
                    //(
                    //txt_Placa.Text,
                    //txt_Marca.Text,
                    //txt_Modelo.Text,
                    //txt_Combustible.Text,
                    //int.Parse(txt_Cilindraje.Text),
                    //char.Parse(TransPublico),
                    //char.Parse(Manual),
                    //char.Parse(nulo1),
                    //char.Parse(nulo2),
                    //char.Parse(nulo3),
                    //char.Parse(nulo4),
                    //TipoVehiculo
                    //);

                    //Auto_Cliente AutoCliente = new Auto_Cliente
                    //    (
                    //        Cliente,
                    //        txt_Placa.Text
                    //    );

                    //LogicaAuCli.Insertar(AutoCliente);
                    //LogicaAut.Insertar(Auto);
                    MessageBox.Show("Se Agrego Correctamente el Registro");
                    LimpiarDatos();
                    cargar_datagrid();
                }
            }
        }

        private void LimpiarDatos() 
        {
            cbx_Tipo_Vehiculo.Enabled = true;
            txt_ID_AutoMotor.Text = "";
            txt_ID.Text = "";
            txt_Placa.Text = "";
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_Combustible.Text = "";
            txt_Cilindraje.Text = "";
            cbx_Clientes.SelectedIndex = 0;
            cbx_TransPublico.SelectedIndex = 0;
            cbx_Manual.SelectedIndex = 0;
            cbx_TransEspecial.SelectedIndex = 0;
            cbx_TieneContenedor.SelectedIndex = 0;
            cbx_EsMensajero.SelectedIndex = 0;
            cbx_EsClasica.SelectedIndex = 0;

            cbx_Tipo_Vehiculo.SelectedIndex = 0;
            cargar_datagrid();
        }

        private void inavilitar()
        {
            txt_Placa.Visible = false;
            txt_Marca.Visible = false;
            txt_Modelo.Visible = false;
            txt_Combustible.Visible = false;
            txt_Cilindraje.Visible = false;
            cbx_TransPublico.Visible = false;
            cbx_Manual.Visible = false;
            cbx_TransEspecial.Visible = false;
            cbx_TieneContenedor.Visible = false;
            cbx_EsMensajero.Visible = false;
            cbx_EsClasica.Visible = false;

            lbl_Placa.Visible = false;
            lbl_Marca.Visible = false;
            lbl_Modelo.Visible = false;
            lbl_Combustible.Visible = false;
            Lbl_Cilindraje.Visible = false;
            lbl_EsTransPublico.Visible = false;
            lbl_EsManual.Visible = false;
            lbl_EsTransEspecial.Visible = false;
            lbl_TieneContenedor.Visible = false;
            lbl_EsMensajero.Visible = false;
            lbl_EsClasica.Visible = false;
        }

        private void cargar_datagrid()
        {
            dtg_Clientes_Vehiculos.DataSource = null;
            //dtg_Clientes_Vehiculos.DataSource = LogicaAuCli.BuscarTodos2();

            this.dtg_Clientes_Vehiculos.Columns["id_automotor"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["esClasica_automotores"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["esManual_automotores"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["esMensajero_automotores"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["esTransEspe_automotores"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["esTransPublico_automotores"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["id_autocliente"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["cedula_autocliente"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["placa_autocliente"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["tipo_Vehiculo_automotores"].Visible = false;
            this.dtg_Clientes_Vehiculos.Columns["tiene_contenedor_automotores"].Visible = false;
        }

        private void Validar_Modificar()
        {
            string TipoVehiculo = cbx_TipoVehiculoM.SelectedItem.ToString();

            if (TipoVehiculo.Equals("Motos"))
            {
                string Cliente = cbx_Clientes.SelectedItem.ToString();
                string Mensajero = cbx_EsMensajero.SelectedItem.ToString();
                string Clasica = cbx_EsClasica.SelectedItem.ToString();
                string Manual = cbx_Manual.SelectedItem.ToString();
                string nulo1 = "X";
                string nulo3 = "X";
                string nulo4 = "X";

                if (txt_Placa.Text == string.Empty || txt_Marca.Text == string.Empty || txt_Modelo.Text == string.Empty
                                       || txt_Combustible.Text == string.Empty || txt_Cilindraje.Text == string.Empty || Manual.Equals("Seleccione")
                                       || Mensajero.Equals("Seleccione") || Clasica.Equals("Seleccione") || Cliente.Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                        "Favor revisar los campos solicitados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //Automotores_ Auto = new Automotores_();

                    //Auto.Placa = txt_Placa.Text;
                    //Auto.Marca = txt_Marca.Text;
                    //Auto.Modelo = txt_Modelo.Text;
                    //Auto.Tipo_combustible = txt_Combustible.Text;
                    //Auto.Cilindraje = int.Parse(txt_Cilindraje.Text);
                    //Auto.EsTransPublico = char.Parse(nulo1);
                    //Auto.EsManual = char.Parse(Manual);
                    //Auto.EsTransEspe = char.Parse(nulo3);
                    //Auto.Tiene_contenedor = char.Parse(nulo4);
                    //Auto.EsMensajero = char.Parse(Mensajero);
                    //Auto.EsClasica = char.Parse(Clasica);
                    //Auto.Tipo_vehiculo = TipoVehiculo;

                    //LogicaAut.Modificar(Auto);

                    //Auto_Cliente AutoCliente = new Auto_Cliente();

                    //AutoCliente.Cedula_autocliente = Cliente;
                    //AutoCliente.Placa_autocliente = txt_Placa.Text;
                    //LogicaAuCli.Modificar(AutoCliente);

                    MessageBox.Show("Se Modifico Correctamente el Registro");
                    LimpiarDatos();
                    cargar_datagrid();

                }


            }

            if (TipoVehiculo.Equals("Camiones"))
            {
                string Cliente = cbx_Clientes.SelectedItem.ToString();
                string TransporteEspe = cbx_TransEspecial.SelectedItem.ToString();
                string TieneConte = cbx_TieneContenedor.SelectedItem.ToString();
                string Manual = cbx_Manual.SelectedItem.ToString();
                string nulo1 = "X";
                string nulo3 = "X";
                string nulo4 = "X";

                if (txt_Placa.Text == string.Empty || txt_Marca.Text == string.Empty || txt_Modelo.Text == string.Empty
                                       || txt_Combustible.Text == string.Empty || txt_Cilindraje.Text == string.Empty || Manual.Equals("Seleccione")
                                       || TransporteEspe.Equals("Seleccione") || TieneConte.Equals("Seleccione") || Cliente.Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                        "Favor revisar los campos solicitados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Automotores_ Auto = new Automotores_();

                    //Auto.Placa = txt_Placa.Text;
                    //Auto.Marca = txt_Marca.Text;
                    //Auto.Modelo = txt_Modelo.Text;
                    //Auto.Tipo_combustible = txt_Combustible.Text;
                    //Auto.Cilindraje = int.Parse(txt_Cilindraje.Text);
                    //Auto.EsTransPublico = char.Parse(nulo1);
                    //Auto.EsManual = char.Parse(Manual);
                    //Auto.EsTransEspe = char.Parse(TransporteEspe);
                    //Auto.Tiene_contenedor = char.Parse(TieneConte);
                    //Auto.EsMensajero = char.Parse(nulo3);
                    //Auto.EsClasica = char.Parse(nulo4);
                    //Auto.Tipo_vehiculo = TipoVehiculo;

                    //LogicaAut.Modificar(Auto);

                    //Auto_Cliente AutoCliente = new Auto_Cliente();

                    //AutoCliente.Cedula_autocliente = Cliente;
                    //AutoCliente.Placa_autocliente = txt_Placa.Text;
                    //LogicaAuCli.Modificar(AutoCliente);

                    MessageBox.Show("Se Modifico Correctamente el Registro");
                    LimpiarDatos();
                    cargar_datagrid();
                }
            }

            if (TipoVehiculo.Equals("Autos"))
            {
                string Cliente = cbx_Clientes.SelectedItem.ToString();
                string TransportePub = cbx_TransPublico.SelectedItem.ToString();
                string Manual = cbx_Manual.SelectedItem.ToString();
                string nulo1 = "X";
                string nulo2 = "X";
                string nulo3 = "X";
                string nulo4 = "X";

                if (txt_Placa.Text == string.Empty || txt_Marca.Text == string.Empty || txt_Modelo.Text == string.Empty
                                       || txt_Combustible.Text == string.Empty || txt_Cilindraje.Text == string.Empty || Manual.Equals("Seleccione")
                                       || TransportePub.Equals("Seleccione") || Cliente.Equals("Seleccione"))
                {
                    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                        "Favor revisar los campos solicitados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Automotores_ Auto = new Automotores_();

                    //Auto.Placa = txt_Placa.Text;
                    //Auto.Marca = txt_Marca.Text;
                    //Auto.Modelo = txt_Modelo.Text;
                    //Auto.Tipo_combustible = txt_Combustible.Text;
                    //Auto.Cilindraje = int.Parse(txt_Cilindraje.Text);
                    //Auto.EsTransPublico = char.Parse(TransportePub);
                    //Auto.EsManual = char.Parse(Manual);
                    //Auto.EsTransEspe = char.Parse(nulo1);
                    //Auto.Tiene_contenedor = char.Parse(nulo2);
                    //Auto.EsMensajero = char.Parse(nulo3);
                    //Auto.EsClasica = char.Parse(nulo4);
                    //Auto.Tipo_vehiculo = TipoVehiculo;

                    //LogicaAut.Modificar(Auto);

                    //Auto_Cliente AutoCliente = new Auto_Cliente();

                    //AutoCliente.Cedula_autocliente = Cliente;
                    //AutoCliente.Placa_autocliente = txt_Placa.Text;
                    //LogicaAuCli.Modificar(AutoCliente);

                    MessageBox.Show("Se Modifico Correctamente el Registro");
                    LimpiarDatos();
                    cargar_datagrid();
                }
            }
            txt_Placa.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Validar_Agregar();
        }

        private void cbx_Tipo_Vehiculo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txt_Placa.Visible = true;
            string Combo = cbx_Tipo_Vehiculo.SelectedItem.ToString();


            if (Combo.Equals("Seleccione"))
            {
                txt_ID.Enabled = false;
                txt_Placa.Visible = false;
                txt_Marca.Visible = false;
                txt_Modelo.Visible = false;
                txt_Combustible.Visible = false;
                txt_Cilindraje.Visible = false;
                cbx_TransPublico.Visible = false;
                cbx_Manual.Visible = false;
                cbx_TransEspecial.Visible = false;
                cbx_TieneContenedor.Visible = false;
                cbx_EsMensajero.Visible = false;
                cbx_EsClasica.Visible = false;

                lbl_Placa.Visible = false;
                lbl_Marca.Visible = false;
                lbl_Modelo.Visible = false;
                lbl_Combustible.Visible = false;
                Lbl_Cilindraje.Visible = false;
                lbl_EsTransPublico.Visible = false;
                lbl_EsManual.Visible = false;
                lbl_EsTransEspecial.Visible = false;
                lbl_TieneContenedor.Visible = false;
                lbl_EsMensajero.Visible = false;
                lbl_EsClasica.Visible = false;
            }

            if (Combo.Equals("Motos"))
            {
                inavilitar();

                txt_ID.Enabled = false;
                txt_Placa.Visible = true;
                txt_Marca.Visible = true;
                txt_Modelo.Visible = true;
                txt_Combustible.Visible = true;
                txt_Cilindraje.Visible = true;
                cbx_EsMensajero.Visible = true;
                cbx_EsClasica.Visible = true;
                cbx_Manual.Visible = true;

                lbl_Placa.Visible = true;
                lbl_Marca.Visible = true;
                lbl_Modelo.Visible = true;
                lbl_Combustible.Visible = true;
                Lbl_Cilindraje.Visible = true;
                lbl_EsMensajero.Visible = true;
                lbl_EsClasica.Visible = true;
                lbl_EsManual.Visible = true;
                cbx_EsMensajero.SelectedIndex = 0;
                cbx_EsClasica.SelectedIndex = 0;
                cbx_Manual.SelectedIndex = 0;

                txt_ID_AutoMotor.Text = "";
            }

            if (Combo.Equals("Camiones"))
            {
                inavilitar();

                txt_ID.Enabled = false;
                txt_Placa.Visible = true;
                txt_Marca.Visible = true;
                txt_Modelo.Visible = true;
                txt_Combustible.Visible = true;
                txt_Cilindraje.Visible = true;
                cbx_Manual.Visible = true;
                cbx_TransEspecial.Visible = true;
                cbx_TieneContenedor.Visible = true;

                lbl_Placa.Visible = true;
                lbl_Marca.Visible = true;
                lbl_Modelo.Visible = true;
                lbl_Combustible.Visible = true;
                Lbl_Cilindraje.Visible = true;
                lbl_EsManual.Visible = true;
                lbl_EsTransEspecial.Visible = true;
                lbl_TieneContenedor.Visible = true;

                cbx_Manual.SelectedIndex = 0;
                cbx_TransEspecial.SelectedIndex = 0;
                cbx_TieneContenedor.SelectedIndex = 0;

                txt_ID_AutoMotor.Text = "";
            }

            if (Combo.Equals("Autos"))
            {
                inavilitar();

                txt_ID.Enabled = false;
                txt_Placa.Visible = true;
                txt_Marca.Visible = true;
                txt_Modelo.Visible = true;
                txt_Combustible.Visible = true;
                txt_Cilindraje.Visible = true;
                cbx_TransPublico.Visible = true;
                cbx_Manual.Visible = true;

                lbl_Placa.Visible = true;
                lbl_Marca.Visible = true;
                lbl_Modelo.Visible = true;
                lbl_Combustible.Visible = true;
                Lbl_Cilindraje.Visible = true;
                lbl_EsTransPublico.Visible = true;
                lbl_EsManual.Visible = true;

                cbx_TransPublico.SelectedIndex = 0;
                cbx_Manual.SelectedIndex = 0;

                txt_ID_AutoMotor.Text = "";
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_Placa.Text = "";
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_Combustible.Text = "";
            txt_Cilindraje.Text = "";
            cbx_Clientes.SelectedIndex = 0;
            cbx_TransPublico.SelectedIndex = 0;
            cbx_Manual.SelectedIndex = 0;
            cbx_TransEspecial.SelectedIndex = 0;
            cbx_TieneContenedor.SelectedIndex = 0;
            cbx_EsMensajero.SelectedIndex = 0;
            cbx_EsClasica.SelectedIndex = 0;
            cbx_TipoVehiculoM.Text = "";
            cbx_TipoVehiculoM.Enabled = false;

            cbx_Tipo_Vehiculo.Enabled = true;
            cbx_Tipo_Vehiculo.Text = "Seleccione";
            inavilitar();
            

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Validar_Modificar();
            cbx_Tipo_Vehiculo.Enabled = true;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //LogicaAut.Eliminar(txt_Placa.Text);
                //LogicaAuCli.Eliminar(txt_ID_AutoMotor.Text);
                

                MessageBox.Show("Se Elimino Correctamente el registro","Eliminacion de Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarDatos();
                cargar_datagrid();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al eliminar el dato de la tabla automotores: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
            inavilitar();
            
        }

        private void dtg_Clientes_Vehiculos_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Placa.Enabled = false;
            cbx_TipoVehiculoM.Enabled = false;
            cbx_Tipo_Vehiculo.Enabled = false;
            string TipoVehiculo = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
            txt_ID.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[2].Value.ToString();
            txt_ID_AutoMotor.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[14].Value.ToString();

            if (TipoVehiculo.Equals("Motos") && int.Parse(txt_ID.Text) >= 1)
            {
                inavilitar();

                txt_ID.Enabled = false;
                txt_Placa.Visible = true;
                txt_Marca.Visible = true;
                txt_Modelo.Visible = true;
                txt_Combustible.Visible = true;
                txt_Cilindraje.Visible = true;
                cbx_EsMensajero.Visible = true;
                cbx_EsClasica.Visible = true;
                cbx_Manual.Visible = true;

                lbl_Placa.Visible = true;
                lbl_Marca.Visible = true;
                lbl_Modelo.Visible = true;
                lbl_Combustible.Visible = true;
                Lbl_Cilindraje.Visible = true;
                lbl_EsMensajero.Visible = true;
                lbl_EsClasica.Visible = true;
                lbl_EsManual.Visible = true;
                cbx_EsMensajero.SelectedIndex = 0;
                cbx_EsClasica.SelectedIndex = 0;
                cbx_Manual.SelectedIndex = 0;
                

                txt_Placa.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[3].Value.ToString();
                txt_Marca.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[4].Value.ToString();
                txt_Modelo.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[5].Value.ToString();
                txt_Combustible.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[7].Value.ToString();
                txt_Cilindraje.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[6].Value.ToString();
                cbx_Manual.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[9].Value.ToString();
                cbx_EsMensajero.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[10].Value.ToString();//
                cbx_EsClasica.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[8].Value.ToString();//
                string text = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
                cbx_TipoVehiculoM.Text = text;
                //lbl_TipoVehiculo.Text = "Tipo de Vehiculo" + " " + text.ToString();
                //cbx_Tipo_Vehiculo.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
                cbx_Clientes.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[15].Value.ToString();


            }

            if (TipoVehiculo.Equals("Camiones") && int.Parse(txt_ID.Text) >= 1)
            {
                inavilitar();

                txt_ID.Enabled = false;
                txt_Placa.Visible = true;
                txt_Marca.Visible = true;
                txt_Modelo.Visible = true;
                txt_Combustible.Visible = true;
                txt_Cilindraje.Visible = true;
                cbx_Manual.Visible = true;
                cbx_TransEspecial.Visible = true;
                cbx_TieneContenedor.Visible = true;

                lbl_Placa.Visible = true;
                lbl_Marca.Visible = true;
                lbl_Modelo.Visible = true;
                lbl_Combustible.Visible = true;
                Lbl_Cilindraje.Visible = true;
                lbl_EsManual.Visible = true;
                lbl_EsTransEspecial.Visible = true;
                lbl_TieneContenedor.Visible = true;

                cbx_Manual.SelectedIndex = 0;
                cbx_TransEspecial.SelectedIndex = 0;
                cbx_TieneContenedor.SelectedIndex = 0;

                txt_ID.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[2].Value.ToString();
                txt_Placa.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[3].Value.ToString();
                txt_Marca.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[4].Value.ToString();
                txt_Modelo.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[5].Value.ToString();
                txt_Combustible.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[7].Value.ToString();
                txt_Cilindraje.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[6].Value.ToString();
                cbx_Manual.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[9].Value.ToString();
                cbx_TransEspecial.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[11].Value.ToString();
                cbx_TieneContenedor.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[17].Value.ToString();///////
                string text = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
                cbx_TipoVehiculoM.Text = text;
                //lbl_TipoVehiculo.Text = "Tipo de Vehiculo" + " " + text.ToString();
                //cbx_Tipo_Vehiculo.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
                cbx_Clientes.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[15].Value.ToString();

            }

            if (TipoVehiculo.Equals("Autos") && int.Parse(txt_ID.Text) >= 1)
            {
                inavilitar();

                txt_ID.Enabled = false;
                txt_Placa.Visible = true;
                txt_Marca.Visible = true;
                txt_Modelo.Visible = true;
                txt_Combustible.Visible = true;
                txt_Cilindraje.Visible = true;
                cbx_TransPublico.Visible = true;
                cbx_Manual.Visible = true;

                lbl_Placa.Visible = true;
                lbl_Marca.Visible = true;
                lbl_Modelo.Visible = true;
                lbl_Combustible.Visible = true;
                Lbl_Cilindraje.Visible = true;
                lbl_EsTransPublico.Visible = true;
                lbl_EsManual.Visible = true;

                cbx_TransPublico.SelectedIndex = 0;
                cbx_Manual.SelectedIndex = 0;

                txt_ID.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[2].Value.ToString();
                txt_Placa.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[3].Value.ToString();
                txt_Marca.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[4].Value.ToString();
                txt_Modelo.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[5].Value.ToString();
                txt_Combustible.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[7].Value.ToString();
                txt_Cilindraje.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[6].Value.ToString();
                cbx_Manual.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[9].Value.ToString();
                cbx_TransPublico.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[12].Value.ToString();
                cbx_TieneContenedor.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[17].Value.ToString();///////
                string text = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
                cbx_TipoVehiculoM.Text = text;
                //lbl_TipoVehiculo.Text = "Tipo de Vehiculo" + " " + text.ToString();
                //cbx_Tipo_Vehiculo.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[13].Value.ToString();
                cbx_Clientes.Text = dtg_Clientes_Vehiculos.CurrentRow.Cells[15].Value.ToString();
            }
            txt_Placa.Enabled = true;
        }

        private void cbx_Tipo_Vehiculo_MouseClick(object sender, MouseEventArgs e)
        {
            LimpiarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*List<Auto_Cliente> personaBuscar = LogicaAuCli.Buscar(int.Parse(txt_Buscar.Text));

            if (personaBuscar != null)
            {
                dtg_Clientes_Vehiculos.DataSource = null;
                dtg_Clientes_Vehiculos.DataSource = LogicaAuCli.Buscar(int.Parse(txt_Buscar.Text));
            }*/
        }

        private void btBuscarTodos_Click(object sender, EventArgs e)
        {
            /*dtg_Clientes_Vehiculos.DataSource = null;
            dtg_Clientes_Vehiculos.DataSource = LogicaAuCli.BuscarTodos2();
            txt_Buscar.Text = "";*/
        }
    }
}
