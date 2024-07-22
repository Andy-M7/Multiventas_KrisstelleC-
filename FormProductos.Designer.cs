namespace Multiventas_Krisstelle
{
    partial class FormProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSolicitarCotizacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnSolicitarCotizacion);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(1159, 7);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(59, 46);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSolicitarCotizacion
            // 
            this.btnSolicitarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarCotizacion.Location = new System.Drawing.Point(367, 9);
            this.btnSolicitarCotizacion.Name = "btnSolicitarCotizacion";
            this.btnSolicitarCotizacion.Size = new System.Drawing.Size(219, 42);
            this.btnSolicitarCotizacion.TabIndex = 3;
            this.btnSolicitarCotizacion.Text = "Solicitar Cotización";
            this.btnSolicitarCotizacion.UseVisualStyleBackColor = true;
            this.btnSolicitarCotizacion.Click += new System.EventHandler(this.btnSolicitarCotizacion_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 541);
            this.panel2.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(74, 9);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(195, 42);
            this.btnBuscarProducto.TabIndex = 5;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 603);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FormProductos";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSolicitarCotizacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}