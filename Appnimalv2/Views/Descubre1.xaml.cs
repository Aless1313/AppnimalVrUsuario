using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Appnimalv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Descubre1 : ContentPage
    {
        public Descubre1()
        {
            InitializeComponent();
        }

        
        private async void Scanner()
        {
            var scannerPage = new ZXingScannerPage();

            scannerPage.Title = "Lector de QR";
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = true;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new animalescaneado(result.Text));
                });
            };
            
            await Navigation.PushAsync(scannerPage);
        }

        private void BotonScaner_Clicked_1(object sender, EventArgs e)
        {
            Scanner();
        }

        
    }
}