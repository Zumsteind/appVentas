
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
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.lblBcliente = new System.Windows.Forms.Label();
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
            this.dgvlistarcliente.SelectionChanged += new System.EventHandler(this.dgvlistarcliente_SelectionChanged);
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Location = new System.Drawing.Point(235, 33);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(328, 20);
            this.txtbuscarcliente.TabIndex = 1;
            this.txtbuscarcliente.TextChanged += new System.EventHandler(this.txtbuscarcliente_TextChanged);
            this.txtbuscarcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarcliente_KeyPress);
            // 
            // lblBcliente
            // 
            this.lblBcliente.AutoSize = true;
            this.lblBcliente.Location = new System.Drawing.Point(151, 40);
            this.lblBcliente.Name = "lblBcliente";
            this.lblBcliente.Size = new System.Drawing.Size(74, 13);
            this.lblBcliente.TabIndex = 2;
            this.lblBcliente.Text = "Buscar cliente";
            // 
            // listarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBcliente);
            this.Controls.Add(this.txtbuscarcliente);
            this.Controls.Add(this.dgvlistarcliente);
            this.Name = "listarclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listarclientes";
            this.Load += new System.EventHandler(this.listarclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistarcliente;
        private System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.Label lblBcliente;
    }
}