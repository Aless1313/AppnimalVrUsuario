using Appnimalv2.Clases;
using Appnimalv2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Appnimalv2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string b)
        {
           
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            string a = Convert.ToString(b);
            userr.Text = a;
        }

        private void btn_comprar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Compraboletos());
        }

        private void Btn_horario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Horarios(userr.Text.ToString()));
        }

        private void btn_descubre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Descubre1());
        }

        private void promo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Promociones());
        }

        private void usuario_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Perfil(userr.Text.ToString()));
        }

        private void mapa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mapa());
        }

        private void btn_quiz_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameStart());
        }
    }
}
