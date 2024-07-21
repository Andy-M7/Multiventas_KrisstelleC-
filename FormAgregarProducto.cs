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
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStockMinimo.Text = "Stock mínimo";
            txtStockMinimo.ForeColor = SystemColors.GrayText;
        }

        private void txtStockMinimo_Enter(object sender, EventArgs e)
        {
            if (txtStockMinimo.Text == "Stock mínimo")
            {
                txtStockMinimo.Text = "";
                txtStockMinimo.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtStockMinimo_Leave(object sender, EventArgs e)
        {
            if (txtStockMinimo.Text == "")
            {
                txtStockMinimo.Text = "Stock mínimo";
                txtStockMinimo.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
