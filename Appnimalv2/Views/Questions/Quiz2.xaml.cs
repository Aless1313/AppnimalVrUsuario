using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2.Views.Questions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz2 : ContentPage
    {
        public int a;
        public int b;
        public Quiz2(string user, int zoo, int bien)
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
            Navigation.PushAsync(new Quiz3xaml(usertest.Text.ToString(), a, b));
        }

        private void opc1_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Incorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz3xaml(usertest.Text.ToString(), a, b));
        }
        public void pregunta()
        {
            npregunta.Text = "Pregunta 3";
            preguntatext.Text = "¿Cual de estos animales frecuenta a hace grupos de amigas?";
            opc1.Source = "https://www.dw.com/image/36567443_303.jpg";
            opc2.Source = "https://www.quo.es/wp-content/uploads/2019/10/por-que-las-vacas-atacan-a-mas-gente-que-los-toros.jpg";
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