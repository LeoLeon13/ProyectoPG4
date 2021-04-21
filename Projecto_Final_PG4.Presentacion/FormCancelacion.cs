using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Projecto_Final_PG4.Logica;
//using Projecto_Final_PG4.Entidades;

namespace Projecto_Final_PG4.Presentacion
{
    public partial class FormCancelacion : Form
    {
        public FormCancelacion()
        {
            InitializeComponent();
            CargarCitas();
            dgvCitas.AutoResizeColumnHeadersHeight();
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //LogicaTipoServicio tipoServicioCancelacion = new LogicaTipoServicio();
        //LogicaServicios logicaServicios = new LogicaServicios();

        private void CargarCitas()
        {
            //List<Servicios> lstServicios = new List<Servicios>();
            //lstServicios = logicaServicios.BuscarTodos();
            //dgvCitas.DataSource = lstServicios;
            //this.dgvCitas.Columns["Servicio_seleccionado"].Visible = false;
            //this.dgvCitas.Columns["ID_Servicio"].Visible = false;
            //this.dgvCitas.Columns["ID_Tipo_Servicio"].Visible = false;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCitas_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.Text = dgvCitas.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    LogicaServicios servicios = new LogicaServicios();


            //    Servicios obServicios = new Servicios();
            //    if (txtId.Text.Equals(""))
            //    {
            //        MessageBox.Show("No se encuentra registros a eliminar", "Error al eliminar dato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        obServicios.ID_Servicio = int.Parse(txtId.Text);
            //        servicios.Eliminar(obServicios);
            //        txtId.Text = "";
            //        CargarCitas();
            //        tbxBuscar.Clear();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error al eliminar servicio: " + ex.Message);

            //}

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            //TipoServicio obTipoServicioCancelacion = new TipoServicio();
            //obTipoServicioCancelacion.ID_Tipo_servicio = Convert.ToInt32(txtId.Text);
            //tipoServicioCancelacion.Modificar(obTipoServicioCancelacion);

            CargarCitas();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    List<Servicios> tipoServBuscar = new List<Servicios>();
            //    tipoServBuscar = logicaServicios.Buscar(int.Parse(tbxBuscar.Text));
            //    dgvCitas.DataSource = tipoServBuscar;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Form1.btnBuscar_Click=> Error: " + ex.Message);
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void btBuscarTodos_Click(object sender, EventArgs e)
        {
            CargarCitas();
            tbxBuscar.Clear();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tbxBuscar.Clear();
            txtId.Clear();
            CargarCitas();

        }
    }
}
