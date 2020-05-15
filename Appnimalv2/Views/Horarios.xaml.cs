using Appnimalv2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horarios : ContentPage
    {
        public Horarios(string v)
        {
            InitializeComponent();
            string g = Convert.ToString(v);
            userrr.Text = g;
        }

        private void btn_agendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new agendar(userrr.Text.ToString()));
        }
    }
}