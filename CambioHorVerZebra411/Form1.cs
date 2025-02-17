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

namespace CambioHorVerZebra411
{
    public partial class FormMain : Form
    {


        private string stringToPrint;
        public FormMain()
        {
            InitializeComponent();
        }

        private void TrackBarHorizontal_Scroll(object sender, EventArgs e)
        {
            LblHorizontal.Text = TrackBarHorizontal.Value.ToString();
        }

        private void TrackBarVertical_Scroll(object sender, EventArgs e)
        {
            LblVertical.Text = TrackBarVertical.Value.ToString();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LblHorizontal.Text = Properties.Settings.Default.horizontal;
            LblVertical.Text = Properties.Settings.Default.vertical;

        }

        

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.horizontal = LblHorizontal.Text;
            Properties.Settings.Default.vertical = LblVertical.Text;
            Properties.Settings.Default.Save();
            // Asigna el PrintDocument al PrintDialog
            PrintDialog.Document = printDocument1;


            // Asigna el texto a imprimir
            //stringToPrint = "Este es un ejemplo de texto plano para imprimir.";

            stringToPrint = "^XA^LS" + LblHorizontal.Text + "^XZ^XA^LT" + LblVertical.Text + "^XZ^XA^JUS^XZ";
           

            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {
                // Imprime el documento
                printDocument1.Print();
            }
        }

      

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Dibuja el texto en la página
            //e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds);


            // Define la fuente y el formato del texto
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Define el área de impresión
            RectangleF bounds = new RectangleF(0, 0, e.PageBounds.Width - 200, e.PageBounds.Height - 200);

            // Dibuja el texto en la página
            e.Graphics.DrawString(stringToPrint, font, brush, bounds);
        }
    }
}
