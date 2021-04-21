namespace Projecto_Final_PG4.Presentacion
{
    partial class FormServicciosClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicciosClientes));
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.dgvServiciosClientes = new System.Windows.Forms.DataGridView();
            this.btn_BuscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(295, 9);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(169, 25);
            this.tbxBuscar.TabIndex = 28;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.lbBuscar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(37, 9);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(252, 22);
            this.lbBuscar.TabIndex = 27;
            this.lbBuscar.Text = "Buscar por numero de cedula";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(295, 40);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 26;
            this.buscar.Text = "Buscar servicio";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click_1);
            // 
            // dgvServiciosClientes
            // 
            this.dgvServiciosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiciosClientes.Location = new System.Drawing.Point(12, 69);
            this.dgvServiciosClientes.Name = "dgvServiciosClientes";
            this.dgvServiciosClientes.Size = new System.Drawing.Size(530, 150);
            this.dgvServiciosClientes.TabIndex = 24;
            // 
            // btn_BuscarTodos
            // 
            this.btn_BuscarTodos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarTodos.Location = new System.Drawing.Point(376, 40);
            this.btn_BuscarTodos.Name = "btn_BuscarTodos";
            this.btn_BuscarTodos.Size = new System.Drawing.Size(110, 23);
            this.btn_BuscarTodos.TabIndex = 29;
            this.btn_BuscarTodos.Text = "Buscar Todos";
            this.btn_BuscarTodos.UseVisualStyleBackColor = true;
            this.btn_BuscarTodos.Click += new System.EventHandler(this.btn_BuscarTodos_Click);
            // 
            // FormServicciosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 240);
            this.Controls.Add(this.btn_BuscarTodos);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.dgvServiciosClientes);
            this.Name = "FormServicciosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormServicciosClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView dgvServiciosClientes;
        private System.Windows.Forms.Button btn_BuscarTodos;
    }
}