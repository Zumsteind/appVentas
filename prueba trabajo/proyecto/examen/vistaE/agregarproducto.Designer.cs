﻿
namespace vistaE
{
    partial class agregarproducto
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
            this.lblagregarproducto = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btbagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblagregarproducto
            // 
            this.lblagregarproducto.AutoSize = true;
            this.lblagregarproducto.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagregarproducto.Location = new System.Drawing.Point(281, 76);
            this.lblagregarproducto.Name = "lblagregarproducto";
            this.lblagregarproducto.Size = new System.Drawing.Size(286, 37);
            this.lblagregarproducto.TabIndex = 0;
            this.lblagregarproducto.Text = "Agregar producto";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(296, 201);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(84, 24);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(311, 244);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(69, 24);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Precio:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(284, 283);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(95, 24);
            this.lblcategoria.TabIndex = 3;
            this.lblcategoria.Text = "Categoria:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(415, 201);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(152, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(415, 244);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(152, 20);
            this.txtprecio.TabIndex = 5;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(415, 287);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(152, 20);
            this.txtcategoria.TabIndex = 6;
            // 
            // btbagregar
            // 
            this.btbagregar.Location = new System.Drawing.Point(415, 368);
            this.btbagregar.Name = "btbagregar";
            this.btbagregar.Size = new System.Drawing.Size(145, 75);
            this.btbagregar.TabIndex = 7;
            this.btbagregar.Text = "Agregar";
            this.btbagregar.UseVisualStyleBackColor = true;
            this.btbagregar.Click += new System.EventHandler(this.btbagregar_Click);
            // 
            // agregarproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btbagregar);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblagregarproducto);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "agregarproducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarproducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagregarproducto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btbagregar;
    }
}