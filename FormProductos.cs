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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSolicitarCotizacion_Click(object sender, EventArgs e)
        {
            FormSolicitarCotizacion formSolicitarCotizacion = new FormSolicitarCotizacion();
            formSolicitarCotizacion.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FormBuscarProducto formBuscarProducto = new FormBuscarProducto();
            formBuscarProducto.Show();
        }
    }
}
