using Appnimalv2.Clases;
using Appnimalv2.Views.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : ContentPage
    {
        public int zoocoins = 0;
        public int bien = 0;
        public Quiz(string user)
        {
            
            InitializeComponent();
            usertest.Text = user;
            pregunta();
        }
        

        public void pregunta()
        {
            npregunta.Text = "Pregunta 1";
            preguntatext.Text = "¿Que animal de estos puede romper el acero de una mordida?";
            opc1.Source = "https://www.ezsa.es/wp-content/uploads/2018/11/muizen-bestrijden-8-630x300.jpg";
            opc2.Source = "https://utopico.co/wp-content/uploads/2019/03/pitbull-blue-monster-768x782.jpg";
        }

    
        private void opc1_Clicked(object sender, EventArgs e)
        {

            bien = bien + 1;
            zoocoins = zoocoins + 2;
            DisplayAlert("Correcto", "Tienes " + zoocoins + " zoocoins", "Aceptar");
            Navigation.PushAsync(new Quiz1(usertest.Text.ToString(), zoocoins, bien));
        }

        private void opc2_Clicked(object sender, EventArgs e)
        {
            bien = bien+0;
            zoocoins = zoocoins + 0;
            DisplayAlert("Incorrecto", "Suerte para la proxima", "Aceptar");
            Navigation.PushAsync(new Quiz1(usertest.Text.ToString(), zoocoins, bien));
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