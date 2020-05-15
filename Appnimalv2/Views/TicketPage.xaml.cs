using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TicketPage : ContentPage
    {
        public TicketPage()
        {
           
            InitializeComponent();
            
        }

        private void EnseñarOcultar_Clicked(object sender, EventArgs e)
        {
            
           
        }

        private void generateqr_Clicked(object sender, EventArgs e)
        {

            // TODO Implement error handling and 
            codigo.IsVisible = true;

            BarcodeImageView.BarcodeValue = $"WIFI:S:{"aaa"};T:{"aaa"};P:{"aaa"};{"aaa"};Total:{"aaa"}; Adultos:{"aaa"}, Niños:{"aaa"}";

            BarcodeImageView.IsVisible = true;
        }

    }
    
}