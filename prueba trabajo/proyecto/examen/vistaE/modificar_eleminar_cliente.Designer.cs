
namespace vistaE
{
    partial class modificar_eleminar_cliente
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
            this.dgvlistaclientes = new System.Windows.Forms.DataGridView();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtbcliente = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistaclientes
            // 
            this.dgvlistaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistaclientes.Location = new System.Drawing.Point(180, 76);
            this.dgvlistaclientes.Name = "dgvlistaclientes";
            this.dgvlistaclientes.Size = new System.Drawing.Size(445, 275);
            this.dgvlistaclientes.TabIndex = 0;
            this.dgvlistaclientes.SelectionChanged += new System.EventHandler(this.dgvlistaclientes_SelectionChanged);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(32, 390);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Cliente:";
            this.lblcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(80, 383);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(162, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(267, 391);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(52, 13);
            this.lbltelefono.TabIndex = 3;
            this.lbltelefono.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(325, 387);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(151, 20);
            this.txttelefono.TabIndex = 4;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(499, 395);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(41, 13);
            this.lblcorreo.TabIndex = 5;
            this.lblcorreo.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(546, 388);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(214, 20);
            this.txtcorreo.TabIndex = 6;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(204, 428);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(151, 27);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(453, 431);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(172, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(44, 367);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(246, 13);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "Seleccione un cliente y presione acción con botón";
            // 
            // txtbcliente
            // 
            this.txtbcliente.Location = new System.Drawing.Point(199, 41);
            this.txtbcliente.Name = "txtbcliente";
            this.txtbcliente.Size = new System.Drawing.Size(228, 20);
            this.txtbcliente.TabIndex = 10;
            this.txtbcliente.TextChanged += new System.EventHandler(this.txtbcliente_TextChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(119, 41);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(74, 13);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "Buscar cliente";
            // 
            // modificar_eleminar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 515);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtbcliente);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.dgvlistaclientes);
            this.Name = "modificar_eleminar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificar_eleminar_cliente";
            this.Load += new System.EventHandler(this.modificar_eleminar_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistaclientes;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtbcliente;
        private System.Windows.Forms.Label lblnombre;
    }
}