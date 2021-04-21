
namespace Projecto_Final_PG4.Presentacion
{
    partial class Form1
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
            this.btn_frm_Usuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_frm_Usuarios
            // 
            this.btn_frm_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frm_Usuarios.Location = new System.Drawing.Point(334, 206);
            this.btn_frm_Usuarios.Name = "btn_frm_Usuarios";
            this.btn_frm_Usuarios.Size = new System.Drawing.Size(352, 183);
            this.btn_frm_Usuarios.TabIndex = 0;
            this.btn_frm_Usuarios.Text = "Usuarios";
            this.btn_frm_Usuarios.UseVisualStyleBackColor = true;
            this.btn_frm_Usuarios.Click += new System.EventHandler(this.btn_frm_Usuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 645);
            this.Controls.Add(this.btn_frm_Usuarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_frm_Usuarios;
    }
}

