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
    public partial class Quiz9 : ContentPage
    {
        public int a;
        public int b;
        public Quiz9(string user, int zoo, int bien)
        {

            InitializeComponent();
            usertest.Text = user;
            pregunta();
            a = zoo;
            b = bien;
        }
        public void pregunta()
        {
            npregunta.Text = "Pregunta 10";
            preguntatext.Text = "¿Porque las nutrias se agarran de las manos al dormir?";
            opc1.Source = "https://res.cloudinary.com/postedin/image/upload/d_mascotas:no-image.jpg,w_700,c_thumb,f_auto,q_80/mascotas/c-postedin-image-53016.jpeg";
           
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

        private void res1_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Incorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz10(usertest.Text.ToString(), a, b));
        }

        private void res2_Clicked(object sender, EventArgs e)
        {
            a = a + 2;
            b = b + 1;

            DisplayAlert("Correcto", "Tienes " + a + " zoocoins", "Aceptar");
            Navigation.PushAsync(new Quiz10(usertest.Text.ToString(), a, b));
        }
    }
}