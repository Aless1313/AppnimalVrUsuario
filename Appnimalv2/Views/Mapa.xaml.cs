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
    public partial class Mapa : ContentPage
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void anim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = anim as Picker;
            string animal = anim.SelectedItem.ToString();
            ajio.Text = animal.ToString();
            mapa(ajio.Text.ToString());
        }

        public void mapa(string e)
        {
            switch (e.ToString())
            {
                case "Aves del amazonas":
                    animal.Source = "Avesdelamazonas.jpg";
                    break;
                case "Bisontes americanos":
                    animal.Source = "Bisontesamericanos.jpg";
                    break;
                case "Buffalos acuáticos":
                    animal.Source = "Buffalosacuaticos.jpg";
                    break;
                case "Cabras":
                    animal.Source = "Cabras.jpg";
                    break;
                case "Caimanes":
                    animal.Source = "Caimanes.jpg";
                    break;
                case "Cerdo vietnamita":
                    animal.Source = "Cerdovietnamita.jpg";
                    break;
                case "Conejos":
                    animal.Source = "Conejos.jpg";
                    break;
                case "Guacamayas y coquenas":
                    animal.Source = "Guacamayaycoquenas.jpg";
                    break;
                case "Jaguares":
                    animal.Source = "Jaguares.jpg";
                    break;
                case "Jaula de vuelo":
                    animal.Source = "Jauladevuelo.jpg";
                    break;
            }
        }

        


    }
}