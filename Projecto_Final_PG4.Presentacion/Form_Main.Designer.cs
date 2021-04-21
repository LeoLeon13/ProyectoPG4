namespace Projecto_Final_PG4.Presentacion
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menu_Principal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaciónModificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verServiciosPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verServiciosPorAutomotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Automotores = new System.Windows.Forms.Button();
            this.btn_Personas = new System.Windows.Forms.Button();
            this.btn_Servicios = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_CancelarServ = new System.Windows.Forms.Button();
            this.btn_AgregarServ = new System.Windows.Forms.Button();
            this.btn_verServ = new System.Windows.Forms.Button();
            this.btn_ver_Serv_Cliente = new System.Windows.Forms.Button();
            this.lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.lbl_TipoUserSN = new System.Windows.Forms.Label();
            this.menu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Principal
            // 
            this.menu_Principal.BackColor = System.Drawing.Color.LightSlateGray;
            this.menu_Principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_Principal.BackgroundImage")));
            this.menu_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_Principal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.serviciosToolStripMenuItem,
            this.mantenimientosToolStripMenuItem});
            this.menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.menu_Principal.Name = "menu_Principal";
            this.menu_Principal.Size = new System.Drawing.Size(1206, 28);
            this.menu_Principal.TabIndex = 0;
            this.menu_Principal.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciónModificaciónToolStripMenuItem,
            this.cancelaciónToolStripMenuItem,
            this.verServiciosPorClienteToolStripMenuItem,
            this.verServiciosPorAutomotorToolStripMenuItem});
            this.serviciosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // creaciónModificaciónToolStripMenuItem
            // 
            this.creaciónModificaciónToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.creaciónModificaciónToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.creaciónModificaciónToolStripMenuItem.Name = "creaciónModificaciónToolStripMenuItem";
            this.creaciónModificaciónToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.creaciónModificaciónToolStripMenuItem.Text = "Creación/Modificación";
            this.creaciónModificaciónToolStripMenuItem.Click += new System.EventHandler(this.creaciónModificaciónToolStripMenuItem_Click);
            // 
            // cancelaciónToolStripMenuItem
            // 
            this.cancelaciónToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cancelaciónToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.cancelaciónToolStripMenuItem.Name = "cancelaciónToolStripMenuItem";
            this.cancelaciónToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.cancelaciónToolStripMenuItem.Text = "Cancelación ";
            this.cancelaciónToolStripMenuItem.Click += new System.EventHandler(this.cancelaciónToolStripMenuItem_Click);
            // 
            // verServiciosPorClienteToolStripMenuItem
            // 
            this.verServiciosPorClienteToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.verServiciosPorClienteToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.verServiciosPorClienteToolStripMenuItem.Name = "verServiciosPorClienteToolStripMenuItem";
            this.verServiciosPorClienteToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.verServiciosPorClienteToolStripMenuItem.Text = "Ver Servicios por cliente";
            this.verServiciosPorClienteToolStripMenuItem.Click += new System.EventHandler(this.verServiciosPorClienteToolStripMenuItem_Click);
            // 
            // verServiciosPorAutomotorToolStripMenuItem
            // 
            this.verServiciosPorAutomotorToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.verServiciosPorAutomotorToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.verServiciosPorAutomotorToolStripMenuItem.Name = "verServiciosPorAutomotorToolStripMenuItem";
            this.verServiciosPorAutomotorToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.verServiciosPorAutomotorToolStripMenuItem.Text = "Ver Servicios por automotor";
            this.verServiciosPorAutomotorToolStripMenuItem.Click += new System.EventHandler(this.verServiciosPorAutomotorToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.CheckOnClick = true;
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.automotoresToolStripMenuItem,
            this.tipoServicioToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.personasToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // automotoresToolStripMenuItem
            // 
            this.automotoresToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.automotoresToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.automotoresToolStripMenuItem.Name = "automotoresToolStripMenuItem";
            this.automotoresToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.automotoresToolStripMenuItem.Text = "Automotores";
            this.automotoresToolStripMenuItem.Click += new System.EventHandler(this.automotoresToolStripMenuItem_Click);
            // 
            // tipoServicioToolStripMenuItem
            // 
            this.tipoServicioToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tipoServicioToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.tipoServicioToolStripMenuItem.Name = "tipoServicioToolStripMenuItem";
            this.tipoServicioToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.tipoServicioToolStripMenuItem.Text = "Agregar Servicios";
            this.tipoServicioToolStripMenuItem.Click += new System.EventHandler(this.tipoServicioToolStripMenuItem_Click);
            // 
            // btn_Automotores
            // 
            this.btn_Automotores.BackColor = System.Drawing.Color.Tan;
            this.btn_Automotores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Automotores.BackgroundImage")));
            this.btn_Automotores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Automotores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Automotores.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Automotores.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Automotores.Location = new System.Drawing.Point(12, 368);
            this.btn_Automotores.Name = "btn_Automotores";
            this.btn_Automotores.Size = new System.Drawing.Size(135, 71);
            this.btn_Automotores.TabIndex = 1;
            this.btn_Automotores.Text = "Automotores";
            this.btn_Automotores.UseVisualStyleBackColor = false;
            this.btn_Automotores.Click += new System.EventHandler(this.btn_Automotores_Click);
            // 
            // btn_Personas
            // 
            this.btn_Personas.BackColor = System.Drawing.Color.Tan;
            this.btn_Personas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Personas.BackgroundImage")));
            this.btn_Personas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Personas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personas.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Personas.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Personas.Location = new System.Drawing.Point(426, 31);
            this.btn_Personas.Name = "btn_Personas";
            this.btn_Personas.Size = new System.Drawing.Size(109, 82);
            this.btn_Personas.TabIndex = 2;
            this.btn_Personas.Text = "Agreagr Usuario";
            this.btn_Personas.UseVisualStyleBackColor = false;
            this.btn_Personas.Click += new System.EventHandler(this.btn_Personas_Click);
            // 
            // btn_Servicios
            // 
            this.btn_Servicios.BackColor = System.Drawing.Color.Tan;
            this.btn_Servicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Servicios.BackgroundImage")));
            this.btn_Servicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Servicios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Servicios.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Servicios.Location = new System.Drawing.Point(12, 198);
            this.btn_Servicios.Name = "btn_Servicios";
            this.btn_Servicios.Size = new System.Drawing.Size(127, 79);
            this.btn_Servicios.TabIndex = 3;
            this.btn_Servicios.Text = "Servicios";
            this.btn_Servicios.UseVisualStyleBackColor = false;
            this.btn_Servicios.Click += new System.EventHandler(this.btn_Servicios_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Usuario.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Usuario.Location = new System.Drawing.Point(900, 43);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(93, 27);
            this.lbl_Usuario.TabIndex = 4;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // btn_CancelarServ
            // 
            this.btn_CancelarServ.BackColor = System.Drawing.Color.Tan;
            this.btn_CancelarServ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelarServ.BackgroundImage")));
            this.btn_CancelarServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CancelarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarServ.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarServ.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarServ.Location = new System.Drawing.Point(12, 283);
            this.btn_CancelarServ.Name = "btn_CancelarServ";
            this.btn_CancelarServ.Size = new System.Drawing.Size(127, 79);
            this.btn_CancelarServ.TabIndex = 5;
            this.btn_CancelarServ.Text = "Cancelar Servicio";
            this.btn_CancelarServ.UseVisualStyleBackColor = false;
            this.btn_CancelarServ.Click += new System.EventHandler(this.btn_CancelarServ_Click);
            // 
            // btn_AgregarServ
            // 
            this.btn_AgregarServ.BackColor = System.Drawing.Color.Tan;
            this.btn_AgregarServ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarServ.BackgroundImage")));
            this.btn_AgregarServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarServ.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarServ.ForeColor = System.Drawing.Color.Maroon;
            this.btn_AgregarServ.Location = new System.Drawing.Point(12, 113);
            this.btn_AgregarServ.Name = "btn_AgregarServ";
            this.btn_AgregarServ.Size = new System.Drawing.Size(164, 79);
            this.btn_AgregarServ.TabIndex = 6;
            this.btn_AgregarServ.Text = "Mantenimientos";
            this.btn_AgregarServ.UseVisualStyleBackColor = false;
            this.btn_AgregarServ.Click += new System.EventHandler(this.btn_AgregarServ_Click);
            // 
            // btn_verServ
            // 
            this.btn_verServ.BackColor = System.Drawing.Color.Tan;
            this.btn_verServ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_verServ.BackgroundImage")));
            this.btn_verServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verServ.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verServ.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_verServ.Location = new System.Drawing.Point(178, 33);
            this.btn_verServ.Name = "btn_verServ";
            this.btn_verServ.Size = new System.Drawing.Size(127, 79);
            this.btn_verServ.TabIndex = 7;
            this.btn_verServ.Text = "Buscar Servicio";
            this.btn_verServ.UseVisualStyleBackColor = false;
            this.btn_verServ.Click += new System.EventHandler(this.btn_verServ_Click);
            // 
            // btn_ver_Serv_Cliente
            // 
            this.btn_ver_Serv_Cliente.BackColor = System.Drawing.Color.Tan;
            this.btn_ver_Serv_Cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ver_Serv_Cliente.BackgroundImage")));
            this.btn_ver_Serv_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ver_Serv_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_Serv_Cliente.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_Serv_Cliente.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_ver_Serv_Cliente.Location = new System.Drawing.Point(311, 34);
            this.btn_ver_Serv_Cliente.Name = "btn_ver_Serv_Cliente";
            this.btn_ver_Serv_Cliente.Size = new System.Drawing.Size(109, 79);
            this.btn_ver_Serv_Cliente.TabIndex = 8;
            this.btn_ver_Serv_Cliente.Text = "Citas";
            this.btn_ver_Serv_Cliente.UseVisualStyleBackColor = false;
            this.btn_ver_Serv_Cliente.Click += new System.EventHandler(this.btn_ver_Serv_Cliente_Click);
            // 
            // lbl_TipoUsuario
            // 
            this.lbl_TipoUsuario.AutoSize = true;
            this.lbl_TipoUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_TipoUsuario.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_TipoUsuario.Location = new System.Drawing.Point(1101, 43);
            this.lbl_TipoUsuario.Name = "lbl_TipoUsuario";
            this.lbl_TipoUsuario.Size = new System.Drawing.Size(93, 27);
            this.lbl_TipoUsuario.TabIndex = 9;
            this.lbl_TipoUsuario.Text = "Usuario";
            // 
            // lbl_TipoUserSN
            // 
            this.lbl_TipoUserSN.AutoSize = true;
            this.lbl_TipoUserSN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_TipoUserSN.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoUserSN.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_TipoUserSN.Location = new System.Drawing.Point(566, 43);
            this.lbl_TipoUserSN.Name = "lbl_TipoUserSN";
            this.lbl_TipoUserSN.Size = new System.Drawing.Size(93, 27);
            this.lbl_TipoUserSN.TabIndex = 10;
            this.lbl_TipoUserSN.Text = "Usuario";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 624);
            this.Controls.Add(this.btn_Personas);
            this.Controls.Add(this.btn_Automotores);
            this.Controls.Add(this.btn_AgregarServ);
            this.Controls.Add(this.lbl_TipoUserSN);
            this.Controls.Add(this.btn_ver_Serv_Cliente);
            this.Controls.Add(this.lbl_TipoUsuario);
            this.Controls.Add(this.btn_Servicios);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_verServ);
            this.Controls.Add(this.menu_Principal);
            this.Controls.Add(this.btn_CancelarServ);
            this.MainMenuStrip = this.menu_Principal;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienveinido al sistema de servicio automotriz ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menu_Principal.ResumeLayout(false);
            this.menu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaciónModificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verServiciosPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verServiciosPorAutomotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automotoresToolStripMenuItem;
        private System.Windows.Forms.Button btn_Automotores;
        private System.Windows.Forms.Button btn_Personas;
        private System.Windows.Forms.Button btn_Servicios;
        public System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.ToolStripMenuItem tipoServicioToolStripMenuItem;
        private System.Windows.Forms.Button btn_CancelarServ;
        private System.Windows.Forms.Button btn_AgregarServ;
        private System.Windows.Forms.Button btn_verServ;
        private System.Windows.Forms.Button btn_ver_Serv_Cliente;
        public System.Windows.Forms.Label lbl_TipoUsuario;
        public System.Windows.Forms.Label lbl_TipoUserSN;
    }
}