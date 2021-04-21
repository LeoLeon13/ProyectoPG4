namespace Projecto_Final_PG4.Presentacion
{
    partial class Agregar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Usuarios));
            this.btBuscarTodos = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_BuscarUsr = new System.Windows.Forms.TextBox();
            this.dgv_Personas = new System.Windows.Forms.DataGridView();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.btn_Agregar_Usuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.cbx_EsEmpleado = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Direccion_Cliente = new System.Windows.Forms.TextBox();
            this.lbEsempleado = new System.Windows.Forms.Label();
            this.lbcel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txt_Tipo_Empleado = new System.Windows.Forms.TextBox();
            this.txt_Departamento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_IdPesona = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBuscarTodos
            // 
            this.btBuscarTodos.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarTodos.Location = new System.Drawing.Point(373, 383);
            this.btBuscarTodos.Name = "btBuscarTodos";
            this.btBuscarTodos.Size = new System.Drawing.Size(139, 35);
            this.btBuscarTodos.TabIndex = 45;
            this.btBuscarTodos.Text = "Buscar Todos";
            this.btBuscarTodos.UseVisualStyleBackColor = true;
            this.btBuscarTodos.Click += new System.EventHandler(this.btBuscarTodos_Click);
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(218, 254);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 38);
            this.btModificar.TabIndex = 44;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(267, 383);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 35);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_BuscarUsr
            // 
            this.txt_BuscarUsr.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarUsr.Location = new System.Drawing.Point(12, 389);
            this.txt_BuscarUsr.Name = "txt_BuscarUsr";
            this.txt_BuscarUsr.Size = new System.Drawing.Size(249, 25);
            this.txt_BuscarUsr.TabIndex = 42;
            // 
            // dgv_Personas
            // 
            this.dgv_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Personas.Location = new System.Drawing.Point(12, 423);
            this.dgv_Personas.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Personas.MultiSelect = false;
            this.dgv_Personas.Name = "dgv_Personas";
            this.dgv_Personas.ReadOnly = true;
            this.dgv_Personas.RowHeadersWidth = 62;
            this.dgv_Personas.RowTemplate.Height = 28;
            this.dgv_Personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Personas.Size = new System.Drawing.Size(830, 224);
            this.dgv_Personas.TabIndex = 41;
            this.dgv_Personas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersonas_MouseClick);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.Location = new System.Drawing.Point(112, 253);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(100, 38);
            this.BtEliminar.TabIndex = 40;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // btn_Agregar_Usuario
            // 
            this.btn_Agregar_Usuario.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Usuario.Location = new System.Drawing.Point(6, 253);
            this.btn_Agregar_Usuario.Name = "btn_Agregar_Usuario";
            this.btn_Agregar_Usuario.Size = new System.Drawing.Size(100, 38);
            this.btn_Agregar_Usuario.TabIndex = 39;
            this.btn_Agregar_Usuario.Text = "Agregar";
            this.btn_Agregar_Usuario.UseVisualStyleBackColor = true;
            this.btn_Agregar_Usuario.Click += new System.EventHandler(this.btn_Agregar_Usuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.lbl_IdPesona);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_TipoUsuario);
            this.groupBox1.Controls.Add(this.cbx_EsEmpleado);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.btModificar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Direccion_Cliente);
            this.groupBox1.Controls.Add(this.lbEsempleado);
            this.groupBox1.Controls.Add(this.lbcel);
            this.groupBox1.Controls.Add(this.BtEliminar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.btn_Agregar_Usuario);
            this.groupBox1.Controls.Add(this.txt_Tipo_Empleado);
            this.groupBox1.Controls.Add(this.txt_Departamento);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Telefon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Cedula);
            this.groupBox1.Controls.Add(this.txt_Correo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_Apellidos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 323);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(324, 253);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 38);
            this.btn_Cancelar.TabIndex = 50;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tipo de Usuario";
            // 
            // cbx_TipoUsuario
            // 
            this.cbx_TipoUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TipoUsuario.FormattingEnabled = true;
            this.cbx_TipoUsuario.Items.AddRange(new object[] {
            "Seleccione",
            "Empleado",
            "Cliente"});
            this.cbx_TipoUsuario.Location = new System.Drawing.Point(197, 36);
            this.cbx_TipoUsuario.Name = "cbx_TipoUsuario";
            this.cbx_TipoUsuario.Size = new System.Drawing.Size(121, 25);
            this.cbx_TipoUsuario.TabIndex = 48;
            this.cbx_TipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoUsuario_SelectedIndexChanged);
            // 
            // cbx_EsEmpleado
            // 
            this.cbx_EsEmpleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_EsEmpleado.FormattingEnabled = true;
            this.cbx_EsEmpleado.Items.AddRange(new object[] {
            "Seleccione",
            "S",
            "N"});
            this.cbx_EsEmpleado.Location = new System.Drawing.Point(525, 181);
            this.cbx_EsEmpleado.Name = "cbx_EsEmpleado";
            this.cbx_EsEmpleado.Size = new System.Drawing.Size(121, 25);
            this.cbx_EsEmpleado.TabIndex = 47;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(525, 94);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(126, 25);
            this.txt_Password.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(903, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Direccion";
            // 
            // txt_Direccion_Cliente
            // 
            this.txt_Direccion_Cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion_Cliente.Location = new System.Drawing.Point(525, 36);
            this.txt_Direccion_Cliente.Name = "txt_Direccion_Cliente";
            this.txt_Direccion_Cliente.Size = new System.Drawing.Size(288, 25);
            this.txt_Direccion_Cliente.TabIndex = 21;
            // 
            // lbEsempleado
            // 
            this.lbEsempleado.AutoSize = true;
            this.lbEsempleado.BackColor = System.Drawing.Color.LightBlue;
            this.lbEsempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsempleado.Location = new System.Drawing.Point(356, 188);
            this.lbEsempleado.Name = "lbEsempleado";
            this.lbEsempleado.Size = new System.Drawing.Size(117, 20);
            this.lbEsempleado.TabIndex = 31;
            this.lbEsempleado.Text = "Es empleado";
            // 
            // lbcel
            // 
            this.lbcel.AutoSize = true;
            this.lbcel.BackColor = System.Drawing.Color.LightBlue;
            this.lbcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcel.Location = new System.Drawing.Point(356, 68);
            this.lbcel.Name = "lbcel";
            this.lbcel.Size = new System.Drawing.Size(69, 20);
            this.lbcel.TabIndex = 33;
            this.lbcel.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Contraseña";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(356, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Departamento";
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(525, 65);
            this.txtCel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(126, 25);
            this.txtCel.TabIndex = 35;
            // 
            // txt_Tipo_Empleado
            // 
            this.txt_Tipo_Empleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tipo_Empleado.Location = new System.Drawing.Point(525, 123);
            this.txt_Tipo_Empleado.Name = "txt_Tipo_Empleado";
            this.txt_Tipo_Empleado.Size = new System.Drawing.Size(173, 25);
            this.txt_Tipo_Empleado.TabIndex = 27;
            // 
            // txt_Departamento
            // 
            this.txt_Departamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Departamento.Location = new System.Drawing.Point(525, 152);
            this.txt_Departamento.Name = "txt_Departamento";
            this.txt_Departamento.Size = new System.Drawing.Size(173, 25);
            this.txt_Departamento.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(356, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Tipo de Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefono";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefon.Location = new System.Drawing.Point(175, 168);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(143, 25);
            this.txt_Telefon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(175, 64);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(143, 25);
            this.txt_Cedula.TabIndex = 5;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.Location = new System.Drawing.Point(175, 142);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(143, 25);
            this.txt_Correo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cedula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apellidos";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(175, 90);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(143, 25);
            this.txt_Nombre.TabIndex = 7;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(175, 116);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(143, 25);
            this.txt_Apellidos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "Buscar por numero de cedula";
            // 
            // lbl_IdPesona
            // 
            this.lbl_IdPesona.AutoSize = true;
            this.lbl_IdPesona.Location = new System.Drawing.Point(522, 15);
            this.lbl_IdPesona.Name = "lbl_IdPesona";
            this.lbl_IdPesona.Size = new System.Drawing.Size(73, 18);
            this.lbl_IdPesona.TabIndex = 51;
            this.lbl_IdPesona.Text = ".............";
            // 
            // Agregar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 666);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt_BuscarUsr);
            this.Controls.Add(this.dgv_Personas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Agregar_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Usuarios";
            this.Load += new System.EventHandler(this.Agregar_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscarTodos;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txt_BuscarUsr;
        private System.Windows.Forms.DataGridView dgv_Personas;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button btn_Agregar_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lbcel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbEsempleado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Tipo_Empleado;
        private System.Windows.Forms.TextBox txt_Departamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Direccion_Cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_EsEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_TipoUsuario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_IdPesona;
    }
}