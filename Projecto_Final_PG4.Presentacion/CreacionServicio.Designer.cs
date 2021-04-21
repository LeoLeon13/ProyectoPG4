namespace Projecto_Final_PG4.Presentacion
{
    partial class CreacionServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreacionServicio));
            this.cklxServiciosRequeridos = new System.Windows.Forms.CheckedListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTiposServicios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaServicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Servicios = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cbx_VehiculosDisp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstx_Servicios = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicios)).BeginInit();
            this.SuspendLayout();
            // 
            // cklxServiciosRequeridos
            // 
            this.cklxServiciosRequeridos.BackColor = System.Drawing.SystemColors.Control;
            this.cklxServiciosRequeridos.FormattingEnabled = true;
            this.cklxServiciosRequeridos.Items.AddRange(new object[] {
            "Cambio Aceite",
            "Cambio Liquidos",
            "Revision Menor",
            "Cambio Llantas",
            "Rotacion Llantas",
            "Revision Motor",
            "Revision de Caja Cambios",
            "Revision de Frenos",
            "Cambio de frenos"});
            this.cklxServiciosRequeridos.Location = new System.Drawing.Point(458, 36);
            this.cklxServiciosRequeridos.Margin = new System.Windows.Forms.Padding(4);
            this.cklxServiciosRequeridos.Name = "cklxServiciosRequeridos";
            this.cklxServiciosRequeridos.Size = new System.Drawing.Size(285, 124);
            this.cklxServiciosRequeridos.TabIndex = 28;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 171);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 30);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seleccione los servicios requeridos:";
            // 
            // cbxTiposServicios
            // 
            this.cbxTiposServicios.FormattingEnabled = true;
            this.cbxTiposServicios.Items.AddRange(new object[] {
            "Seleccione",
            "Revision Mayor.",
            "Revision Menor.",
            "A Domicilio.",
            "Correctivo."});
            this.cbxTiposServicios.Location = new System.Drawing.Point(197, 122);
            this.cbxTiposServicios.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTiposServicios.Name = "cbxTiposServicios";
            this.cbxTiposServicios.Size = new System.Drawing.Size(253, 25);
            this.cbxTiposServicios.TabIndex = 24;
            this.cbxTiposServicios.SelectedIndexChanged += new System.EventHandler(this.cbxTiposServicios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tipo de servicio:";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(197, 23);
            this.cbxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(253, 25);
            this.cbxClientes.TabIndex = 22;
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.cbxClientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seleccione la fecha:";
            // 
            // dtpFechaServicio
            // 
            this.dtpFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaServicio.Location = new System.Drawing.Point(197, 89);
            this.dtpFechaServicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaServicio.Name = "dtpFechaServicio";
            this.dtpFechaServicio.Size = new System.Drawing.Size(253, 25);
            this.dtpFechaServicio.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione el cliente:";
            // 
            // dgv_Servicios
            // 
            this.dgv_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Servicios.Location = new System.Drawing.Point(16, 209);
            this.dgv_Servicios.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Servicios.MultiSelect = false;
            this.dgv_Servicios.Name = "dgv_Servicios";
            this.dgv_Servicios.ReadOnly = true;
            this.dgv_Servicios.Size = new System.Drawing.Size(507, 214);
            this.dgv_Servicios.TabIndex = 29;
            this.dgv_Servicios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Servicios_MouseClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(156, 171);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(132, 30);
            this.btn_limpiar.TabIndex = 30;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
            // 
            // cbx_VehiculosDisp
            // 
            this.cbx_VehiculosDisp.FormattingEnabled = true;
            this.cbx_VehiculosDisp.Location = new System.Drawing.Point(197, 56);
            this.cbx_VehiculosDisp.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_VehiculosDisp.Name = "cbx_VehiculosDisp";
            this.cbx_VehiculosDisp.Size = new System.Drawing.Size(253, 25);
            this.cbx_VehiculosDisp.TabIndex = 32;
            this.cbx_VehiculosDisp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Seleccione el vehiculo:";
            // 
            // lstx_Servicios
            // 
            this.lstx_Servicios.FormattingEnabled = true;
            this.lstx_Servicios.ItemHeight = 17;
            this.lstx_Servicios.Location = new System.Drawing.Point(530, 215);
            this.lstx_Servicios.Name = "lstx_Servicios";
            this.lstx_Servicios.Size = new System.Drawing.Size(210, 208);
            this.lstx_Servicios.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Servicios del vehiculo ";
            // 
            // CreacionServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 442);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstx_Servicios);
            this.Controls.Add(this.cbx_VehiculosDisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dgv_Servicios);
            this.Controls.Add(this.cklxServiciosRequeridos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTiposServicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaServicio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreacionServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreacionServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklxServiciosRequeridos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTiposServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Servicios;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ComboBox cbx_VehiculosDisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstx_Servicios;
        private System.Windows.Forms.Label label7;
    }
}