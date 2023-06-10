
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvventas
            // 
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Location = new System.Drawing.Point(143, 111);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(560, 175);
            this.dgvventas.TabIndex = 0;
            // 
            // dtpfechaventa
            // 
            this.dtpfechaventa.Location = new System.Drawing.Point(143, 66);
            this.dtpfechaventa.Name = "dtpfechaventa";
            this.dtpfechaventa.Size = new System.Drawing.Size(222, 20);
            this.dtpfechaventa.TabIndex = 1;
            this.dtpfechaventa.ValueChanged += new System.EventHandler(this.dtpfechaventa_ValueChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(140, 37);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(160, 13);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Seleccione la fecha de la venta:";
            // 
            // listar_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dtpfechaventa);
            this.Controls.Add(this.dgvventas);
            this.Name = "listar_ventas";
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
    }
}