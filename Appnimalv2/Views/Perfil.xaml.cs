using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Appnimalv2.Clases;

namespace Appnimalv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
        public Perfil(string v)
        {
            InitializeComponent();
            string g = Convert.ToString(v);
            userrr.Text = g;
            informacion();
        }

        public async void informacion()
        {
           

            try
            {
                UserManager manager = new UserManager();
                var result = await manager.consulta(userrr.Text.ToString());

                if (result.Count() > 0)
                {
                    infoo.ItemsSource = result;
                }
                else
                {
                    await DisplayAlert("Error", "No hay información del usuario", "Aceptar");
                }
            }
            catch(Exception ei)
            {
                await DisplayAlert("Error", ei.Message, "Aceptar");
            }
        }

        private void cerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}