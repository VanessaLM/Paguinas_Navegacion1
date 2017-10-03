using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paguinas_Navegacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        double Variable1;
        double Variable2;
        double Resultado;
        string Operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Porcentaje_Clicked(object sender, EventArgs e)
        {
            Operacion = "%";
            Variable1 = double.Parse(contenedor.Text);
            contenedor.Text = "";
        }

        private void SQRT_Clicked(object sender, EventArgs e)
        {
            Operacion = "SQRT";
            Variable1 = double.Parse(contenedor.Text);
            Resultado = Variable1;
            contenedor.Text = Math.Sqrt(Variable1).ToString();

        }

        private void Cuadrado_Clicked(object sender, EventArgs e)
        {
            Operacion = "^2";
            Variable1 = double.Parse(contenedor.Text);
            Resultado = Variable1;
            contenedor.Text = Math.Pow(Variable1, 2).ToString();
        }

        private void Divicion_Clicked(object sender, EventArgs e)
        {
            Operacion = "/";
            Variable1 = double.Parse(contenedor.Text);
            contenedor.Text = "";
        }

        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            Operacion = "x";
            Variable1 = double.Parse(contenedor.Text);
            contenedor.Text = "";
        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = "";
        }

        private void Resta_Clicked(object sender, EventArgs e)
        {
            Operacion = "-";
            Variable1 = double.Parse(contenedor.Text);
            contenedor.Text = "";
        }


        private void Ce_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = "";

        }
        private void C_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Datos());
        }

        private void Siete_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "7";
        }

        private void Ocho_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "8";
        }

        private void Nueve_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "9";
        }

        private void Cuatro_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "4";
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "5";
        }

        private void Seis_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "6";
        }



        private void Uno_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "1";
        }

        private void Dos_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "2";
        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "3";
        }

        private void MasMenos_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "+/-";
        }

        private void Suma_Clicked(object sender, EventArgs e)
        {
            Operacion = "+";
            Variable1 = double.Parse(contenedor.Text);
            contenedor.Text = "";

        }

        private void Cero_Clicked(object sender, EventArgs e)
        {
            contenedor.Text = contenedor.Text + "0";
        }

        private void Punto_Clicked(object sender, EventArgs e)
        {
            if (contenedor.Text == "")
            {
                contenedor.Text = contenedor.Text + ".";
            }
            else
            {
                contenedor.Text = ".";
            }

        }

        private void Igual_Clicked(object sender, EventArgs e)
        {

            Variable2 = double.Parse(contenedor.Text);
            switch (Operacion)
            {
                case "+":
                    Resultado = Variable1 + Variable2;
                    contenedor.Text = Resultado.ToString();
                    break;
                case "-":
                    Resultado = Variable1 - Variable2;
                    contenedor.Text = Resultado.ToString();
                    break;
                case "x":
                    if (Variable2 == 0)
                    {
                        contenedor.Text = "NUMERO NO SE PUEDE MULTIPLICAR POR 0";
                    }
                    else
                    {

                        Resultado = Variable1 * Variable2;
                        contenedor.Text = Resultado.ToString();
                    }

                    break;
                case "/":
                    if (Variable2 == 0)
                    {
                        contenedor.Text = "NUMERO NO SE PUEDE DIVIDIR ENTRE 0";
                    }
                    else
                    {

                        Resultado = Variable1 / Variable2;
                        contenedor.Text = Resultado.ToString();
                    }

                    break;
                case "%":
                    Resultado = Variable1 * Variable2 / 100;
                    contenedor.Text = Resultado.ToString();
                    break;

            }
        }


    }
}