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
    public partial class Quiz5 : ContentPage
    {
        public int a;
        public int b;
        public Quiz5(string user, int zoo, int bien)
        {

            InitializeComponent();
            usertest.Text = user;
            pregunta();
            a = zoo;
            b = bien;
        }

        public void pregunta()
        {
            npregunta.Text = "Pregunta 6";
            preguntatext.Text = "¿Con que saborean las mariposas?";
            opc1.Source = "https://1.bp.blogspot.com/-64TysC98y6I/WhH1Zrao73I/AAAAAAAABRA/ovHA0ERP-KYuBdhFu0pJz-g2Ys_kp7TxgCLcBGAs/s400/informaci%25C3%25B3n-sobre-la-mariposa-2.jpg";

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
            a = a + 2;
            b = b + 1;

            DisplayAlert("Correcto", "Tienes " + a + " zoocoins", "Aceptar");
            Navigation.PushAsync(new Quiz6(usertest.Text.ToString(), a, b));
        }

        private void res2_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Incorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz6(usertest.Text.ToString(), a, b));
        }

    }
}