using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compraboletos : ContentPage
    {
        string[] opciones = { "Paypal", "Efectivo" };
        public int Total;

        public Compraboletos()
        {
            InitializeComponent();
        }

        private void MostrarPaypal_Clicked(object sender, EventArgs e)
        {
            Paypal.IsVisible = true;
            Efectivo.IsVisible = false;
            Tarjetadecredito.IsVisible = false;

        }

        private void MostrarEfectivo_Clicked(object sender, EventArgs e)
        {
            Paypal.IsVisible = false;
            Efectivo.IsVisible = true;
            Tarjetadecredito.IsVisible = false;
        }

        private void MostrarCredito_Clicked(object sender, EventArgs e)
        {
            Paypal.IsVisible = false;
            Efectivo.IsVisible = false;
            Tarjetadecredito.IsVisible = true;
        }

        async private void BotonCompra_Clicked(object sender, EventArgs e)
        {
            int TotalAdulto = Convert.ToUInt16(CantAdulto.Text) * 30;
            int TotalNiño = +Convert.ToUInt16(CantNiños.Text) * 15;
            Total = TotalNiño + TotalAdulto;
            TotalPaga.Text = Total.ToString();

            


            if (Paypal.IsVisible == true)
            {
                await DisplayAlert("", "¿Desea proceder con la compra?", "Aceptar", "Cancelar");
                await Browser.OpenAsync("https://paypal.com/", BrowserLaunchMode.SystemPreferred);
            }
            else
            {
                if (Efectivo.IsVisible == true)
                {
                    await DisplayAlert("", "¿Desea proceder con la compra?", "Aceptar", "Cancelar");
                    /*
                    MainViewModel.GetInstance().menus2 = new MenuViewModel();
                    await Application.Current.MainPage.Navigation.PushAsync(new TicketPage());
                    */
                    await Navigation.PushAsync(new TicketPage());
                }
                else
                {
                    if(Tarjetadecredito.IsVisible == true)
                    {
                        await DisplayAlert("", "¿Desea proceder con la compra?", "Aceptar", "Cancelar");
                    }
                    else
                    {
                        await DisplayAlert("Error", "Selecciona una forma de pago", "Aceptar");
                    }
                }
            }
        }         
    }
}