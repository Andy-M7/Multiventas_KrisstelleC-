using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiventas_Krisstelle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Establecer el inicio del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;

            usuario = txtUsuario.Text;
            password = txtContraseña.Text;

            if (usuario == "HaroldBer" && password == "123")
            {
                // Crear una instancia de Form2
                Form2 form2 = new Form2();

                // Mostrar Form2
                form2.Show();

                // Cerrar Form1
                this.Hide();
            }

            else
                MessageBox.Show("Los datos son incorrectos"); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BORDES OVALADOS
            // Crear un objeto GraphicsPath para definir las esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            int radius = 30; // Radio de redondeo

            // Agregar los arcos para redondear todos los bordes
            path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(this.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90); // Esquina superior derecha
            path.AddArc(new Rectangle(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2), 0, 90); // Esquina inferior derecha
            path.AddArc(new Rectangle(0, this.Height - radius * 2, radius * 2, radius * 2), 90, 90); // Esquina inferior izquierda

            // Crear una región con los bordes redondeados
            Region region = new Region(path);

            // Aplicar la región al formulario
            this.Region = region;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación cuando se hace clic en el botón "Salir"
            Application.Exit();
        }
    }
}
