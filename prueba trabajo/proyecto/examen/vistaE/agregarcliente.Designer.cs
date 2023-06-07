
namespace vistaE
{
    partial class agregarcliente
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
            this.lblagregarcliente = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblagregarcliente
            // 
            this.lblagregarcliente.AutoSize = true;
            this.lblagregarcliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblagregarcliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagregarcliente.Location = new System.Drawing.Point(135, 104);
            this.lblagregarcliente.Name = "lblagregarcliente";
            this.lblagregarcliente.Size = new System.Drawing.Size(154, 22);
            this.lblagregarcliente.TabIndex = 0;
            this.lblagregarcliente.Text = "Agregar Cliente";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(213, 169);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Cliente:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(213, 210);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(52, 13);
            this.lbltelefono.TabIndex = 2;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(213, 245);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(41, 13);
            this.lblcorreo.TabIndex = 3;
            this.lblcorreo.Text = "Correo:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(312, 162);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(137, 20);
            this.txtcliente.TabIndex = 4;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(312, 203);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(137, 20);
            this.txttelefono.TabIndex = 5;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(312, 238);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(137, 20);
            this.txtcorreo.TabIndex = 6;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(312, 304);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(111, 23);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // agregarcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 463);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lblagregarcliente);
            this.MaximumSize = new System.Drawing.Size(663, 502);
            this.MinimumSize = new System.Drawing.Size(663, 502);
            this.Name = "agregarcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarcliente";
            this.Load += new System.EventHandler(this.agregarcliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagregarcliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button btnagregar;
    }
}