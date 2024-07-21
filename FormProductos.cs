using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiventas_Krisstelle
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();

            panel1.Dock = DockStyle.Top; // Alinear al borde superior del formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario a agregar
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto();
            formAgregarProducto.TopLevel = false; // Hace que el formulario no sea de nivel superior
            formAgregarProducto.FormBorderStyle = FormBorderStyle.None; // Quita los bordes del formulario
            formAgregarProducto.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño de panel2

            // Agrega el formulario a panel2 y lo muestra
            panel2.Controls.Add(formAgregarProducto);
            formAgregarProducto.Show();
        }
    }
}
