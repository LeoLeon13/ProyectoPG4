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
using Projecto_Final_PG4.Presentacion.SRComunicacionPersona;

namespace Projecto_Final_PG4.Presentacion
{
    public partial class Agregar_Usuarios : Form
    {
        public Agregar_Usuarios()
        {
            InitializeComponent();
            CargarGridPersonas();
            cbx_EsEmpleado.Enabled = false;
            dgv_Personas.AutoResizeColumnHeadersHeight();
            dgv_Personas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Agregar_Usuarios_Load(object sender, EventArgs e)
        {
            cbx_EsEmpleado.Enabled = false;
            CargarGridPersonas();
        }

        //private LogicaPersonas logicaPersonas = new LogicaPersonas();

        private void FormAgregar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarGridPersonas();
            cbx_EsEmpleado.Enabled = false;
        }

        private void CargarGridPersonas()
        {
            SRComunicacionPersona.PrimerServicioClient cargarDatosUsr = new PrimerServicioClient();
            dgv_Personas.DataSource = null;
            //dgv_Personas.DataSource = cargarDatosUsr.ObtenerTodosPersona().lista;
            dgv_Personas.AutoResizeColumns();
            this.dgv_Personas.Columns["ID_Persona"].Visible = false;
            this.dgv_Personas.Columns["Pass"].Visible = false;
        }

        private void LimpiarDatos()
        {
            txt_Cedula.Text = String.Empty;
            txt_Nombre.Text = String.Empty;
            txt_Apellidos.Text = String.Empty;
            txt_Correo.Text = String.Empty;
            txtCel.Text = String.Empty;
            cbx_EsEmpleado.Text = "Seleccione";
            txt_Telefon.Text = String.Empty;
            txt_Direccion_Cliente.Text = String.Empty;
            txt_Tipo_Empleado.Text = String.Empty;
            txt_Departamento.Text = String.Empty;
            txt_Password.Text = "";
            cbx_EsEmpleado.Text = "Seleccione";
            cbx_TipoUsuario.Text = "Seleccione";
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Agregar_Usuario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Cedula.Text) || String.IsNullOrEmpty(txt_Telefon.Text) || String.IsNullOrEmpty(lbEsempleado.Text) || String.IsNullOrEmpty(txt_Password.Text))
            {

                MessageBox.Show("Deben completar los espacios");
                return;
            }

            else
            {

                try
                {
                    if (cbx_TipoUsuario.Text.Equals("Empleado"))
                    {

                        PersonaDTO personaNueva = new PersonaDTO();
                        personaNueva.Cedula = txt_Cedula.Text;
                        personaNueva.Nombre = txt_Nombre.Text;
                        personaNueva.Apellido = txt_Apellidos.Text;
                        personaNueva.Correo = txt_Correo.Text;
                        personaNueva.Celular = int.Parse(txtCel.Text);
                        personaNueva.EsEmpleado = cbx_EsEmpleado.Text;
                        personaNueva.Telefono = int.Parse(txt_Telefon.Text);
                        personaNueva.Direccion = txt_Direccion_Cliente.Text;
                        personaNueva.Tipo_empleado = txt_Tipo_Empleado.Text;
                        personaNueva.Departamento = txt_Departamento.Text;
                        personaNueva.Pass = txt_Password.Text;
                        SRComunicacionPersona.PrimerServicioClient servicio = new PrimerServicioClient();
                        servicio.InsertarPersona(personaNueva);
                    }
                    else
                    {
                        if (cbx_TipoUsuario.Text.Equals("Cliente"))
                        {
                            PersonaDTO personaNueva = new PersonaDTO();
                            personaNueva.Cedula = txt_Cedula.Text;
                            personaNueva.Nombre = txt_Nombre.Text;
                            personaNueva.Apellido = txt_Apellidos.Text;
                            personaNueva.Correo = txt_Correo.Text;
                            personaNueva.Celular = int.Parse(txtCel.Text);
                            personaNueva.EsEmpleado = "N";
                            personaNueva.Telefono = int.Parse(txt_Telefon.Text);
                            personaNueva.Direccion = txt_Direccion_Cliente.Text;
                            personaNueva.Tipo_empleado = "N";
                            personaNueva.Departamento = "N";
                            personaNueva.Pass = txt_Password.Text;

                            SRComunicacionPersona.PrimerServicioClient servicio = new PrimerServicioClient();
                            servicio.InsertarPersona(personaNueva);
                        }
                    }

                    LimpiarDatos();
                    CargarGridPersonas();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Form1.btnAgregar_Click=> Error: " + ex.Message);
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGridPersonas();
                LimpiarDatos();
                txt_BuscarUsr.Text = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine("Form1.btnBuscar_Click=> Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPersonas_MouseClick(object sender, MouseEventArgs e)
        {
            //List<Persona> personaBuscar = logicaPersonas.BuscarPorCedula(int.Parse(this.dgvPersonas.CurrentRow.Cells[1].Value.ToString()));
            //Persona per = new Persona();
            lbl_IdPesona.Text = this.dgv_Personas.CurrentRow.Cells[7].Value.ToString();
            txt_Cedula.Text = this.dgv_Personas.CurrentRow.Cells[1].Value.ToString();
            txt_Nombre.Text = this.dgv_Personas.CurrentRow.Cells[8].Value.ToString();
            txt_Apellidos.Text = this.dgv_Personas.CurrentRow.Cells[0].Value.ToString();
            txt_Correo.Text = this.dgv_Personas.CurrentRow.Cells[3].Value.ToString();
            txtCel.Text = this.dgv_Personas.CurrentRow.Cells[2].Value.ToString();
            cbx_EsEmpleado.Text = this.dgv_Personas.CurrentRow.Cells[6].Value.ToString();
            txt_Telefon.Text = this.dgv_Personas.CurrentRow.Cells[10].Value.ToString();
            txt_Direccion_Cliente.Text = this.dgv_Personas.CurrentRow.Cells[5].Value.ToString();
            txt_Tipo_Empleado.Text = this.dgv_Personas.CurrentRow.Cells[11].Value.ToString();
            txt_Departamento.Text = this.dgv_Personas.CurrentRow.Cells[4].Value.ToString();

            if (this.dgv_Personas.CurrentRow.Cells[6].Value.ToString().Equals("S"))
            {
                cbx_TipoUsuario.SelectedIndex = 1;
            }
            else
            {
                if (this.dgv_Personas.CurrentRow.Cells[6].Value.ToString().Equals("N"))
                {
                    cbx_TipoUsuario.SelectedIndex = 2;
                }
            }
            btn_Agregar_Usuario.Enabled = false;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_Cedula.Text) || String.IsNullOrEmpty(txt_Telefon.Text) || String.IsNullOrEmpty(lbEsempleado.Text) ||
                    String.IsNullOrEmpty(txt_Password.Text))
                {

                    MessageBox.Show("Deben completar los espacios");
                    return;
                }

                if (cbx_TipoUsuario.Text.Equals("Empleado"))
                {
                    PersonaDTO personaNueva = new PersonaDTO();
                    personaNueva.Cedula = txt_Cedula.Text;
                    personaNueva.Nombre = txt_Nombre.Text;
                    personaNueva.Apellido = txt_Apellidos.Text;
                    personaNueva.Correo = txt_Correo.Text;
                    personaNueva.Celular = int.Parse(txtCel.Text);
                    personaNueva.EsEmpleado = cbx_EsEmpleado.Text;
                    personaNueva.Telefono = int.Parse(txt_Telefon.Text);
                    personaNueva.Direccion = txt_Direccion_Cliente.Text;
                    personaNueva.Tipo_empleado = txt_Tipo_Empleado.Text;
                    personaNueva.Departamento = txt_Departamento.Text;
                    personaNueva.Pass = txt_Password.Text;
                    SRComunicacionPersona.PrimerServicioClient servicio = new PrimerServicioClient();
                    servicio.ModificarPersona(personaNueva);
                }
                else
                {
                    if (cbx_TipoUsuario.Text.Equals("Cliente"))
                    {
                        PersonaDTO personaNueva = new PersonaDTO();
                        //personaNueva.ID_persona = 
                        personaNueva.Cedula = txt_Cedula.Text;
                        personaNueva.Nombre = txt_Nombre.Text;
                        personaNueva.Apellido = txt_Apellidos.Text;
                        personaNueva.Correo = txt_Correo.Text;
                        personaNueva.Celular = int.Parse(txtCel.Text);
                        personaNueva.EsEmpleado = "N";
                        personaNueva.Telefono = int.Parse(txt_Telefon.Text);
                        personaNueva.Direccion = txt_Direccion_Cliente.Text;
                        personaNueva.Tipo_empleado = "N";
                        personaNueva.Departamento = "N";
                        personaNueva.Pass = txt_Password.Text;

                        SRComunicacionPersona.PrimerServicioClient servicio = new PrimerServicioClient();
                        servicio.ModificarPersona(personaNueva);
                    }
                }
                LimpiarDatos();
                CargarGridPersonas();
                btn_Agregar_Usuario.Enabled = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Form1.btnModificar_Click=> Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SRComunicacionPersona.PrimerServicioClient cargarUsr = new PrimerServicioClient();

            try
            {
                if (cargarUsr != null)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = cargarUsr.ObtenerPersonaID(txt_BuscarUsr.Text);
                    dgv_Personas.DataSource = source;
                    dgv_Personas.AutoResizeColumns();
                }
                else
                {
                    string mensaje = String.Format("Usuario con el numero de ID: {0} ,no se encuentra registrado", txt_BuscarUsr.Text);
                    MessageBox.Show(mensaje, "No se encontro registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_BuscarUsr.Text = "";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ralizar la busqueda por numero de id del libro: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaDTO personaEliminar = new PersonaDTO();
                personaEliminar.Cedula = txt_Cedula.Text;
                personaEliminar.Nombre = txt_Nombre.Text;
                personaEliminar.Apellido = txt_Apellidos.Text;
                personaEliminar.Correo = txt_Correo.Text;
                personaEliminar.Celular = int.Parse(txtCel.Text);
                personaEliminar.EsEmpleado = cbx_EsEmpleado.Text;
                personaEliminar.Telefono = int.Parse(txt_Telefon.Text);
                personaEliminar.Direccion = txt_Direccion_Cliente.Text;
                personaEliminar.Tipo_empleado = txt_Tipo_Empleado.Text;
                personaEliminar.Departamento = txt_Departamento.Text;
                personaEliminar.Pass = txt_Password.Text;
                //Persona personaEliminar = new Persona(
                //        txt_Cedula.Text,
                //        txt_Nombre.Text,
                //        txt_Apellidos.Text,
                //        txt_Correo.Text,
                //        int.Parse(txtCel.Text),
                //        cbx_EsEmpleado.Text,
                //        int.Parse(txt_Telefon.Text),
                //        txt_Direccion_Cliente.Text,
                //        txt_Tipo_Empleado.Text,
                //        txt_Departamento.Text,
                //        txt_Password.Text
                //       );
                SRComunicacionPersona.PrimerServicioClient servicio = new PrimerServicioClient();
                servicio.EliminarPersona(personaEliminar.Cedula);
                //logicaPersonas.Eliminar(int.Parse(personaEliminar.Cedula));
                LimpiarDatos();
                CargarGridPersonas();
                btn_Agregar_Usuario.Enabled = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Form1.btnEliminar_Click=> Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            btn_Agregar_Usuario.Enabled = true;
        }

        private void cbx_TipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_TipoUsuario.Text.Equals("Empleado"))
            {
                cbx_EsEmpleado.SelectedIndex = 1;
                label15.Visible = true;
                cbx_EsEmpleado.Visible = true;
                label14.Visible = true;
                txt_Departamento.Visible = true;
                txt_Tipo_Empleado.Visible = true;
                lbEsempleado.Visible = true;

            }

            else
            {
                if (cbx_TipoUsuario.Text.Equals("Cliente"))
                {
                    cbx_EsEmpleado.SelectedIndex = 2;
                    label15.Visible = false;
                    cbx_EsEmpleado.Visible = false;
                    label14.Visible = false;
                    txt_Departamento.Visible = false;
                    txt_Tipo_Empleado.Visible = false;
                    lbEsempleado.Visible = false;
                }
            }

        }
    }
}
