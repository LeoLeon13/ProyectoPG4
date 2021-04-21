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
    public partial class FormServiciosAutomotor : Form
    {
        //LogicaAutoClientes autoCliente = new LogicaAutoClientes();

        public FormServiciosAutomotor()
        {
            InitializeComponent();
            cargarDatos();
            ocultarColumnas();
            dgvAutosClientes.AutoResizeColumnHeadersHeight();
            dgvAutosClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cargarDatos() 
        {
            //Logica.LogicaAutomotores_ Autos = new Logica.LogicaAutomotores_();
            //dgvAutosClientes.DataSource = null;
            //if (Form_Login.tipoUsuario.ToString().Equals("S"))
            //{
            //    dgvAutosClientes.DataSource = Autos.BuscarTodos();
            //    ocultarColumnas();
            //}
            //else 
            //{
            //    dgvAutosClientes.DataSource = Autos.BuscarPorPlaca(Form_Login.placa.ToString());
            //    ocultarColumnas();
            //}            
        }

        private void ocultarColumnas() 
        {
            //this.dgvAutosClientes.Columns["EsTransPublico"].Visible = false;
            //this.dgvAutosClientes.Columns["EsManual"].Visible = false;
            //this.dgvAutosClientes.Columns["EsTransEspe"].Visible = false;
            //this.dgvAutosClientes.Columns["Tiene_contenedor"].Visible = false;
            //this.dgvAutosClientes.Columns["EsMensajero"].Visible = false;
            //this.dgvAutosClientes.Columns["EsClasica"].Visible = false;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            //Logica.LogicaAutomotores_ Autos = new Logica.LogicaAutomotores_();
            //dgvAutosClientes.DataSource = Autos.BuscarPorPlaca(tbxBuscar.Text);
        }

        private void btn_buscarTodos_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
