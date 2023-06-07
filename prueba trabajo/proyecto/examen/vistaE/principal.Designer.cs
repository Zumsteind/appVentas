
namespace vistaE
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuarchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuagregarcliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuagregarproducto = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuarchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuarchivo
            // 
            this.menuarchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuagregarcliente,
            this.menuagregarproducto,
            this.listarClientesToolStripMenuItem});
            this.menuarchivo.Name = "menuarchivo";
            this.menuarchivo.Size = new System.Drawing.Size(60, 20);
            this.menuarchivo.Text = "Archivo";
            // 
            // menuagregarcliente
            // 
            this.menuagregarcliente.Name = "menuagregarcliente";
            this.menuagregarcliente.Size = new System.Drawing.Size(180, 22);
            this.menuagregarcliente.Text = "Agregar cliente";
            this.menuagregarcliente.Click += new System.EventHandler(this.menuagregarcliente_Click);
            // 
            // menuagregarproducto
            // 
            this.menuagregarproducto.Name = "menuagregarproducto";
            this.menuagregarproducto.Size = new System.Drawing.Size(180, 22);
            this.menuagregarproducto.Text = "Agregar producto";
            this.menuagregarproducto.Click += new System.EventHandler(this.menuagregarproducto_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zumsteind Facundo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuarchivo;
        private System.Windows.Forms.ToolStripMenuItem menuagregarcliente;
        private System.Windows.Forms.ToolStripMenuItem menuagregarproducto;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
    }
}