﻿
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
            this.btnfinalizarventa = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotaldeventa = new System.Windows.Forms.Label();
            this.label1qw = new System.Windows.Forms.Label();
            this.btncancelarventa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvproductosconfirmados = new System.Windows.Forms.DataGridView();
            this.lbltitulodelosproductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosconfirmados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproductos
            // 
            this.dgvproductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(261, 131);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(460, 176);
            this.dgvproductos.TabIndex = 0;
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            this.dgvproductos.SelectionChanged += new System.EventHandler(this.dgvproductos_SelectionChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(183, 91);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(156, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(21, 89);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(141, 20);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar producto";
            // 
            // lblselecione
            // 
            this.lblselecione.AutoSize = true;
            this.lblselecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselecione.Location = new System.Drawing.Point(12, 247);
            this.lblselecione.Name = "lblselecione";
            this.lblselecione.Size = new System.Drawing.Size(232, 18);
            this.lblselecione.TabIndex = 3;
            this.lblselecione.Text = "Seleccione producto para Agregar";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(677, 342);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(149, 43);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar producto";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Location = new System.Drawing.Point(360, 336);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(0, 13);
            this.lblidproducto.TabIndex = 5;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(387, 372);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(0, 13);
            this.lblprecio.TabIndex = 6;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(504, 365);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(122, 20);
            this.txtcantidad.TabIndex = 7;
            this.txtcantidad.Text = "1";
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // lblidd
            // 
            this.lblidd.AutoSize = true;
            this.lblidd.Location = new System.Drawing.Point(333, 331);
            this.lblidd.Name = "lblidd";
            this.lblidd.Size = new System.Drawing.Size(21, 13);
            this.lblidd.TabIndex = 8;
            this.lblidd.Text = "ID:";
            // 
            // lblprecioo
            // 
            this.lblprecioo.AutoSize = true;
            this.lblprecioo.Location = new System.Drawing.Point(291, 372);
            this.lblprecioo.Name = "lblprecioo";
            this.lblprecioo.Size = new System.Drawing.Size(75, 13);
            this.lblprecioo.TabIndex = 9;
            this.lblprecioo.Text = "Precio unidad:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(510, 330);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(86, 13);
            this.lblcantidad.TabIndex = 10;
            this.lblcantidad.Text = "Ingrese cantidad";
            // 
            // btnfinalizarventa
            // 
            this.btnfinalizarventa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnfinalizarventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizarventa.Location = new System.Drawing.Point(793, 532);
            this.btnfinalizarventa.Name = "btnfinalizarventa";
            this.btnfinalizarventa.Size = new System.Drawing.Size(139, 55);
            this.btnfinalizarventa.TabIndex = 11;
            this.btnfinalizarventa.Text = "Realizar venta";
            this.btnfinalizarventa.UseVisualStyleBackColor = false;
            this.btnfinalizarventa.Click += new System.EventHandler(this.btnfinalizarventa_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(618, 494);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(91, 13);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "Total de la Venta:";
            // 
            // lbltotaldeventa
            // 
            this.lbltotaldeventa.AutoSize = true;
            this.lbltotaldeventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldeventa.Location = new System.Drawing.Point(715, 486);
            this.lbltotaldeventa.Name = "lbltotaldeventa";
            this.lbltotaldeventa.Size = new System.Drawing.Size(38, 24);
            this.lbltotaldeventa.TabIndex = 13;
            this.lbltotaldeventa.Text = "0 $";
            // 
            // label1qw
            // 
            this.label1qw.AutoSize = true;
            this.label1qw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1qw.Location = new System.Drawing.Point(230, 18);
            this.label1qw.Name = "label1qw";
            this.label1qw.Size = new System.Drawing.Size(428, 37);
            this.label1qw.TabIndex = 14;
            this.label1qw.Text = "Agregar productos a Venta";
            // 
            // btncancelarventa
            // 
            this.btncancelarventa.BackColor = System.Drawing.Color.Red;
            this.btncancelarventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarventa.Location = new System.Drawing.Point(793, 594);
            this.btncancelarventa.Name = "btncancelarventa";
            this.btncancelarventa.Size = new System.Drawing.Size(139, 55);
            this.btncancelarventa.TabIndex = 15;
            this.btncancelarventa.Text = "Cancelar venta";
            this.btncancelarventa.UseVisualStyleBackColor = false;
            this.btncancelarventa.Click += new System.EventHandler(this.btncancelarventa_Click);
            // 
            // dgvproductosconfirmados
            // 
            this.dgvproductosconfirmados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvproductosconfirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductosconfirmados.Location = new System.Drawing.Point(51, 451);
            this.dgvproductosconfirmados.Name = "dgvproductosconfirmados";
            this.dgvproductosconfirmados.Size = new System.Drawing.Size(563, 149);
            this.dgvproductosconfirmados.TabIndex = 16;
            // 
            // lbltitulodelosproductos
            // 
            this.lbltitulodelosproductos.AutoSize = true;
            this.lbltitulodelosproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulodelosproductos.Location = new System.Drawing.Point(48, 432);
            this.lbltitulodelosproductos.Name = "lbltitulodelosproductos";
            this.lbltitulodelosproductos.Size = new System.Drawing.Size(234, 16);
            this.lbltitulodelosproductos.TabIndex = 17;
            this.lbltitulodelosproductos.Text = "Productos agregados a la venta:";
            // 
            // agregarproductosaventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.lbltitulodelosproductos);
            this.Controls.Add(this.dgvproductosconfirmados);
            this.Controls.Add(this.btncancelarventa);
            this.Controls.Add(this.label1qw);
            this.Controls.Add(this.lbltotaldeventa);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnfinalizarventa);
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
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "agregarproductosaventa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarproductosaventa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.agregarproductosaventa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.agregarproductosaventa_FormClosed);
            this.Load += new System.EventHandler(this.agregarproductosaventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosconfirmados)).EndInit();
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
        private System.Windows.Forms.Button btnfinalizarventa;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotaldeventa;
        private System.Windows.Forms.Label label1qw;
        private System.Windows.Forms.Button btncancelarventa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvproductosconfirmados;
        private System.Windows.Forms.Label lbltitulodelosproductos;
    }
}