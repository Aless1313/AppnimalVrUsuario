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
        public int b;
        public Quiz1(string user, int zoo, int bien)
        {
            
            InitializeComponent();
            usertest.Text = user;
            pregunta();
            a = zoo;
            b = bien;
        }

        private void opc2_Clicked(object sender, EventArgs e)
        {
            a = a + 2;
            b = b + 1;

            DisplayAlert("Correcto", "Tienes " + a + " zoocoins", "Aceptar");
            Navigation.PushAsync(new Quiz2(usertest.Text.ToString(), a, b));
        }

        private void opc1_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Incorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz2(usertest.Text.ToString(), a, b));
        }
        public void pregunta()
        {
            npregunta.Text = "Pregunta 2";
            preguntatext.Text = "¿Cual de estas aves es más inteligente?";
            opc1.Source = "https://www.caracteristicas.co/wp-content/uploads/2017/02/pato-2-e1560917879703.jpg";
            opc2.Source = "https://imagenes.20minutos.es/files/image_656_370/uploads/imagenes/2014/12/06/200968.jpg";
        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();

            //new thread
            Device.BeginInvokeOnMainThread(async () => {

                var result = await this.DisplayAlert("Atención", "¿Desea salir?", "Si", "No");

                if (result)
                {
                    //other methods
                    await Navigation.PushAsync(new MainPage(usertest.Text.ToString()));
                }

            });

            return true; //Do not navigate backwards by pressing the button
        }


    }
}