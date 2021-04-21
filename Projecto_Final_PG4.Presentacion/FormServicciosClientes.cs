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

            //dgvServiciosClientes.DataSource = null;
            //if (Form_Login.tipoUsuario.ToString().Equals("S"))
            //{
            //    dgvServiciosClientes.DataSource = serv.BuscarTodos();
            //}
            //else
            //{
            //    dgvServiciosClientes.DataSource = serv.Buscar(int.Parse(Form_Login.Idcliente.ToString()));
            //}

            ////List<Servicios> servicioPersona = logicaServicio.BuscarTodos();

            ////dgvServiciosClientes.DataSource = servicioPersona;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
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
            //try
            //{

            //    List<Servicios> servicioPersona = logicaServicio.BuscarTodos();

            //    dgvServiciosClientes.DataSource = servicioPersona;


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Form1.btnBuscar_Click=> Error: " + ex.Message);
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }
    }
}
