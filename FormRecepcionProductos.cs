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
        string codigo = "";
        string cantidad = "";
        string fecha = "";
        string observaciones = "";
        public FormRecepcionProductos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            // VARIABLES PARA BASE DE DATOS
            
        }

        private void btnSalirInventario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            codigo = txtCodIngreso.Text;
            cantidad = numUp.Value.ToString();
            fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            observaciones = txtObservation.Text;

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
            g.DrawString(fecha, new Font("Arial", 10), Brushes.Black, leftMargin, yPos);
            yPos += 300;

            // Datos del reporte (ejemplo)
            g.DrawString("Producto 1:"+ codigo, new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
            yPos += 30;
            
            g.DrawString("Cantidad: " + cantidad, new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
            yPos += 30;

            g.DrawString(" Detalle del producto :" + observaciones, new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
            yPos += 30;

            // Puedes añadir más productos aquí...
        }
    }
}
