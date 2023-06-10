
namespace vistaE
{
    partial class menu
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
            this.btnventa = new System.Windows.Forms.Button();
            this.btnagregarcliente = new System.Windows.Forms.Button();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.btnlistarcliente = new System.Windows.Forms.Button();
            this.btnlistarproductos = new System.Windows.Forms.Button();
            this.btnmecliente = new System.Windows.Forms.Button();
            this.btnmeproducto = new System.Windows.Forms.Button();
            this.lbl_menuprincipal = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblventa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnventa
            // 
            this.btnventa.Location = new System.Drawing.Point(469, 252);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(140, 51);
            this.btnventa.TabIndex = 0;
            this.btnventa.Text = "Agregar Venta";
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnagregarcliente
            // 
            this.btnagregarcliente.Location = new System.Drawing.Point(52, 252);
            this.btnagregarcliente.Name = "btnagregarcliente";
            this.btnagregarcliente.Size = new System.Drawing.Size(140, 51);
            this.btnagregarcliente.TabIndex = 1;
            this.btnagregarcliente.Text = "Agregar cliente";
            this.btnagregarcliente.UseVisualStyleBackColor = true;
            this.btnagregarcliente.Click += new System.EventHandler(this.btnagregarcliente_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Location = new System.Drawing.Point(267, 252);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(140, 51);
            this.btnagregarproducto.TabIndex = 2;
            this.btnagregarproducto.Text = "Agregar producto";
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // btnlistarcliente
            // 
            this.btnlistarcliente.Location = new System.Drawing.Point(52, 163);
            this.btnlistarcliente.Name = "btnlistarcliente";
            this.btnlistarcliente.Size = new System.Drawing.Size(140, 51);
            this.btnlistarcliente.TabIndex = 3;
            this.btnlistarcliente.Text = "Ver clientes";
            this.btnlistarcliente.UseVisualStyleBackColor = true;
            this.btnlistarcliente.Click += new System.EventHandler(this.btnlistarcliente_Click);
            // 
            // btnlistarproductos
            // 
            this.btnlistarproductos.Location = new System.Drawing.Point(267, 163);
            this.btnlistarproductos.Name = "btnlistarproductos";
            this.btnlistarproductos.Size = new System.Drawing.Size(140, 51);
            this.btnlistarproductos.TabIndex = 4;
            this.btnlistarproductos.Text = "Ver Productos";
            this.btnlistarproductos.UseVisualStyleBackColor = true;
            this.btnlistarproductos.Click += new System.EventHandler(this.btnlistarproductos_Click);
            // 
            // btnmecliente
            // 
            this.btnmecliente.Location = new System.Drawing.Point(52, 343);
            this.btnmecliente.Name = "btnmecliente";
            this.btnmecliente.Size = new System.Drawing.Size(140, 51);
            this.btnmecliente.TabIndex = 5;
            this.btnmecliente.Text = "Modificar o eliminar cliente";
            this.btnmecliente.UseVisualStyleBackColor = true;
            this.btnmecliente.Click += new System.EventHandler(this.btnmecliente_Click);
            // 
            // btnmeproducto
            // 
            this.btnmeproducto.Location = new System.Drawing.Point(267, 343);
            this.btnmeproducto.Name = "btnmeproducto";
            this.btnmeproducto.Size = new System.Drawing.Size(140, 51);
            this.btnmeproducto.TabIndex = 6;
            this.btnmeproducto.Text = "Modificar o eliminar producto";
            this.btnmeproducto.UseVisualStyleBackColor = true;
            this.btnmeproducto.Click += new System.EventHandler(this.btnmeproducto_Click);
            // 
            // lbl_menuprincipal
            // 
            this.lbl_menuprincipal.AutoSize = true;
            this.lbl_menuprincipal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menuprincipal.Location = new System.Drawing.Point(263, 39);
            this.lbl_menuprincipal.Name = "lbl_menuprincipal";
            this.lbl_menuprincipal.Size = new System.Drawing.Size(178, 24);
            this.lbl_menuprincipal.TabIndex = 7;
            this.lbl_menuprincipal.Text = "Menu Principal";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(74, 106);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(83, 20);
            this.lblcliente.TabIndex = 8;
            this.lblcliente.Text = "CLIENTE";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(294, 106);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(81, 20);
            this.lblproducto.TabIndex = 9;
            this.lblproducto.Text = "Producto";
            // 
            // lblventa
            // 
            this.lblventa.AutoSize = true;
            this.lblventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventa.Location = new System.Drawing.Point(500, 106);
            this.lblventa.Name = "lblventa";
            this.lblventa.Size = new System.Drawing.Size(66, 20);
            this.lblventa.TabIndex = 10;
            this.lblventa.Text = "Ventas";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 498);
            this.Controls.Add(this.lblventa);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lbl_menuprincipal);
            this.Controls.Add(this.btnmeproducto);
            this.Controls.Add(this.btnmecliente);
            this.Controls.Add(this.btnlistarproductos);
            this.Controls.Add(this.btnlistarcliente);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.btnagregarcliente);
            this.Controls.Add(this.btnventa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btnagregarcliente;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.Button btnlistarcliente;
        private System.Windows.Forms.Button btnlistarproductos;
        private System.Windows.Forms.Button btnmecliente;
        private System.Windows.Forms.Button btnmeproducto;
        private System.Windows.Forms.Label lbl_menuprincipal;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lblventa;
    }
}