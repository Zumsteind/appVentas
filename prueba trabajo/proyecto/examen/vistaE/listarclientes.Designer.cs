
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistarcliente
            // 
            this.dgvlistarcliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvlistarcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarcliente.Location = new System.Drawing.Point(277, 203);
            this.dgvlistarcliente.Name = "dgvlistarcliente";
            this.dgvlistarcliente.Size = new System.Drawing.Size(557, 306);
            this.dgvlistarcliente.TabIndex = 0;
            this.dgvlistarcliente.SelectionChanged += new System.EventHandler(this.dgvlistarcliente_SelectionChanged);
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Location = new System.Drawing.Point(279, 145);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(328, 20);
            this.txtbuscarcliente.TabIndex = 1;
            this.txtbuscarcliente.TextChanged += new System.EventHandler(this.txtbuscarcliente_TextChanged);
            this.txtbuscarcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarcliente_KeyPress);
            // 
            // lblBcliente
            // 
            this.lblBcliente.AutoSize = true;
            this.lblBcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBcliente.Location = new System.Drawing.Point(112, 145);
            this.lblBcliente.Name = "lblBcliente";
            this.lblBcliente.Size = new System.Drawing.Size(142, 24);
            this.lblBcliente.TabIndex = 2;
            this.lblBcliente.Text = "Buscar cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de clientes";
            // 
            // listarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBcliente);
            this.Controls.Add(this.txtbuscarcliente);
            this.Controls.Add(this.dgvlistarcliente);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
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
        private System.Windows.Forms.Label label1;
    }
}