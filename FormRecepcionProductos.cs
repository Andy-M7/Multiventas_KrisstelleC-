using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiventas_Krisstelle
{
    public partial class FormRecepcionProductos : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        public FormRecepcionProductos()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void btnSalirInventario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            // Configura la impresora PDF (asegúrate de que tienes una impresora PDF instalada, como Microsoft Print to PDF)
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Aquí defines lo que se imprimirá en el PDF
            Graphics g = e.Graphics;
            int yPos = 100;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;

            // Título
            g.DrawString("Reporte de Recepción de Productos", new Font("Arial", 18), Brushes.Black, leftMargin, yPos);
            yPos += 50;

            // Datos del reporte (ejemplo)
            g.DrawString("Producto 1: Detalle del producto 1", new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
            yPos += 30;
            g.DrawString("Producto 2: Detalle del producto 2", new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
            yPos += 30;
            g.DrawString("Producto 3: Detalle del producto 3", new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
            yPos += 30;

            // Puedes añadir más productos aquí...
        }
    }
}
