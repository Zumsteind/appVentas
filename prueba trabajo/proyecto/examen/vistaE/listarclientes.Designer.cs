
namespace vistaE
{
    partial class listarclientes
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
            this.dgvlistarcliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistarcliente
            // 
            this.dgvlistarcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarcliente.Location = new System.Drawing.Point(110, 80);
            this.dgvlistarcliente.Name = "dgvlistarcliente";
            this.dgvlistarcliente.Size = new System.Drawing.Size(557, 306);
            this.dgvlistarcliente.TabIndex = 0;
            // 
            // listarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvlistarcliente);
            this.Name = "listarclientes";
            this.Text = "listarclientes";
            this.Load += new System.EventHandler(this.listarclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistarcliente;
    }
}