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
            //Logica.LogicaTipoServicio TipoServicio = new Logica.LogicaTipoServicio();
            //List<Entidades.TipoServicio> lstTipoServicio = new List<Entidades.TipoServicio>();
            SRComunicacionPersona.PrimerServicioClient servicio = new SRComunicacionPersona.PrimerServicioClient();
            var lstTipoServicio = servicio.ObtenerTodosTipoServicio().lista;
            dgvTipoServicios.DataSource = lstTipoServicio;
            dgvTipoServicios.AutoResizeColumns();
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
            txtId.Text = dgvTipoServicios.SelectedRows[0].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvTipoServicios.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty || txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                    "Favor revisar los campos solicitados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SRComunicacionPersona.PrimerServicioClient servicio = new SRComunicacionPersona.PrimerServicioClient();

            TipoServicioDTO tipoServicio = new TipoServicioDTO();
            tipoServicio.Descripcion_servicio = txtDescripcion.Text;
            tipoServicio.ID_tipo_servicio = int.Parse(txtId.Text);
            servicio.ModificarTipoServicio(tipoServicio);

            CargarTipoTipoServicio();
            txtDescripcion.Clear();
            txtId.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SRComunicacionPersona.PrimerServicioClient servicio = new SRComunicacionPersona.PrimerServicioClient();

            TipoServicioDTO tipoServicio = new TipoServicioDTO();

            tipoServicio.ID_tipo_servicio = int.Parse(txtId.Text);
            servicio.EliminarTipoServicio(tipoServicio.ID_tipo_servicio);

            CargarTipoTipoServicio();
            txtId.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == string.Empty)//if (txtId.Text == string.Empty || txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos de texto deben de estar correctamente llenos",
                    "Favor revisar los campos solicitados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SRComunicacionPersona.PrimerServicioClient servicio = new SRComunicacionPersona.PrimerServicioClient();

            TipoServicioDTO tipoServicio = new TipoServicioDTO();

            tipoServicio.Descripcion_servicio = txtDescripcion.Text;
            servicio.InsertarTipoServicio(tipoServicio);

            CargarTipoTipoServicio();
            txtDescripcion.Clear();
            txtId.Clear();
            btnAgregar.Enabled = true;
        }

        private void dgvTipoServicios_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtId.Text = dgvTipoServicios.SelectedRows[0].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvTipoServicios.SelectedRows[0].Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
        }

        private void btn_Limpira_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtDescripcion.Clear();
            btnAgregar.Enabled = true;
        }
    }
}
