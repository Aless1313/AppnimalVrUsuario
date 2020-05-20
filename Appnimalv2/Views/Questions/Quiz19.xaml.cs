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
    public partial class Quiz19 : ContentPage
    {
        public int a;
        public int b;
        public Quiz19(string user, int zoo, int bien)
        {

            InitializeComponent();
            usertest.Text = user;
            pregunta();
            a = zoo;
            b = bien;
        }

        public void pregunta()
        {
            npregunta.Text = "Pregunta 20";
            preguntatext.Text = "¿De que color es la piel del oso polar?";
            opc1.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Polar_Bear_-_Alaska.jpg/250px-Polar_Bear_-_Alaska.jpg";
          
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

        private void res2_Clicked(object sender, EventArgs e)
        {
            a = a + 2;
            b = b + 1;

            DisplayAlert("Correcto", "Tienes " + a + " zoocoins", "Aceptar");
            Navigation.PushAsync(new Final(usertest.Text.ToString(), a, b));
        }

        private void res1_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Inorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Final(usertest.Text.ToString(), a, b));
        }
    }
}