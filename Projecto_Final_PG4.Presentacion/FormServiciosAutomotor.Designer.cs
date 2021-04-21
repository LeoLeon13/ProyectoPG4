namespace Projecto_Final_PG4.Presentacion
{
    partial class FormServiciosAutomotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServiciosAutomotor));
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvAutosClientes = new System.Windows.Forms.DataGridView();
            this.btn_buscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(169, 27);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(184, 25);
            this.tbxBuscar.TabIndex = 24;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.lbBuscar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(12, 27);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(151, 22);
            this.lbBuscar.TabIndex = 23;
            this.lbBuscar.Text = "Buscar por Placa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(359, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 33);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dgvAutosClientes
            // 
            this.dgvAutosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosClientes.Location = new System.Drawing.Point(16, 66);
            this.dgvAutosClientes.MultiSelect = false;
            this.dgvAutosClientes.Name = "dgvAutosClientes";
            this.dgvAutosClientes.Size = new System.Drawing.Size(609, 298);
            this.dgvAutosClientes.TabIndex = 20;
            // 
            // btn_buscarTodos
            // 
            this.btn_buscarTodos.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarTodos.Location = new System.Drawing.Point(454, 22);
            this.btn_buscarTodos.Name = "btn_buscarTodos";
            this.btn_buscarTodos.Size = new System.Drawing.Size(136, 33);
            this.btn_buscarTodos.TabIndex = 25;
            this.btn_buscarTodos.Text = "Buscar Todos";
            this.btn_buscarTodos.UseVisualStyleBackColor = true;
            this.btn_buscarTodos.Click += new System.EventHandler(this.btn_buscarTodos_Click);
            // 
            // FormServiciosAutomotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 376);
            this.Controls.Add(this.btn_buscarTodos);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvAutosClientes);
            this.Name = "FormServiciosAutomotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormServiciosAutomotor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvAutosClientes;
        private System.Windows.Forms.Button btn_buscarTodos;
    }
}