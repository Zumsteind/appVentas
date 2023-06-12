
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistaclientes
            // 
            this.dgvlistaclientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvlistaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistaclientes.Location = new System.Drawing.Point(250, 130);
            this.dgvlistaclientes.Name = "dgvlistaclientes";
            this.dgvlistaclientes.Size = new System.Drawing.Size(445, 275);
            this.dgvlistaclientes.TabIndex = 0;
            this.dgvlistaclientes.SelectionChanged += new System.EventHandler(this.dgvlistaclientes_SelectionChanged);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(59, 480);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(60, 16);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Cliente:";
            this.lblcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(138, 476);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(168, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(312, 477);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(84, 20);
            this.lbltelefono.TabIndex = 3;
            this.lbltelefono.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(402, 479);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(166, 20);
            this.txttelefono.TabIndex = 4;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.Location = new System.Drawing.Point(584, 479);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(68, 20);
            this.lblcorreo.TabIndex = 5;
            this.lblcorreo.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(658, 480);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(239, 20);
            this.txtcorreo.TabIndex = 6;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(250, 543);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(172, 58);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(505, 543);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(172, 58);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(93, 423);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(360, 20);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "Seleccione un cliente y presione acción con botón";
            // 
            // txtbcliente
            // 
            this.txtbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbcliente.Location = new System.Drawing.Point(250, 84);
            this.txtbcliente.Name = "txtbcliente";
            this.txtbcliente.Size = new System.Drawing.Size(228, 26);
            this.txtbcliente.TabIndex = 10;
            this.txtbcliente.TextChanged += new System.EventHandler(this.txtbcliente_TextChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(121, 90);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(123, 20);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "Buscar cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elimine o Modifique cliente";
            // 
            // modificar_eleminar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label1);
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
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
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
        private System.Windows.Forms.Label label1;
    }
}