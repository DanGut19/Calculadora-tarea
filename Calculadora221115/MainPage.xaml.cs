using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora221115
{
    public partial class MainPage : ContentPage
    {
        private double Numero1;
        private double Numero2;
        private string Operador;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void clicNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else {
                txtResultado.Text += tmp.Text;
            }
        }

        private void clicSuma(object sender, EventArgs e)
        {
            Operador = "+";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicResta(object sender, EventArgs e)
        {
            Operador = "-";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicMultilicacion(object sender, EventArgs e)
        {
            Operador = "*";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicDivicion(object sender, EventArgs e)
        {
            Operador = "/";
            Numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

            private void clicPorcentaje(object sender, EventArgs e)
            {
                Operador = "%";
                Numero1 = Double.Parse(txtResultado.Text);
                txtResultado.Text = "0";
            }
            /*
            private void clicPorcentaje(object sender, EventArgs e)
            {
                if ((txtResultado.Text == "-1") || (txtResultado.Text == "1"))
                {
                    var txtResultado = Numero1 / 100;
                    this.txtResultado.Text = txtResultado.ToString();
                    Numero1 = txtResultado;
                    txtResultado = -1;
                }
            }*/

            private void clicCE(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void clicERS(object sender, EventArgs e)
        {

            txtResultado.Text = "0";

        }

        private void clicIgual(object sender, EventArgs e)
        {

            Numero2 = Double.Parse(txtResultado.Text);

            double operacionFinal = 0;

            if (Operador == "+")
            {
                operacionFinal = Numero1 + Numero2;

            }
            else if (Operador == "-")
            {

                operacionFinal = Numero1 - Numero2;

            }

            else if (Operador == "*")

            {

                operacionFinal = Numero1 * Numero2;

            }

            else if (Operador == "/")

            {

                operacionFinal = Numero1 / Numero2;

            }

            else if (Operador == "%")

            {

                operacionFinal = (Numero1 * Numero2) / 100;

            }

            txtResultado.Text = operacionFinal.ToString();

        }
    }
}
