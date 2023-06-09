
namespace vistaE
{
    partial class agregarproductosaventa
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
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.lblselecione = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblidd = new System.Windows.Forms.Label();
            this.lblprecioo = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(234, 89);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(376, 96);
            this.dgvproductos.TabIndex = 0;
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            this.dgvproductos.SelectionChanged += new System.EventHandler(this.dgvproductos_SelectionChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(234, 53);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(156, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(128, 56);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(85, 13);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar producto";
            // 
            // lblselecione
            // 
            this.lblselecione.AutoSize = true;
            this.lblselecione.Location = new System.Drawing.Point(44, 172);
            this.lblselecione.Name = "lblselecione";
            this.lblselecione.Size = new System.Drawing.Size(169, 13);
            this.lblselecione.TabIndex = 3;
            this.lblselecione.Text = "Seleccione producto para Agregar";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(386, 306);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(149, 43);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar producto";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Location = new System.Drawing.Point(95, 257);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(0, 13);
            this.lblidproducto.TabIndex = 5;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(164, 289);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(0, 13);
            this.lblprecio.TabIndex = 6;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(258, 270);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(122, 20);
            this.txtcantidad.TabIndex = 7;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // lblidd
            // 
            this.lblidd.AutoSize = true;
            this.lblidd.Location = new System.Drawing.Point(68, 252);
            this.lblidd.Name = "lblidd";
            this.lblidd.Size = new System.Drawing.Size(21, 13);
            this.lblidd.TabIndex = 8;
            this.lblidd.Text = "ID:";
            // 
            // lblprecioo
            // 
            this.lblprecioo.AutoSize = true;
            this.lblprecioo.Location = new System.Drawing.Point(68, 289);
            this.lblprecioo.Name = "lblprecioo";
            this.lblprecioo.Size = new System.Drawing.Size(75, 13);
            this.lblprecioo.TabIndex = 9;
            this.lblprecioo.Text = "Precio unidad:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(264, 235);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(86, 13);
            this.lblcantidad.TabIndex = 10;
            this.lblcantidad.Text = "Ingrese cantidad";
            // 
            // agregarproductosaventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblprecioo);
            this.Controls.Add(this.lblidd);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblidproducto);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblselecione);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvproductos);
            this.Name = "agregarproductosaventa";
            this.Text = "agregarproductosaventa";
            this.Load += new System.EventHandler(this.agregarproductosaventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Label lblselecione;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblidd;
        private System.Windows.Forms.Label lblprecioo;
        private System.Windows.Forms.Label lblcantidad;
    }
}