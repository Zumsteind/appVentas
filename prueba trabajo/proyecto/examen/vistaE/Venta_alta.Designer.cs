
namespace vistaE
{
    partial class Venta_alta
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarcliente = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblseleccioncliente = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.lblncliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(304, 135);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(181, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblBuscarcliente
            // 
            this.lblBuscarcliente.AutoSize = true;
            this.lblBuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarcliente.Location = new System.Drawing.Point(157, 137);
            this.lblBuscarcliente.Name = "lblBuscarcliente";
            this.lblBuscarcliente.Size = new System.Drawing.Size(123, 18);
            this.lblBuscarcliente.TabIndex = 1;
            this.lblBuscarcliente.Text = "Buscar Cliente:";
            // 
            // dgvcliente
            // 
            this.dgvcliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(304, 207);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(474, 206);
            this.dgvcliente.TabIndex = 2;
            this.dgvcliente.SelectionChanged += new System.EventHandler(this.dgvcliente_SelectionChanged);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(304, 432);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(240, 20);
            this.dtpfecha.TabIndex = 3;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(114, 434);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(166, 18);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "2-Seleccione una fecha:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(327, 36);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(270, 37);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = " Iniciamos Venta";
            // 
            // lblseleccioncliente
            // 
            this.lblseleccioncliente.AutoSize = true;
            this.lblseleccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccioncliente.Location = new System.Drawing.Point(114, 287);
            this.lblseleccioncliente.Name = "lblseleccioncliente";
            this.lblseleccioncliente.Size = new System.Drawing.Size(160, 18);
            this.lblseleccioncliente.TabIndex = 6;
            this.lblseleccioncliente.Text = "1-Seleccione un cliente";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(578, 484);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(191, 55);
            this.btnsiguiente.TabIndex = 7;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(173, 342);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(86, 20);
            this.txtidcliente.TabIndex = 8;
            // 
            // lblncliente
            // 
            this.lblncliente.AutoSize = true;
            this.lblncliente.Location = new System.Drawing.Point(101, 349);
            this.lblncliente.Name = "lblncliente";
            this.lblncliente.Size = new System.Drawing.Size(66, 13);
            this.lblncliente.TabIndex = 9;
            this.lblncliente.Text = "n° de cliente";
            // 
            // Venta_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.lblncliente);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.lblseleccioncliente);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.lblBuscarcliente);
            this.Controls.Add(this.txtbuscar);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "Venta_alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta_alta";
            this.Load += new System.EventHandler(this.Venta_alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblBuscarcliente;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblseleccioncliente;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label lblncliente;
    }
}