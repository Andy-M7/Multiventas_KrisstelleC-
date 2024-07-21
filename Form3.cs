using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Multiventas_Krisstelle
{
    public partial class Form3 : Form
    {

        private Panel panelSuperior; // Declaración del panel superior

        public Form3()
        {
            InitializeComponent();
            // Establecer el inicio del formulario en pantalla completa
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Configurar el botón btnSalir
            //btnSalir.Text = "X";
            //btnSalir.Location = new Point(this.Width - btnSalir.Width - 20, 20); // Posición en la esquina superior derecha
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Anclar al borde superior y derecho del formulario
            btnSalir.Click += btnSalir_Click; // Asociar evento Click
            // Eventos para sombrear el botón al pasar el cursor sobre él
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;    

            // Configurar el panel superior
            panel1.Dock = DockStyle.Top; // Alinear al borde superior del formulario


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color de fondo (o cualquier otro estilo) al pasar el cursor sobre el botón
            btnSalir.BackColor = Color.DarkRed;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo (o cualquier otro estilo) cuando el cursor sale del botón
            /*btnSalir.BackColor = Color.Red;*/
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
         
            // Crear una instancia del formulario de productos
            FormProductos formProductos = new FormProductos();

            // Mostrar el formulario de productos
            formProductos.ShowDialog();//// Mostrar el formulario de productos como modal, es decir que no pueda interactuar con el form3

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario form4 = new Inventario();
            form4.ShowDialog();
        }
    }
}
