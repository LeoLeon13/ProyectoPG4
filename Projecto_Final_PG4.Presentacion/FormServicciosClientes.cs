using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projecto_Final_PG4.Presentacion.SRComunicacionPersona;
//using Projecto_Final_PG4.Entidades;
//using Projecto_Final_PG4.Logica;

namespace Projecto_Final_PG4.Presentacion
{
    public partial class FormServicciosClientes : Form
    {
        //private Logica.LogicaClientes logicaCliente = new Logica.LogicaClientes();
        //private Logica.LogicaServicios logicaServicio = new Logica.LogicaServicios();

        public FormServicciosClientes()
        {
            InitializeComponent();
            cargarDatosGrid();
            dgvServiciosClientes.AutoResizeColumnHeadersHeight();
            dgvServiciosClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void cargarDatosGrid()
        {
            //LogicaServicios serv = new LogicaServicios();
            SRComunicacionPersona.PrimerServicioClient servicio = new SRComunicacionPersona.PrimerServicioClient();

            dgvServiciosClientes.DataSource = null;
            if (Form_Login.tipoUsuario.ToString().Equals("S"))
            {
                dgvServiciosClientes.DataSource = servicio.ObtenerTodosServicio().lista;
            }
            else
            {
                BindingSource source = new BindingSource();
                source.DataSource = servicio.ObtenerServicioID(int.Parse(Form_Login.IdServicio.ToString()));
                dgvServiciosClientes.DataSource = source;
                dgvServiciosClientes.AutoResizeColumns();
                //dgvServiciosClientes.DataSource = servicio.ObtenerServicioID(int.Parse(Form_Login.Idcliente.ToString()));//serv.Buscar(int.Parse(Form_Login.Idcliente.ToString()));
            }

            ////List<Servicios> servicioPersona = logicaServicio.BuscarTodos();

            ////dgvServiciosClientes.DataSource = servicioPersona;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            SRComunicacionPersona.PrimerServicioClient servicio = new PrimerServicioClient();
            BindingSource source = new BindingSource();
            source.DataSource = servicio.ObtenerServicioID(int.Parse(tbxBuscar.Text));
            dgvServiciosClientes.DataSource = source;
            dgvServiciosClientes.AutoResizeColumns();

            //try
            //{

            //    //Logica.LogicaPersonas servicios = new Logica.LogicaPersonas();
            //    //List<Entidades.Servicios> lstServicios = new List<Entidades.Servicios>();
            //    //lstServicios = servicios.Buscar(int.Parse(tbxBuscar.Text));

            //    List<Servicios> servicioPersona = logicaServicio.Buscar(int.Parse(tbxBuscar.Text));

            //    dgvServiciosClientes.DataSource = servicioPersona;


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Form1.btnBuscar_Click=> Error: " + ex.Message);
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void btn_BuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {

                //List<Servicios> servicioPersona = logicaServicio.BuscarTodos();
                SRComunicacionPersona.PrimerServicioClient servicio = new SRComunicacionPersona.PrimerServicioClient();
                var lstServicios = servicio.ObtenerTodosServicio().lista;//servico.ObtenerServicioID(int.Parse(Form_Login.IdServicio.ToString()));
                dgvServiciosClientes.DataSource = servicio.ObtenerTodosServicio().lista;

                for (int i = 0; i < lstServicios.Length; i++)
                {
                    if (lstServicios[i].ID_servicio.Equals(int.Parse(Form_Login.IdServicio.ToString())))
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = servicio.ObtenerServicioID(int.Parse(Form_Login.IdServicio.ToString()));
                        dgvServiciosClientes.DataSource = source;
                        dgvServiciosClientes.AutoResizeColumns();
                    }
                }
                tbxBuscar.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Form1.btnBuscar_Click=> Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
