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
        public TicketPage(string ausu)
        {
           
            InitializeComponent();
            Text.Text = ausu;
            
        }

        private void EnseñarOcultar_Clicked(object sender, EventArgs e)
        {
            
           
        }

        private void generateqr_Clicked(object sender, EventArgs e)
        {
            string a = Text.Text;

            // TODO Implement error handling and 
            codigo.IsVisible = true;

            BarcodeImageView.BarcodeValue = a;

            BarcodeImageView.IsVisible = true;
        }

    }
    
}