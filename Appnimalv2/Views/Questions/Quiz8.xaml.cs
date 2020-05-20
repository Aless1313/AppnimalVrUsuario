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
    public partial class Quiz8 : ContentPage
    {
        public int a;
        public int b;
        public Quiz8(string user, int zoo, int bien)
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
            Navigation.PushAsync(new Quiz9(usertest.Text.ToString(), a, b));
        }

        private void opc1_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Incorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz9(usertest.Text.ToString(), a, b));
        }
        public void pregunta()
        {
            npregunta.Text = "Pregunta 9";
            preguntatext.Text = "¿Que animal no emite sonido a falta de cuerdas vocales?";
            opc1.Source = "https://fundacion-biodiversidad.es/sites/default/files/styles/noticias_prensa/public/noticias/tortuga_boba.jpg?itok=FaUPy9Q7";
            opc2.Source = "https://www.curiosasmentes.com/wp-content/uploads/2019/03/La-jirafa-el-animal-que-menos-duerme.jpg";
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