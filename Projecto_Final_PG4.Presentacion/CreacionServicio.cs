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
    public partial class CreacionServicio : Form
    {
        public CreacionServicio()
        {
            InitializeComponent();
            CargarComboClientes();
            CargarComboTipoServicios();
            CargarCitas();
            cbxClientes.Text = "Seleccione";
            cbxTiposServicios.Text = "Seleccione";
            cbx_VehiculosDisp.Text = "Seleccione";
            dgv_Servicios.AutoResizeColumnHeadersHeight();
            dgv_Servicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //LogicaServicios logicaservicios = new LogicaServicios();

        private void cargarTodasPlacas() 
        {
            /*LogicaAutomotores_ autos = new LogicaAutomotores_();
            List<Automotores_> lstAutos = new List<Automotores_>();

            lstAutos = autos.BuscarTodos();

            for (int i = 0; i < lstAutos.Count; i++)
            {
                cbx_VehiculosDisp.Items.Add(lstAutos[i].Placa.ToString() + " " +
                lstAutos[i].Tipo_vehiculo.ToString() + " " + lstAutos[i].Marca.ToString());
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCitas()
        {

            //Logica.LogicaServicios servicios = new Logica.LogicaServicios();
            //List<Entidades.Servicios> lstServicios = new List<Entidades.Servicios>();

            //lstServicios = servicios.BuscarTodos();
            //dgv_Servicios.DataSource = lstServicios;
            //this.dgv_Servicios.Columns["Servicio_seleccionado"].Visible = false;
            //this.dgv_Servicios.Columns["ID_Servicio"].Visible = false;
            //this.dgv_Servicios.Columns["ID_Tipo_Servicio"].Visible = false;
        }

        private void CargarComboClientes()
        {

            /*LogicaPersonas personas = new LogicaPersonas();

            List<Persona> lstPersona = new List<Persona>();

            lstPersona = personas.BuscarTodos();

            for (int i = 0; i < lstPersona.Count; i++)
            {
                cbxClientes.Items.Add(lstPersona[i].Cedula.ToString() + " " +
                lstPersona[i].Nombre.ToString() + " " + lstPersona[i].Apellido.ToString());
            }*/
        }

        private void CargarComboTipoServicios()
        {

            /*Logica.LogicaTipoServicio TipoServicio = new Logica.LogicaTipoServicio();

            List<TipoServicio> lstTipoServicio = new List<TipoServicio>();

            lstTipoServicio = TipoServicio.BuscarTodos();

            cbxTiposServicios.ValueMember = "ID_Tipo_Servicio";

            cbxTiposServicios.DisplayMember = "Descripcion_Servicio";
            //agregao el resultado de la consulta al combo
            cbxTiposServicios.DataSource = lstTipoServicio;
            //para que no sea editable la lista
            cbxTiposServicios.DropDownStyle = ComboBoxStyle.DropDownList;*/
        }

        private void cbxTiposServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxTiposServicios.SelectedValue.ToString() == "1")
            //{
            //    //Agrega los valores que ocupa y no esten agregados desde la otra opcion por que no tendria identificador
            //    var items = new[] {
            //   new { Text = "Cambio Aceite", Value = "1"},
            //   new { Text = "Cambio Liquidos", Value = "2" },
            //   new { Text = "Revision Menor", Value = "3" },
            //   new { Text = "Cambio Llantas", Value = "4" },
            //   new { Text = "Rotacion Llantas", Value = "5" },
            //   new { Text = "Revision Motor", Value = "6" },
            //   new { Text = "Revision de Caja Cambios", Value = "7" },
            //   new { Text = "Revision de Frenos", Value = "8" },
            //   new { Text = "Cambio de frenos", Value = "9" }
            //    };
            //    cbxServiciosRequeridos.DataSource = items;
            //}
            //if (cbxTiposServicios.SelectedValue.ToString() == "2")
            //{
            //    //Agrega los valores que ocupa y no esten agregados desde la otra opcion por que no tendria identificador
            //    var items = new[] {
            //   new { Text = "Cambio Aceite", Value = "1"},
            //   new { Text = "Cambio Liquidos", Value = "2" },
            //   new { Text = "Revision Menor", Value = "3" },
            //   new {Text = "Cambio Llantas", Value = "4" },
            //   new { Text = "Rotacion Llantas", Value = "5" },
            //   new { Text = "Revision Motor", Value = "6" },
            //   new { Text = "Revision de Caja Cambios", Value = "7" },
            //   new { Text = "Revision de Frenos", Value = "8" },
            //   new { Text = "Cambio de frenos", Value = "9" }

            //};
            //    cbxServiciosRequeridos.DataSource = items;
            //}
            //if (cbxTiposServicios.SelectedValue.ToString() == "3")
            //{
            //    //Agrega los valores que ocupa y no esten agregados desde la otra opcion por que no tendria identificador
            //    var items = new[] {
            //   new { Text = "Cambio Aceite", Value = "1"},
            //   new { Text = "Cambio Liquidos", Value = "2" },
            //   new { Text = "Revision Menor", Value = "3" },
            //   new {Text = "Cambio Llantas", Value = "4" },
            //   new { Text = "Rotacion Llantas", Value = "5" },
            //   new { Text = "Revision Motor", Value = "6" },
            //   new { Text = "Revision de Caja Cambios", Value = "7" },
            //   new { Text = "Revision de Frenos", Value = "8" },
            //   new { Text = "Cambio de frenos", Value = "9" }

            //};
            //    cbxServiciosRequeridos.DataSource = items;
            //}
            //if (cbxTiposServicios.SelectedValue.ToString() == "4")
            //{
            //    //Agrega los valores que ocupa y no esten agregados desde la otra opcion por que no tendria identificador
            //    var items = new[] {
            //   new { Text = "Cambio Aceite", Value = "1".Trim().ToString() },
            //   new { Text = "Cambio Liquidos", Value = "2" },
            //   new { Text = "Revision Menor", Value = "3" },
            //   new {Text = "Cambio Llantas", Value = "4" },
            //   new { Text = "Rotacion Llantas", Value = "5" },
            //   new { Text = "Revision Motor", Value = "6" },
            //   new { Text = "Revision de Caja Cambios", Value = "7" },
            //   new { Text = "Revision de Frenos", Value = "8" },
            //   new { Text = "Cambio de frenos", Value = "9" }
            //    };

            //    cbxServiciosRequeridos.DisplayMember = "Text";
            //    cbxServiciosRequeridos.ValueMember = "Value";

            //    for (int i = 0; i < cbxServiciosRequeridos.Items.Count; i++)
            //    {
            //        cbxServiciosRequeridos.SetItemChecked(i, true);
            //    }
            //}
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (cbxClientes.Text.Equals("Seleccione"))
            {
                MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                    "Favor revisar los campos solicitados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Today > dtpFechaServicio.Value)
            {
                MessageBox.Show("No se puede agendar una cita \n para fechas anteriores al dia de hoy",
                                "Error al agendar una cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                //Servicios obServicios = new Servicios();
                //obServicios.ID_Servicio = 0;
                //obServicios.ID_Tipo_servicio = Convert.ToInt32(cbxTiposServicios.SelectedValue.ToString());
                //string placa = cbx_VehiculosDisp.Text.Trim();
                //placa = (Convert.ToString(placa)).Substring(0, 6);
                //obServicios.Placa = placa;//cbx_VehiculosDisp.SelectedItem.ToString();
                //obServicios.Fecha = dtpFechaServicio.Value;
                //obServicios.Descripcion_servicio = cbxTiposServicios.Text.ToString();
                //string cedula = cbxClientes.Text.Trim();
                //cedula = (Convert.ToString(cedula)).Substring(0, 9);
                //obServicios.ID_Cliente = int.Parse(cedula);//int.Parse(cbxClientes.Text.ToString());
                //logicaservicios.Insertar(obServicios);

                
                foreach (object itemChecked in cklxServiciosRequeridos.CheckedItems)
                {
                    //Servicios serv = new Servicios();
                    //serv.ID_Servicio = 0;//int
                    //serv.ID_Cliente = int.Parse(cedula);//int
                    //serv.Placa = placa;//string
                    //serv.Servicio_seleccionado = itemChecked.ToString();//string
                    ////lstx_Servicios.Items.Add(itemChecked);
                    //logicaservicios.InsertarServicioCliente(serv);

                }

                CargarCitas();
                limpiarDatos();
                cbxTiposServicios.Text = "Seleccione";
                limpiarDatos();
                cbxClientes.Text = "Seleccione";
                MessageBox.Show("Se agrego el servicio del cliente correctamente","Servicio agregado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void limpiarDatos()
        {
            for (int i = 0; i < cklxServiciosRequeridos.Items.Count; i++)
            {
                cklxServiciosRequeridos.SetItemChecked(i, false);
            }
            cbxClientes.Text = "Seleccione";
            cbx_VehiculosDisp.Text = "Seleccione";

            for (int i = 0; i < cbx_VehiculosDisp.Items.Count; i++)
            {
                cbx_VehiculosDisp.Items.RemoveAt(i);
                //cbx_VehiculosDisp.SelectedIndex = -1;
            }
            lstx_Servicios.Items.Clear();
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void dgv_Servicios_MouseClick(object sender, MouseEventArgs e)
        {
            lstx_Servicios.Items.Clear();
            string cedula;
            cedula = dgv_Servicios.CurrentRow.Cells[4].Value.ToString();
            //List<Servicios> listaserv = new List<Servicios>();
            //listaserv = logicaservicios.BuscarServ(int.Parse(cedula));

            //foreach (var item in listaserv)
            //{
            //    lstx_Servicios.Items.Add(item.Servicio_seleccionado);
            //}
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LogicaAutoClientes autos = new LogicaAutoClientes();
            //List<Auto_Cliente> lstAutos = new List<Auto_Cliente>();

            string sub = cbxClientes.Text.Trim();
            sub = (Convert.ToString(sub)).Substring(0, 9);

            //lstAutos = autos.Buscar(int.Parse(sub));
            
            for (int i = 0; i <= cbx_VehiculosDisp.Items.Count; i++)
            {
                if (cbx_VehiculosDisp.Items.Count == 0)
                {

                }
                else 
                {
                    cbx_VehiculosDisp.Items.RemoveAt(i);
                    i--;
                }
            }
            
            //for (int i = 0; i < lstAutos.Count; i++)
            //{
            //    cbx_VehiculosDisp.Items.Add(lstAutos[i].Placa_automotores.ToString() + " " +
            //    lstAutos[i].Marca_automotores.ToString() +" " + lstAutos[i].Modelo_automotores.ToString());
            //}
        }
    }
}

