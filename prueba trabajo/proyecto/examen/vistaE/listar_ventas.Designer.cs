
namespace vistaE
{
    partial class listar_ventas
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
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.dtpfechaventa = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btvverproductosdeventa = new System.Windows.Forms.Button();
            this.lblidseleccionado = new System.Windows.Forms.Label();
            this.lblidventa = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvventas
            // 
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Location = new System.Drawing.Point(220, 270);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(560, 175);
            this.dgvventas.TabIndex = 0;
            this.dgvventas.SelectionChanged += new System.EventHandler(this.dgvventas_SelectionChanged);
            // 
            // dtpfechaventa
            // 
            this.dtpfechaventa.Location = new System.Drawing.Point(220, 204);
            this.dtpfechaventa.Name = "dtpfechaventa";
            this.dtpfechaventa.Size = new System.Drawing.Size(222, 20);
            this.dtpfechaventa.TabIndex = 1;
            this.dtpfechaventa.ValueChanged += new System.EventHandler(this.dtpfechaventa_ValueChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(216, 159);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(264, 20);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Seleccione la fecha de la venta:";
            // 
            // btvverproductosdeventa
            // 
            this.btvverproductosdeventa.Location = new System.Drawing.Point(589, 513);
            this.btvverproductosdeventa.Name = "btvverproductosdeventa";
            this.btvverproductosdeventa.Size = new System.Drawing.Size(191, 56);
            this.btvverproductosdeventa.TabIndex = 3;
            this.btvverproductosdeventa.Text = "Ver productos de venta";
            this.btvverproductosdeventa.UseVisualStyleBackColor = true;
            this.btvverproductosdeventa.Click += new System.EventHandler(this.btvverproductosdeventa_Click);
            // 
            // lblidseleccionado
            // 
            this.lblidseleccionado.AutoSize = true;
            this.lblidseleccionado.Location = new System.Drawing.Point(217, 535);
            this.lblidseleccionado.Name = "lblidseleccionado";
            this.lblidseleccionado.Size = new System.Drawing.Size(63, 13);
            this.lblidseleccionado.TabIndex = 4;
            this.lblidseleccionado.Text = "ID VENTA: ";
            // 
            // lblidventa
            // 
            this.lblidventa.AutoSize = true;
            this.lblidventa.Location = new System.Drawing.Point(286, 535);
            this.lblidventa.Name = "lblidventa";
            this.lblidventa.Size = new System.Drawing.Size(0, 13);
            this.lblidventa.TabIndex = 5;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(333, 49);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(253, 37);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Lista de Ventas";
            // 
            // listar_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblidventa);
            this.Controls.Add(this.lblidseleccionado);
            this.Controls.Add(this.btvverproductosdeventa);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dtpfechaventa);
            this.Controls.Add(this.dgvventas);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "listar_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listar_ventas";
            this.Load += new System.EventHandler(this.listar_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvventas;
        private System.Windows.Forms.DateTimePicker dtpfechaventa;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btvverproductosdeventa;
        private System.Windows.Forms.Label lblidseleccionado;
        private System.Windows.Forms.Label lblidventa;
        private System.Windows.Forms.Label lbltitulo;
    }
}