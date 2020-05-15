using Appnimalv2.Clases;
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
    public partial class agendar : ContentPage
    {
        public agendar(string a)
        {
            InitializeComponent();
            string b = Convert.ToString(a);
            userr.Text = b;
            fecha.MinimumDate = DateTime.Today;
            
        }

        private void fecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            string dia = e.NewDate.ToString();
        }

        private void hora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            string a = hora.ToString();
        }

        public async void agendarx()
        {
            string diaa = fecha.Date.ToString();
            string horaa = hora.Time.ToString();
            string cant = cantidad.SelectedItem.ToString();

            try
            {
                UserManager manager = new UserManager();
                manager.Agendar(userr.Text.ToString(), diaa, horaa, cant);

                await DisplayAlert("Agenda", "Visita agendada con exito", "Aceptar");
            }
            catch (Exception r)
            {
                await DisplayAlert("Error", " :( " + r.Message, "Aceptar");
            }

        }

        private void agendarxd_Clicked(object sender, EventArgs e)
        {
            
            agendarx();
        }
    }
}