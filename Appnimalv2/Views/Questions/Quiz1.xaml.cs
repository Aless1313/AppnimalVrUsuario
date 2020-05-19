using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2.Views.Questions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz1 : ContentPage
    {
        public int a;
        public Quiz1(int z)
        {
            InitializeComponent();
            pregunta();
            a = z;
        }

        private void opc2_Clicked(object sender, EventArgs e)
        {
            a = a + 2;
            DisplayAlert("Correcto", "Tienes " + a + " zoocoins", "Aceptar");
            Navigation.PushAsync(new Quiz2());
        }

        private void opc1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Inorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz2());
        }
        public void pregunta()
        {
            npregunta.Text = "Pregunta 2";
            preguntatext.Text = "¿Cual de estas aves es más inteligente?";
            opc1.Source = "https://www.caracteristicas.co/wp-content/uploads/2017/02/pato-2-e1560917879703.jpg";
            opc2.Source = "https://imagenes.20minutos.es/files/image_656_370/uploads/imagenes/2014/12/06/200968.jpg";
        }
    }
}