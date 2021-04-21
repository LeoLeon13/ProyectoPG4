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
    public partial class Form_TipoServicio : Form
    {
        public Form_TipoServicio()
        {
            InitializeComponent();
            CargarTipoTipoServicio();
            //dgvTipoServicios.AutoResizeColumnHeadersHeight();
            //dgvTipoServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void CargarTipoTipoServicio()
        {
            /*//se inicializa la capa y logica que voy a utilizar
            Logica.LogicaTipoServicio TipoServicio = new Logica.LogicaTipoServicio();
            //Inicializo la lista para almacenar la consulta para llenar el listado de clintes
            List<Entidades.TipoServicio> lstTipoServicio = new List<Entidades.TipoServicio>();
            //lleno el dataset con el metodo de consulta de la capa logica
            lstTipoServicio = TipoServicio.BuscarTodos();
            //agregao el resultado de la consulta al combo
            dgvTipoServicios.DataSource = lstTipoServicio;*/
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTipoServicios_MouseClick(object sender, MouseEventArgs e)
        {
           /* txtId.Text = dgvTipoServicios.SelectedRows[0].Cells[0].Value.ToString();
            txtDescripcion.Text = dgvTipoServicios.SelectedRows[0].Cells[1].Value.ToString();*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*if (txtId.Text == string.Empty || txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                    "Favor revisar los campos solicitados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //se inicializa la capa y logica que voy a utilizar
            LogicaTipoServicio tipoServicio = new LogicaTipoServicio();
            //Inicializo la lista para almacenar la consulta para llenar el listado de tiposervicios
            TipoServicio obTipoServicio = new TipoServicio();
            obTipoServicio.Descripcion_servicio = txtDescripcion.Text;
            tipoServicio.Modificar(obTipoServicio);

            CargarTipoTipoServicio();
            txtDescripcion.Clear();*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ////se inicializa la capa y logica que voy a utilizar
            //LogicaTipoServicio tipoServicio = new LogicaTipoServicio();
            ////Inicializo la lista para almacenar la consulta para llenar el listado de tiposervicios
            //TipoServicio obTipoServicio = new TipoServicio();
            //obTipoServicio.ID_Tipo_servicio = Convert.ToInt32(txtId.Text);
            //obTipoServicio.Descripcion_servicio = txtDescripcion.Text;
            //tipoServicio.Eliminar(obTipoServicio);

            //CargarTipoTipoServicio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text == string.Empty || txtDescripcion.Text == string.Empty)
            //{
            //    MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
            //        "Favor revisar los campos solicitados",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            ////se inicializa la capa y logica que voy a utilizar
            //LogicaTipoServicio tipoServicio = new LogicaTipoServicio();
            ////Inicializo la lista para almacenar la consulta para llenar el listado de tiposervicios
            //TipoServicio obTipoServicio = new TipoServicio();
            //obTipoServicio.Descripcion_servicio = txtDescripcion.Text;
            //tipoServicio.Insertar(obTipoServicio);

            //CargarTipoTipoServicio();
            //txtDescripcion.Clear();
        }

        private void dgvTipoServicios_MouseClick_1(object sender, MouseEventArgs e)
        {
            //txtId.Text = dgvTipoServicios.SelectedRows[0].Cells[0].Value.ToString();
            //txtDescripcion.Text = dgvTipoServicios.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_Limpira_Click(object sender, EventArgs e)
        {
            //txtId.Clear();
            //txtDescripcion.Clear();
        }
    }
}
