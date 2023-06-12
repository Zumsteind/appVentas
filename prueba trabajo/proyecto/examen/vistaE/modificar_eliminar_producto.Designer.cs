
namespace vistaE
{
    partial class modificar_eliminar_producto
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
            this.dgvlistaproductos = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblbproducto = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistaproductos
            // 
            this.dgvlistaproductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvlistaproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistaproductos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvlistaproductos.Location = new System.Drawing.Point(276, 195);
            this.dgvlistaproductos.Name = "dgvlistaproductos";
            this.dgvlistaproductos.Size = new System.Drawing.Size(460, 249);
            this.dgvlistaproductos.TabIndex = 0;
            this.dgvlistaproductos.SelectionChanged += new System.EventHandler(this.dgvlistaproductos_SelectionChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(96, 485);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(76, 20);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(378, 485);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(69, 20);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Precio: ";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(602, 485);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(92, 20);
            this.lblcategoria.TabIndex = 3;
            this.lblcategoria.Text = "Categoria:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(178, 487);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(162, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(465, 483);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(116, 20);
            this.txtprecio.TabIndex = 5;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(700, 480);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(158, 20);
            this.txtcategoria.TabIndex = 6;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(239, 561);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(194, 60);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(505, 561);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(194, 60);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblbproducto
            // 
            this.lblbproducto.AutoSize = true;
            this.lblbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbproducto.Location = new System.Drawing.Point(114, 135);
            this.lblbproducto.Name = "lblbproducto";
            this.lblbproducto.Size = new System.Drawing.Size(147, 20);
            this.lblbproducto.TabIndex = 9;
            this.lblbproducto.Text = "Buscar Producto:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(276, 135);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(161, 20);
            this.txtbuscar.TabIndex = 10;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(269, 33);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(463, 37);
            this.lbltitulo.TabIndex = 11;
            this.lbltitulo.Text = "Modificar o Eliminar producto";
            // 
            // modificar_eliminar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbproducto);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.dgvlistaproductos);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "modificar_eliminar_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificar_eliminar_producto";
            this.Load += new System.EventHandler(this.modificar_eliminar_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistaproductos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblbproducto;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbltitulo;
    }
}