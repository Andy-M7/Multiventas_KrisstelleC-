using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiventas_Krisstelle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Establecer el inicio del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

            // Establecer el texto por defecto en txtDineroCaja
            txtDineroCaja.Text = "00.00";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación cuando se hace clic en el botón "Salir"
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDineroCaja_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;

            // Guardar la posición del cursor
            int selectionStart = textBox.SelectionStart;
            int selectionLength = textBox.SelectionLength;

            // Eliminar cualquier carácter no numérico o que no sea un punto decimal
            string newText = Regex.Replace(textBox.Text, @"[^0-9.]", "");

            // Permitir solo un punto decimal
            if (newText.IndexOf('.') != newText.LastIndexOf('.'))
            {
                newText = newText.Remove(newText.LastIndexOf('.'), 1);
            }

            // Limitar a dos decimales
            int index = newText.IndexOf('.');
            if (index != -1 && newText.Length - index - 1 > 2)
            {
                newText = newText.Substring(0, index + 3);
            }

            // Actualizar el texto solo si ha cambiado
            if (textBox.Text != newText)
            {
                textBox.Text = newText;
                // Restaurar la posición del cursor
                textBox.SelectionStart = selectionStart;
                textBox.SelectionLength = selectionLength;
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar y registrar el dinero en caja
            if (decimal.TryParse(txtDineroCaja.Text, out decimal dineroCaja))
            {
                // Aquí puedes agregar el código para registrar el dinero en caja

                // Crear una instancia de Form3
                VentanaPrincipal form3 = new VentanaPrincipal();

                // Mostrar Form3
                form3.Show();

                // Ocultar Form2
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de dinero.");
            }
        }
    }
}
