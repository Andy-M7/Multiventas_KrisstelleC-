namespace Multiventas_Krisstelle
{
    partial class Inventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirInventario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalirInventario);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 57);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(246, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventario";
            // 
            // btnSalirInventario
            // 
            this.btnSalirInventario.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirInventario.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSalirInventario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalirInventario.Location = new System.Drawing.Point(598, 10);
            this.btnSalirInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirInventario.Name = "btnSalirInventario";
            this.btnSalirInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalirInventario.Size = new System.Drawing.Size(44, 37);
            this.btnSalirInventario.TabIndex = 2;
            this.btnSalirInventario.Text = "X";
            this.btnSalirInventario.UseVisualStyleBackColor = false;
            this.btnSalirInventario.Click += new System.EventHandler(this.btnSalirInventario_Click);
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Multiventas_Krisstelle.Properties.Resources.RegistrarProducto;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(399, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 137);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registro De Producto";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Multiventas_Krisstelle.Properties.Resources.Inventario63;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(117, 170);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(139, 137);
            this.button1.TabIndex = 5;
            this.button1.Text = "Recepcion De Producto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "CAJERO:";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(540, 492);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(27, 13);
            this.lblCajero.TabIndex = 8;
            this.lblCajero.Text = "user";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 535);
            this.Controls.Add(this.lblCajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Inventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalirInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCajero;
    }
}