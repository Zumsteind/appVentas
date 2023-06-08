
namespace vistaE
{
    partial class listarproductos
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
            this.dgvlistarproductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistarproductos
            // 
            this.dgvlistarproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarproductos.Location = new System.Drawing.Point(77, 58);
            this.dgvlistarproductos.Name = "dgvlistarproductos";
            this.dgvlistarproductos.Size = new System.Drawing.Size(666, 272);
            this.dgvlistarproductos.TabIndex = 0;
            this.dgvlistarproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistarproductos_CellContentClick);
            // 
            // listarproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvlistarproductos);
            this.Name = "listarproductos";
            this.Text = "listarproductos";
            this.Load += new System.EventHandler(this.listarproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistarproductos;
    }
}