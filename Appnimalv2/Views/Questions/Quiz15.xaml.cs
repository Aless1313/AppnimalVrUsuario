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
    public partial class Quiz15 : ContentPage
    {
        public int a;
        public int b;
        public Quiz15(string user, int zoo, int bien)
        {

            InitializeComponent();
            usertest.Text = user;
            pregunta();
            a = zoo;
            b = bien;
        }

 
        public void pregunta()
        {
            npregunta.Text = "Pregunta 16";
            preguntatext.Text = "¿Cuanto duermen los koalas?";
            opc1.Source = "https://www.lavanguardia.com/r/GODO/LV/p6/WebSite/2019/05/18/Recortada/img_cvillalonga_20161123-110335_imagenes_lv_terceros_lento_3_4_5_593397035-kaPF-U462304599501GUH-992x558@LaVanguardia-Web.jpg";
           
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
            Navigation.PushAsync(new Quiz16(usertest.Text.ToString(), a, b));
        }

        private void res2_Clicked(object sender, EventArgs e)
        {
            b = b + 0;
            a = a + 0;
            DisplayAlert("Inorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz16(usertest.Text.ToString(), a, b));
        }
    }
}