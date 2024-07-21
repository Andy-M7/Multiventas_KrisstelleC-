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
    public partial class Inventario : Form
    {
        private Panel panelSuperior;
        public Inventario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSalirInventario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario a agregar
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto();
            formAgregarProducto.Show();
        }
    }
}