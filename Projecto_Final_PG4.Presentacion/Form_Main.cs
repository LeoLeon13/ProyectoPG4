using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Final_PG4.Presentacion
{
    public partial class Form_Main : Form
    {

        public Form_Main()
        {
            InitializeComponent();
            CargarLogin();

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            lbl_TipoUsuario.Text = String.Format(Form_Login.tipoUsuario.ToString());
            lbl_TipoUserSN.Text = String.Format(Form_Login.tipoUsuario.ToString());
            lbl_Usuario.Text = String.Format(Form_Login.nombreUsr.ToString() + " " + Form_Login.apellidoUsr.ToString());
            validarUsuario();

            if (lbl_TipoUsuario.Text.Equals("S"))
            {
                lbl_TipoUsuario.Text = "Admin";
            }
            else
            {
                lbl_TipoUsuario.Text = "Cliente";
            }

            lbl_TipoUserSN.Visible = false;
        }

        private void validarUsuario()
        {
            if (lbl_TipoUserSN.Text.Equals("N"))
            {
                mantenimientosToolStripMenuItem.Visible = false;
                cancelaciónToolStripMenuItem.Visible = false;
                creaciónModificaciónToolStripMenuItem.Visible = false;
                btn_Automotores.Visible = false;
                btn_Personas.Visible = false;
                btn_Servicios.Visible = false;
                btn_ver_Serv_Cliente.Visible = true;//lo pase a true
                btn_verServ.Visible = true;//lo pase a true
                btn_CancelarServ.Visible = false;
                btn_AgregarServ.Visible = false;
            }
        }

        private void CargarLogin()
        {
            Form_Login flogin = new Form_Login();
            if (flogin.ShowDialog() == DialogResult.OK && flogin.aprovado == true)
            {
                Application.Run(new Form_Main());
            }
            else
            {
                Application.Exit();
            }
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Usuarios fr = new Agregar_Usuarios();
            fr.Show();
        }

        private void automotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automotores fr = new Automotores();
            fr.Show();
        }

        private void tipoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TipoServicio fr = new Form_TipoServicio();
            fr.Show();
        }

        private void creaciónModificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionServicio fr = new CreacionServicio();
            fr.Show();
        }

        private void cancelaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCancelacion fr = new FormCancelacion();
            fr.Show();
        }

        private void btn_Automotores_Click(object sender, EventArgs e)
        {
            Automotores fr = new Automotores();
            fr.Show();
        }

        private void btn_Personas_Click(object sender, EventArgs e)
        {
            Agregar_Usuarios fr = new Agregar_Usuarios();
            fr.Show();
        }

        private void btn_Servicios_Click(object sender, EventArgs e)
        {
            CreacionServicio fr = new CreacionServicio();
            fr.Show();
        }

        private void verServiciosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicciosClientes fr = new FormServicciosClientes();
            fr.Show();
        }

        private void verServiciosPorAutomotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServiciosAutomotor fr = new FormServiciosAutomotor();
            fr.Show();
        }

        private void btn_CancelarServ_Click(object sender, EventArgs e)
        {
            FormCancelacion fr = new FormCancelacion();
            fr.Show();
        }

        private void btn_AgregarServ_Click(object sender, EventArgs e)
        {
            Form_TipoServicio fr = new Form_TipoServicio();
            fr.Show();
        }

        private void btn_verServ_Click(object sender, EventArgs e)
        {
            FormServiciosAutomotor fr = new FormServiciosAutomotor();
            fr.Show();
        }

        private void btn_ver_Serv_Cliente_Click(object sender, EventArgs e)
        {
            FormServicciosClientes fr = new FormServicciosClientes();
            fr.Show();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
