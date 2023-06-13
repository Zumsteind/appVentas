
namespace vistaE
{
    partial class listar_productos
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproductos
            // 
            this.dgvproductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(225, 175);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(452, 338);
            this.dgvproductos.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(152, 69);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(298, 37);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Lista de productos";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(139, 136);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(88, 13);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar producto:";
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(243, 133);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(150, 20);
            this.txtbuscarproducto.TabIndex = 3;
            this.txtbuscarproducto.TextChanged += new System.EventHandler(this.txtbuscarproducto_TextChanged);
            // 
            // listar_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.txtbuscarproducto);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dgvproductos);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "listar_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listar_productos";
            this.Load += new System.EventHandler(this.listar_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscarproducto;
    }
}