//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Appnimalv2.Views.TicketPage.xaml", "Views/TicketPage.xaml", typeof(global::Appnimalv2.TicketPage))]

namespace Appnimalv2 {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\TicketPage.xaml")]
    public partial class TicketPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ZXing.Net.Mobile.Forms.ZXingBarcodeImageView BarcodeImageView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label codigo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button generateqr;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(TicketPage));
            BarcodeImageView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ZXing.Net.Mobile.Forms.ZXingBarcodeImageView>(this, "BarcodeImageView");
            codigo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "codigo");
            generateqr = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "generateqr");
        }
    }
}