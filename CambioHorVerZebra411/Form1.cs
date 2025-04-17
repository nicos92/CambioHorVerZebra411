using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CambioHorVerZebra411
{
    public partial class FormMain : Form
    {

        private string stringToPrint;
        private readonly Regex RegexDezpHor = new Regex(@"^-?(0|\d{0,3})$", RegexOptions.Compiled);
        private readonly Regex RegexDezpVer = new Regex(@"^-?(120|1[01][0-9]|[0-9]{1,2})$", RegexOptions.Compiled);
        private readonly Regex RegexCont = new Regex(@"^(30|[0-2]?[0-9])$", RegexOptions.Compiled);

        private readonly Regex RegexVeloc = new Regex(@"^[2-6]$", RegexOptions.Compiled);



        public FormMain()
        {
            InitializeComponent();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            CargaValores();

        }

        private void CargaValores()
        {
            
            TxtContraste.Text = Nicos92ZebraZT.Properties.Settings.Default.Contraste;
            TxtVelocidad.Text = Nicos92ZebraZT.Properties.Settings.Default.Velocidad;
            TxtHorizontal.Text = Nicos92ZebraZT.Properties.Settings.Default.Horizontal;
            TxtVertical.Text = Nicos92ZebraZT.Properties.Settings.Default.Vertical;
        }

        private void SaveSetting()
        {
            Nicos92ZebraZT.Properties.Settings.Default.Contraste = TxtContraste.Text;
            Nicos92ZebraZT.Properties.Settings.Default.Velocidad = TxtVelocidad.Text;
            Nicos92ZebraZT.Properties.Settings.Default.Horizontal = TxtHorizontal.Text;
            Nicos92ZebraZT.Properties.Settings.Default.Vertical = TxtHorizontal.Text;
            Nicos92ZebraZT.Properties.Settings.Default.Save();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            // Asigna el PrintDocument al PrintDialog
            PrintDialog.Document = printDocument1;

            // Asigna el texto a imprimir
            //stringToPrint = "Este es un ejemplo de texto plano para imprimir.";

            stringToPrint = "^XA~SD" + TxtContraste.Text + "^XZ";
            stringToPrint += "^XA^LS" + TxtHorizontal.Text + "^XZ";
            stringToPrint += "^XA^LT" + TxtVertical.Text + "^XZ";
            stringToPrint += "^XA^PR" + TxtVelocidad.Text + "^XZ";
            stringToPrint += "^XA^JUS^XZ";


            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {
                // Imprime el documento
                printDocument1.Print();

                // Guarda los valores enviados
                SaveSetting();
            }
        }

       

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            // Define la fuente y el formato del texto
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Define el área de impresión
            RectangleF bounds = new RectangleF(0, 0, e.PageBounds.Width - 200, e.PageBounds.Height - 200);

            // Dibuja el texto en la página
            e.Graphics.DrawString(stringToPrint, font, brush, bounds);
        }


        #region mouses_down_up_

        private void BtnSubirContraste_MouseDown(object sender, MouseEventArgs e)
        {
            TimerContraste.Start();
        }

        private void BtnSubirContraste_MouseUp(object sender, MouseEventArgs e)
        {
            TimerContraste.Stop();
        }

        private void BtnBajarContraste_MouseDown(object sender, MouseEventArgs e)
        {
            TimerContraste.Start();
        }

        private void BtnBajarContraste_MouseUp(object sender, MouseEventArgs e)
        {
            TimerContraste.Stop();
        }

        private void BtnBajarVel_MouseDown(object sender, MouseEventArgs e)
        {
            TimerVelocidad.Start();
        }

        private void BtnBajarVel_MouseUp(object sender, MouseEventArgs e)
        {
            TimerVelocidad.Stop();
        }

        private void BtnSubirVel_MouseDown(object sender, MouseEventArgs e)
        {
            TimerVelocidad.Start();
        }

        private void BtnSubirVel_MouseUp(object sender, MouseEventArgs e)
        {
            TimerVelocidad.Stop();
        }



        private void BtnBajarHor_MouseUp(object sender, MouseEventArgs e)
        {
            TimerHorizontal.Stop();
        }

        private void BtnSubirHor_MouseDown(object sender, MouseEventArgs e)
        {
            TimerHorizontal.Start();
        }

        private void BtnSubirHor_MouseUp(object sender, MouseEventArgs e)
        {
            TimerHorizontal.Stop();
        }

        private void BtnBajarHor_MouseDown(object sender, MouseEventArgs e)
        {
            TimerHorizontal.Start();
        }

        private void BtnSubirVer_MouseDown(object sender, MouseEventArgs e)
        {
            TimerVertical.Start();
        }

        private void BtnSubirVer_MouseUp(object sender, MouseEventArgs e)
        {
            TimerVertical.Stop();
        }

        private void BtnBajarVer_MouseDown(object sender, MouseEventArgs e)
        {
            TimerVertical.Start();
        }

        private void BtnBajarVer_MouseUp(object sender, MouseEventArgs e)
        {
            TimerVertical.Stop();
        }

        

        #endregion

        #region timers
        private void TimerContraste_Tick(object sender, EventArgs e)
        {
            int valor = TxtContraste.Text == "" ? 0 : Convert.ToInt32(TxtContraste.Text);
            if (BtnBajarContraste.Focused && valor > 0)
            {
                valor--;

            }
            if (BtnSubirContraste.Focused && valor < 30)
            {
                valor++;
            }



            TxtContraste.Text = valor.ToString();
        }

        private void TimerVelocidad_Tick(object sender, EventArgs e)
        {
            int valor = TxtVelocidad.Text == "" ? 0 : Convert.ToInt32(TxtVelocidad.Text);
            if (BtnBajarVel.Focused && valor > 0)
            {
                valor--;

            }
            if (BtnSubirVel.Focused && valor < 6)
            {
                valor++;
            }



            TxtVelocidad.Text = valor.ToString();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            int valor = TxtHorizontal.Text == "" ? 0 : Convert.ToInt32(TxtHorizontal.Text);
            if (BtnBajarHor.Focused && valor > -999)
            {
                valor--;
            }
            if (BtnSubirHor.Focused && valor < 999)
            {
                valor++;
            }



            TxtHorizontal.Text = valor.ToString();
        }

        private void TimerVertical_Tick(object sender, EventArgs e)
        {
            int valor = TxtVertical.Text == "" ? 0 : Convert.ToInt32(TxtVertical.Text);
            if (BtnBajarVer.Focused && valor > -120)
            {
                valor--;

            }
            if (BtnSubirVer.Focused && valor < 120)
            {
                valor++;
            }



            TxtVertical.Text = valor.ToString();
        }

        #endregion

 

        #region keys_press
        private void TxtContraste_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtiene el texto actual del TextBox
            string currentText = TxtContraste.Text;

            // Simula la entrada del nuevo carácter
            string newText = currentText.Substring(0, TxtContraste.SelectionStart) + e.KeyChar + currentText.Substring(TxtContraste.SelectionStart + TxtContraste.SelectionLength);

            if (!RegexCont.IsMatch(newText))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
        }

        private void TxtVelocidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtiene el texto actual del TextBox
            string currentText = TxtVelocidad.Text;

            // Simula la entrada del nuevo carácter
            string newText = currentText.Substring(0, TxtVelocidad.SelectionStart) + e.KeyChar + currentText.Substring(TxtVelocidad.SelectionStart + TxtVelocidad.SelectionLength);

            if (!RegexVeloc.IsMatch(newText))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
        }

        private void TxtHorizontal_KeyPress(object sender, KeyPressEventArgs e)
        {


            // Obtiene el texto actual del TextBox
            string currentText = TxtHorizontal.Text;

            // Simula la entrada del nuevo carácter
            string newText = currentText.Substring(0, TxtHorizontal.SelectionStart) + e.KeyChar + currentText.Substring(TxtHorizontal.SelectionStart + TxtHorizontal.SelectionLength);




            if (!RegexDezpHor.IsMatch(newText))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }




        }


        private void TxtVertical_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtiene el texto actual del TextBox
            string currentText = TxtVertical.Text;

            // Simula la entrada del nuevo carácter
            string newText = currentText.Substring(0, TxtVertical.SelectionStart) + e.KeyChar + currentText.Substring(TxtVertical.SelectionStart + TxtVertical.SelectionLength);

            if (!RegexDezpVer.IsMatch(newText))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }

        }
        #endregion

        #region texts_changed
        private void TxtVelocidad__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtContraste__TextChanged(object sender, EventArgs e)
        {
            if (TxtContraste.Text == "")
            {
                TxtContraste.Text = "0";
            }
        }
        private void TxtHorizontal__TextChanged(object sender, EventArgs e)
        {
            if (TxtHorizontal.Text == "")
            {
                TxtHorizontal.Text = "0";
            }
        }

        private void TxtVertical__TextChanged(object sender, EventArgs e)
        {
            if (TxtVertical.Text == "")
            {
                TxtVertical.Text = "0";
            }
        }











        #endregion

        #region clicks
        private void BtnBajarContraste_Click(object sender, EventArgs e)
        {
            int valor = TxtContraste.Text == "" ? 0 : Convert.ToInt32(TxtContraste.Text);
            if (BtnBajarContraste.Focused && valor > 0)
            {
                valor--;

            }
            



            TxtContraste.Text = valor.ToString();
        }
        private void BtnSubirContraste_Click(object sender, EventArgs e)
        {
            int valor = TxtContraste.Text == "" ? 0 : Convert.ToInt32(TxtContraste.Text);
           
            if (BtnSubirContraste.Focused && valor < 30)
            {
                valor++;
            }



            TxtContraste.Text = valor.ToString();
        }
        

        private void BtnBajarVel_Click(object sender, EventArgs e)
        {
            int valor = TxtVelocidad.Text == "" ? 0 : Convert.ToInt32(TxtVelocidad.Text);
            if (BtnBajarVel.Focused && valor > 0)
            {
                valor--;

            }
            



            TxtVelocidad.Text = valor.ToString();
        }

        private void BtnSubirVel_Click(object sender, EventArgs e)
        {
            int valor = TxtVelocidad.Text == "" ? 0 : Convert.ToInt32(TxtVelocidad.Text);
            
            if (BtnSubirVel.Focused && valor < 6)
            {
                valor++;
            }



            TxtVelocidad.Text = valor.ToString();
        }

        private void BtnBajarHor_Click(object sender, EventArgs e)
        {
            int valor = TxtHorizontal.Text == "" ? 0 : Convert.ToInt32(TxtHorizontal.Text);

            if (BtnSubirHor.Focused && valor > -999)
            {
                valor--;
            }



            TxtHorizontal.Text = valor.ToString();
        }
        private void BtnSubirHor_Click(object sender, EventArgs e)
        {
            int valor = TxtHorizontal.Text == "" ? 0 : Convert.ToInt32(TxtHorizontal.Text);

            if (BtnSubirHor.Focused && valor < 999)
            {
                valor++;
            }



            TxtHorizontal.Text = valor.ToString();
        }

        private void BtnBajarVer_Click(object sender, EventArgs e)
        {
            int valor = TxtVertical.Text == "" ? 0 : Convert.ToInt32(TxtVertical.Text);
            if (BtnBajarVer.Focused && valor > -120)
            {
                valor--;

            }
            



            TxtVertical.Text = valor.ToString();
        }

        private void BtnSubirVer_Click(object sender, EventArgs e)
        {
            int valor = TxtVertical.Text == "" ? 0 : Convert.ToInt32(TxtVertical.Text);
            
            if (BtnSubirVer.Focused && valor < 120)
            {
                valor++;
            }



            TxtVertical.Text = valor.ToString();
        }
        #endregion

        private void TxtVelocidad_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtVelocidad_Enter(object sender, EventArgs e)
        {
            
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
