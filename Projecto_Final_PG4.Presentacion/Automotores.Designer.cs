namespace Projecto_Final_PG4.Presentacion
{
    partial class Automotores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Automotores));
            this.dtg_Clientes_Vehiculos = new System.Windows.Forms.DataGridView();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.cbx_Clientes = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo_Vehiculo = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.cbx_Tipo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.gbx_Datos = new System.Windows.Forms.GroupBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.cbx_TipoVehiculoM = new System.Windows.Forms.ComboBox();
            this.lbl_TipoVehiculo = new System.Windows.Forms.Label();
            this.cbx_EsClasica = new System.Windows.Forms.ComboBox();
            this.cbx_TransPublico = new System.Windows.Forms.ComboBox();
            this.cbx_Manual = new System.Windows.Forms.ComboBox();
            this.cbx_TransEspecial = new System.Windows.Forms.ComboBox();
            this.Lbl_Cilindraje = new System.Windows.Forms.Label();
            this.cbx_TieneContenedor = new System.Windows.Forms.ComboBox();
            this.lbl_EsClasica = new System.Windows.Forms.Label();
            this.cbx_EsMensajero = new System.Windows.Forms.ComboBox();
            this.lbl_EsMensajero = new System.Windows.Forms.Label();
            this.lbl_TieneContenedor = new System.Windows.Forms.Label();
            this.lbl_EsTransEspecial = new System.Windows.Forms.Label();
            this.lbl_EsManual = new System.Windows.Forms.Label();
            this.lbl_EsTransPublico = new System.Windows.Forms.Label();
            this.lbl_Combustible = new System.Windows.Forms.Label();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.txt_Cilindraje = new System.Windows.Forms.TextBox();
            this.txt_Combustible = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_ID_AutoMotor = new System.Windows.Forms.TextBox();
            this.lbl_AutoCliente = new System.Windows.Forms.Label();
            this.lbl_IDAutomotores = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes_Vehiculos)).BeginInit();
            this.gbx_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Clientes_Vehiculos
            // 
            this.dtg_Clientes_Vehiculos.AllowUserToAddRows = false;
            this.dtg_Clientes_Vehiculos.AllowUserToDeleteRows = false;
            this.dtg_Clientes_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Clientes_Vehiculos.Location = new System.Drawing.Point(670, 131);
            this.dtg_Clientes_Vehiculos.MultiSelect = false;
            this.dtg_Clientes_Vehiculos.Name = "dtg_Clientes_Vehiculos";
            this.dtg_Clientes_Vehiculos.ReadOnly = true;
            this.dtg_Clientes_Vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Clientes_Vehiculos.Size = new System.Drawing.Size(544, 240);
            this.dtg_Clientes_Vehiculos.TabIndex = 43;
            this.dtg_Clientes_Vehiculos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtg_Clientes_Vehiculos_MouseClick);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(913, 380);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(80, 33);
            this.btn_Limpiar.TabIndex = 42;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(832, 380);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 33);
            this.btn_Eliminar.TabIndex = 41;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(751, 380);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 33);
            this.btn_Modificar.TabIndex = 40;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(716, 65);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(69, 18);
            this.lbl_Clientes.TabIndex = 39;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // cbx_Clientes
            // 
            this.cbx_Clientes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Clientes.FormattingEnabled = true;
            this.cbx_Clientes.Items.AddRange(new object[] {
            "Seleccione"});
            this.cbx_Clientes.Location = new System.Drawing.Point(842, 61);
            this.cbx_Clientes.Name = "cbx_Clientes";
            this.cbx_Clientes.Size = new System.Drawing.Size(121, 28);
            this.cbx_Clientes.TabIndex = 38;
            // 
            // lbl_Tipo_Vehiculo
            // 
            this.lbl_Tipo_Vehiculo.AutoSize = true;
            this.lbl_Tipo_Vehiculo.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Tipo_Vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Vehiculo.Location = new System.Drawing.Point(716, 25);
            this.lbl_Tipo_Vehiculo.Name = "lbl_Tipo_Vehiculo";
            this.lbl_Tipo_Vehiculo.Size = new System.Drawing.Size(110, 18);
            this.lbl_Tipo_Vehiculo.TabIndex = 37;
            this.lbl_Tipo_Vehiculo.Text = "Tipo Vehiculo";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(670, 380);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 33);
            this.btn_Agregar.TabIndex = 36;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // cbx_Tipo_Vehiculo
            // 
            this.cbx_Tipo_Vehiculo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Tipo_Vehiculo.FormattingEnabled = true;
            this.cbx_Tipo_Vehiculo.Items.AddRange(new object[] {
            "Seleccione",
            "Motos",
            "Camiones",
            "Autos"});
            this.cbx_Tipo_Vehiculo.Location = new System.Drawing.Point(842, 21);
            this.cbx_Tipo_Vehiculo.Name = "cbx_Tipo_Vehiculo";
            this.cbx_Tipo_Vehiculo.Size = new System.Drawing.Size(121, 28);
            this.cbx_Tipo_Vehiculo.TabIndex = 35;
            this.cbx_Tipo_Vehiculo.SelectedIndexChanged += new System.EventHandler(this.cbx_Tipo_Vehiculo_SelectedIndexChanged_1);
            this.cbx_Tipo_Vehiculo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx_Tipo_Vehiculo_MouseClick);
            // 
            // gbx_Datos
            // 
            this.gbx_Datos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx_Datos.BackgroundImage")));
            this.gbx_Datos.Controls.Add(this.txt_Placa);
            this.gbx_Datos.Controls.Add(this.cbx_TipoVehiculoM);
            this.gbx_Datos.Controls.Add(this.lbl_TipoVehiculo);
            this.gbx_Datos.Controls.Add(this.cbx_EsClasica);
            this.gbx_Datos.Controls.Add(this.cbx_TransPublico);
            this.gbx_Datos.Controls.Add(this.cbx_Manual);
            this.gbx_Datos.Controls.Add(this.cbx_TransEspecial);
            this.gbx_Datos.Controls.Add(this.Lbl_Cilindraje);
            this.gbx_Datos.Controls.Add(this.cbx_TieneContenedor);
            this.gbx_Datos.Controls.Add(this.lbl_EsClasica);
            this.gbx_Datos.Controls.Add(this.cbx_EsMensajero);
            this.gbx_Datos.Controls.Add(this.lbl_EsMensajero);
            this.gbx_Datos.Controls.Add(this.lbl_TieneContenedor);
            this.gbx_Datos.Controls.Add(this.lbl_EsTransEspecial);
            this.gbx_Datos.Controls.Add(this.lbl_EsManual);
            this.gbx_Datos.Controls.Add(this.lbl_EsTransPublico);
            this.gbx_Datos.Controls.Add(this.lbl_Combustible);
            this.gbx_Datos.Controls.Add(this.lbl_Modelo);
            this.gbx_Datos.Controls.Add(this.lbl_Marca);
            this.gbx_Datos.Controls.Add(this.lbl_Placa);
            this.gbx_Datos.Controls.Add(this.txt_Cilindraje);
            this.gbx_Datos.Controls.Add(this.txt_Combustible);
            this.gbx_Datos.Controls.Add(this.txt_Modelo);
            this.gbx_Datos.Controls.Add(this.txt_Marca);
            this.gbx_Datos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Datos.Location = new System.Drawing.Point(11, 25);
            this.gbx_Datos.Name = "gbx_Datos";
            this.gbx_Datos.Size = new System.Drawing.Size(653, 346);
            this.gbx_Datos.TabIndex = 34;
            this.gbx_Datos.TabStop = false;
            this.gbx_Datos.Text = "Datos Automotores";
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(190, 101);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(100, 29);
            this.txt_Placa.TabIndex = 46;
            // 
            // cbx_TipoVehiculoM
            // 
            this.cbx_TipoVehiculoM.FormattingEnabled = true;
            this.cbx_TipoVehiculoM.Items.AddRange(new object[] {
            "Seleccione",
            "Motos",
            "Camiones",
            "Autos"});
            this.cbx_TipoVehiculoM.Location = new System.Drawing.Point(190, 48);
            this.cbx_TipoVehiculoM.Name = "cbx_TipoVehiculoM";
            this.cbx_TipoVehiculoM.Size = new System.Drawing.Size(121, 31);
            this.cbx_TipoVehiculoM.TabIndex = 45;
            // 
            // lbl_TipoVehiculo
            // 
            this.lbl_TipoVehiculo.AutoSize = true;
            this.lbl_TipoVehiculo.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_TipoVehiculo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoVehiculo.Location = new System.Drawing.Point(19, 53);
            this.lbl_TipoVehiculo.Name = "lbl_TipoVehiculo";
            this.lbl_TipoVehiculo.Size = new System.Drawing.Size(138, 19);
            this.lbl_TipoVehiculo.TabIndex = 35;
            this.lbl_TipoVehiculo.Text = "Tipo de Vehiculo";
            // 
            // cbx_EsClasica
            // 
            this.cbx_EsClasica.FormattingEnabled = true;
            this.cbx_EsClasica.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_EsClasica.Location = new System.Drawing.Point(534, 271);
            this.cbx_EsClasica.Name = "cbx_EsClasica";
            this.cbx_EsClasica.Size = new System.Drawing.Size(100, 31);
            this.cbx_EsClasica.TabIndex = 31;
            // 
            // cbx_TransPublico
            // 
            this.cbx_TransPublico.FormattingEnabled = true;
            this.cbx_TransPublico.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_TransPublico.Location = new System.Drawing.Point(534, 48);
            this.cbx_TransPublico.Name = "cbx_TransPublico";
            this.cbx_TransPublico.Size = new System.Drawing.Size(100, 31);
            this.cbx_TransPublico.TabIndex = 25;
            // 
            // cbx_Manual
            // 
            this.cbx_Manual.FormattingEnabled = true;
            this.cbx_Manual.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_Manual.Location = new System.Drawing.Point(534, 91);
            this.cbx_Manual.Name = "cbx_Manual";
            this.cbx_Manual.Size = new System.Drawing.Size(100, 31);
            this.cbx_Manual.TabIndex = 27;
            // 
            // cbx_TransEspecial
            // 
            this.cbx_TransEspecial.FormattingEnabled = true;
            this.cbx_TransEspecial.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_TransEspecial.Location = new System.Drawing.Point(534, 134);
            this.cbx_TransEspecial.Name = "cbx_TransEspecial";
            this.cbx_TransEspecial.Size = new System.Drawing.Size(100, 31);
            this.cbx_TransEspecial.TabIndex = 28;
            // 
            // Lbl_Cilindraje
            // 
            this.Lbl_Cilindraje.AutoSize = true;
            this.Lbl_Cilindraje.BackColor = System.Drawing.Color.LightBlue;
            this.Lbl_Cilindraje.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cilindraje.Location = new System.Drawing.Point(19, 273);
            this.Lbl_Cilindraje.Name = "Lbl_Cilindraje";
            this.Lbl_Cilindraje.Size = new System.Drawing.Size(82, 19);
            this.Lbl_Cilindraje.TabIndex = 23;
            this.Lbl_Cilindraje.Text = "Cilindraje";
            // 
            // cbx_TieneContenedor
            // 
            this.cbx_TieneContenedor.FormattingEnabled = true;
            this.cbx_TieneContenedor.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_TieneContenedor.Location = new System.Drawing.Point(534, 177);
            this.cbx_TieneContenedor.Name = "cbx_TieneContenedor";
            this.cbx_TieneContenedor.Size = new System.Drawing.Size(100, 31);
            this.cbx_TieneContenedor.TabIndex = 29;
            // 
            // lbl_EsClasica
            // 
            this.lbl_EsClasica.AutoSize = true;
            this.lbl_EsClasica.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_EsClasica.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsClasica.Location = new System.Drawing.Point(335, 271);
            this.lbl_EsClasica.Name = "lbl_EsClasica";
            this.lbl_EsClasica.Size = new System.Drawing.Size(90, 19);
            this.lbl_EsClasica.TabIndex = 22;
            this.lbl_EsClasica.Text = "Es Clasica";
            // 
            // cbx_EsMensajero
            // 
            this.cbx_EsMensajero.FormattingEnabled = true;
            this.cbx_EsMensajero.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_EsMensajero.Location = new System.Drawing.Point(534, 220);
            this.cbx_EsMensajero.Name = "cbx_EsMensajero";
            this.cbx_EsMensajero.Size = new System.Drawing.Size(100, 31);
            this.cbx_EsMensajero.TabIndex = 30;
            // 
            // lbl_EsMensajero
            // 
            this.lbl_EsMensajero.AutoSize = true;
            this.lbl_EsMensajero.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_EsMensajero.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsMensajero.Location = new System.Drawing.Point(335, 225);
            this.lbl_EsMensajero.Name = "lbl_EsMensajero";
            this.lbl_EsMensajero.Size = new System.Drawing.Size(114, 19);
            this.lbl_EsMensajero.TabIndex = 21;
            this.lbl_EsMensajero.Text = "Es Mensajero";
            // 
            // lbl_TieneContenedor
            // 
            this.lbl_TieneContenedor.AutoSize = true;
            this.lbl_TieneContenedor.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_TieneContenedor.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieneContenedor.Location = new System.Drawing.Point(335, 182);
            this.lbl_TieneContenedor.Name = "lbl_TieneContenedor";
            this.lbl_TieneContenedor.Size = new System.Drawing.Size(149, 19);
            this.lbl_TieneContenedor.TabIndex = 20;
            this.lbl_TieneContenedor.Text = "Tiene Contenedor";
            // 
            // lbl_EsTransEspecial
            // 
            this.lbl_EsTransEspecial.AutoSize = true;
            this.lbl_EsTransEspecial.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_EsTransEspecial.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsTransEspecial.Location = new System.Drawing.Point(335, 139);
            this.lbl_EsTransEspecial.Name = "lbl_EsTransEspecial";
            this.lbl_EsTransEspecial.Size = new System.Drawing.Size(190, 19);
            this.lbl_EsTransEspecial.TabIndex = 19;
            this.lbl_EsTransEspecial.Text = "Es Transporte Especial";
            // 
            // lbl_EsManual
            // 
            this.lbl_EsManual.AutoSize = true;
            this.lbl_EsManual.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_EsManual.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsManual.Location = new System.Drawing.Point(335, 96);
            this.lbl_EsManual.Name = "lbl_EsManual";
            this.lbl_EsManual.Size = new System.Drawing.Size(89, 19);
            this.lbl_EsManual.TabIndex = 18;
            this.lbl_EsManual.Text = "Es Manual";
            // 
            // lbl_EsTransPublico
            // 
            this.lbl_EsTransPublico.AutoSize = true;
            this.lbl_EsTransPublico.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_EsTransPublico.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EsTransPublico.Location = new System.Drawing.Point(335, 53);
            this.lbl_EsTransPublico.Name = "lbl_EsTransPublico";
            this.lbl_EsTransPublico.Size = new System.Drawing.Size(183, 19);
            this.lbl_EsTransPublico.TabIndex = 17;
            this.lbl_EsTransPublico.Text = "Es Transporte Publico";
            // 
            // lbl_Combustible
            // 
            this.lbl_Combustible.AutoSize = true;
            this.lbl_Combustible.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Combustible.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Combustible.Location = new System.Drawing.Point(19, 235);
            this.lbl_Combustible.Name = "lbl_Combustible";
            this.lbl_Combustible.Size = new System.Drawing.Size(107, 19);
            this.lbl_Combustible.TabIndex = 16;
            this.lbl_Combustible.Text = "Combustible";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Modelo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modelo.Location = new System.Drawing.Point(19, 192);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(65, 19);
            this.lbl_Modelo.TabIndex = 15;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Marca.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(19, 149);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(56, 19);
            this.lbl_Marca.TabIndex = 14;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Placa.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Placa.Location = new System.Drawing.Point(19, 106);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(118, 19);
            this.lbl_Placa.TabIndex = 13;
            this.lbl_Placa.Text = "Número Placa";
            // 
            // txt_Cilindraje
            // 
            this.txt_Cilindraje.Location = new System.Drawing.Point(193, 268);
            this.txt_Cilindraje.Name = "txt_Cilindraje";
            this.txt_Cilindraje.Size = new System.Drawing.Size(100, 29);
            this.txt_Cilindraje.TabIndex = 5;
            // 
            // txt_Combustible
            // 
            this.txt_Combustible.Location = new System.Drawing.Point(193, 230);
            this.txt_Combustible.Name = "txt_Combustible";
            this.txt_Combustible.Size = new System.Drawing.Size(100, 29);
            this.txt_Combustible.TabIndex = 4;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(193, 187);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(100, 29);
            this.txt_Modelo.TabIndex = 3;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(193, 144);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(100, 29);
            this.txt_Marca.TabIndex = 2;
            // 
            // txt_ID_AutoMotor
            // 
            this.txt_ID_AutoMotor.Location = new System.Drawing.Point(1091, 55);
            this.txt_ID_AutoMotor.Name = "txt_ID_AutoMotor";
            this.txt_ID_AutoMotor.Size = new System.Drawing.Size(100, 20);
            this.txt_ID_AutoMotor.TabIndex = 34;
            // 
            // lbl_AutoCliente
            // 
            this.lbl_AutoCliente.AutoSize = true;
            this.lbl_AutoCliente.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_AutoCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AutoCliente.Location = new System.Drawing.Point(969, 55);
            this.lbl_AutoCliente.Name = "lbl_AutoCliente";
            this.lbl_AutoCliente.Size = new System.Drawing.Size(109, 18);
            this.lbl_AutoCliente.TabIndex = 33;
            this.lbl_AutoCliente.Text = "ID AutoCliente";
            // 
            // lbl_IDAutomotores
            // 
            this.lbl_IDAutomotores.AutoSize = true;
            this.lbl_IDAutomotores.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_IDAutomotores.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDAutomotores.Location = new System.Drawing.Point(969, 26);
            this.lbl_IDAutomotores.Name = "lbl_IDAutomotores";
            this.lbl_IDAutomotores.Size = new System.Drawing.Size(116, 18);
            this.lbl_IDAutomotores.TabIndex = 12;
            this.lbl_IDAutomotores.Text = "ID Automotores";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(1091, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // btBuscarTodos
            // 
            this.btBuscarTodos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarTodos.Location = new System.Drawing.Point(929, 100);
            this.btBuscarTodos.Name = "btBuscarTodos";
            this.btBuscarTodos.Size = new System.Drawing.Size(100, 26);
            this.btBuscarTodos.TabIndex = 48;
            this.btBuscarTodos.Text = "Buscar todos";
            this.btBuscarTodos.UseVisualStyleBackColor = true;
            this.btBuscarTodos.Click += new System.EventHandler(this.btBuscarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(832, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 26);
            this.btnBuscar.TabIndex = 47;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(670, 100);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(156, 25);
            this.txt_Buscar.TabIndex = 46;
            // 
            // Automotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1226, 435);
            this.Controls.Add(this.btBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt_ID_AutoMotor);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.lbl_AutoCliente);
            this.Controls.Add(this.dtg_Clientes_Vehiculos);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.cbx_Clientes);
            this.Controls.Add(this.lbl_Tipo_Vehiculo);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cbx_Tipo_Vehiculo);
            this.Controls.Add(this.gbx_Datos);
            this.Controls.Add(this.lbl_IDAutomotores);
            this.Controls.Add(this.txt_ID);
            this.Name = "Automotores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automotores";
            this.Load += new System.EventHandler(this.Automotores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes_Vehiculos)).EndInit();
            this.gbx_Datos.ResumeLayout(false);
            this.gbx_Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_Clientes_Vehiculos;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.ComboBox cbx_Clientes;
        private System.Windows.Forms.Label lbl_Tipo_Vehiculo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ComboBox cbx_Tipo_Vehiculo;
        private System.Windows.Forms.GroupBox gbx_Datos;
        private System.Windows.Forms.TextBox txt_ID_AutoMotor;
        private System.Windows.Forms.Label lbl_AutoCliente;
        private System.Windows.Forms.ComboBox cbx_EsClasica;
        private System.Windows.Forms.ComboBox cbx_TransPublico;
        private System.Windows.Forms.ComboBox cbx_Manual;
        private System.Windows.Forms.ComboBox cbx_TransEspecial;
        private System.Windows.Forms.Label Lbl_Cilindraje;
        private System.Windows.Forms.ComboBox cbx_TieneContenedor;
        private System.Windows.Forms.Label lbl_EsClasica;
        private System.Windows.Forms.ComboBox cbx_EsMensajero;
        private System.Windows.Forms.Label lbl_EsMensajero;
        private System.Windows.Forms.Label lbl_TieneContenedor;
        private System.Windows.Forms.Label lbl_EsTransEspecial;
        private System.Windows.Forms.Label lbl_EsManual;
        private System.Windows.Forms.Label lbl_EsTransPublico;
        private System.Windows.Forms.Label lbl_Combustible;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.Label lbl_IDAutomotores;
        private System.Windows.Forms.TextBox txt_Cilindraje;
        private System.Windows.Forms.TextBox txt_Combustible;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_TipoVehiculo;
        private System.Windows.Forms.ComboBox cbx_TipoVehiculoM;
        private System.Windows.Forms.Button btBuscarTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.TextBox txt_Placa;
    }
}