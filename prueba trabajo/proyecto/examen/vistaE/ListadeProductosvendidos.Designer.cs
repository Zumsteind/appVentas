
namespace vistaE
{
    partial class ListadeProductosvendidos
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
            this.dgvproductosvendidos = new System.Windows.Forms.DataGridView();
            this.lblidventa = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosvendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproductosvendidos
            // 
            this.dgvproductosvendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductosvendidos.Location = new System.Drawing.Point(131, 147);
            this.dgvproductosvendidos.Name = "dgvproductosvendidos";
            this.dgvproductosvendidos.Size = new System.Drawing.Size(576, 273);
            this.dgvproductosvendidos.TabIndex = 0;
            this.dgvproductosvendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosvendidos_CellContentClick);
            // 
            // lblidventa
            // 
            this.lblidventa.AutoSize = true;
            this.lblidventa.Location = new System.Drawing.Point(128, 115);
            this.lblidventa.Name = "lblidventa";
            this.lblidventa.Size = new System.Drawing.Size(77, 13);
            this.lblidventa.TabIndex = 1;
            this.lblidventa.Text = "ID de la venta:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(212, 114);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 20);
            this.lblid.TabIndex = 2;
            // 
            // ListadeProductosvendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblidventa);
            this.Controls.Add(this.dgvproductosvendidos);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "ListadeProductosvendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadeProductosvendidos";
            this.Load += new System.EventHandler(this.ListadeProductosvendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosvendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproductosvendidos;
        private System.Windows.Forms.Label lblidventa;
        private System.Windows.Forms.Label lblid;
    }
}