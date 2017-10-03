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
    public partial class Formulario : ContentPage
    {
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("DATOS INGRESADOS", Nombre.Text + " " + Apellidos.Text + "\n " + Direccion.Text + " \n " + Telefono.Text + " \n" + Carrera.Text + " \n" + Semestre.Text + "\n " + Matricula.Text + "\n " + Correo.Text + "\n " + Github.Text, "OK");
            Navigation.PushAsync(new Calculadora());
        }

        public Formulario()
        {
            InitializeComponent();
        }
    }
}