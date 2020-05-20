using Appnimalv2.Clases;
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
    public partial class Final : ContentPage
    {
        public int a = 0;
        public Final(string user, int zoo, int bien)
        {
            InitializeComponent();
            usertest.Text = user;
            puntosa.Text = bien.ToString(); ;
            zooa.Text = zoo.ToString();
            a = zoo;
        }

        private void aceptar_Clicked(object sender, EventArgs e)
        {
            puntos();
            Navigation.PushAsync(new MainPage(usertest.Text.ToString()));
        }
        public async void puntos()
        {

            try
            {
                UserManager manager = new UserManager();
                manager.puntos(usertest.Text.ToString(), a);

                await DisplayAlert("Puntos", "Se han enviado "+ a + " Zoocoins a su cuenta", "Aceptar");


            }
            catch (Exception r)
            {
                await DisplayAlert("Error", " :( " + r.Message, "Aceptar");
            }

        }
    }
}