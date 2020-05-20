using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameStart : ContentPage
    {
        public GameStart(string usuario)
        {
           
            InitializeComponent();
            usertest.Text = usuario;
        }

        private void iniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Quiz(usertest.Text.ToString()));
        }
    }
}