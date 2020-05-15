using Appnimalv2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appnimalv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            botones.VerticalOptions = LayoutOptions.EndAndExpand;

        }

        private void btn_registar_Clicked(object sender, EventArgs e)
        {
            verificar2();
        }

        private void sesioniniciada_Clicked(object sender, EventArgs e)
        {
            registrarse.IsVisible = false;
            verificar();
        }

        private void mostrariniciar_Clicked(object sender, EventArgs e)
        {
            if (Iniciarsesion.IsVisible == true)
            {
                mostrarregistrar.IsEnabled = true;
                botones.VerticalOptions = LayoutOptions.EndAndExpand;
                Iniciarsesion.IsVisible = false;
            }
            else
            {
                registrarse.IsVisible = false;
                mostrariniciar.IsVisible = false;
                mostrarregistrar.IsVisible = true;
                botones.VerticalOptions = LayoutOptions.EndAndExpand;
                Iniciarsesion.IsVisible = true;
                
            }
        }

        private void mostrarregistrar_Clicked(object sender, EventArgs e)
        {
            if (registrarse.IsVisible == true)
            {
               
                mostrariniciar.IsEnabled = true;
                botones.VerticalOptions = LayoutOptions.EndAndExpand;
                registrarse.IsVisible = false;
            }
            else
            {
                mostrariniciar.IsVisible = true;
                mostrarregistrar.IsVisible = false;
                Iniciarsesion.IsVisible = false;
                mostrariniciar.IsEnabled = true;
                botones.VerticalOptions = LayoutOptions.EndAndExpand;
                registrarse.IsVisible = true;
            }
        }

        //Iniciar sesion
        public async void iniciar()
        {
            //string mtr = "alessandro.uanl@gmail.com";
            string a = Convert.ToString(user.Text);
            try
            {
                UserManager manager = new UserManager();
                var result = await manager.userlogin(user.Text.ToString(), pass.Text.ToString());
                
                if (result.Count() > 0)
                {
                    //Inicio de sesión
                    await Navigation.PushAsync(new MainPage(a));
                }
                else
                {
                    await DisplayAlert("Error", "Usuario o contraseña incorrecto", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }



        public async void registrar()
        {
            try
            {
                UserManager manager = new UserManager();
                manager.registrarusuario(lblnombre.Text.ToString(), lblapellido.Text.ToString(), entry_correo.Text.ToString(),lblcontraseña.Text.ToString());

                await DisplayAlert("Registro", "Cuenta creada con exito", "Aceptar");
                lblapellido.Text = "";
                lblnombre.Text = "";
                lblcontraseña.Text = "";
                entry_correo.Text = "";
                registrarse.IsVisible = false;
                mostrariniciar.IsEnabled = true;
            }
            catch(Exception ee)
            {
                await DisplayAlert("Error", ee.Message, "Aceptar");
            }
        }


        public async void verificar()
        {
            if(String.IsNullOrWhiteSpace(user.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo correo es obligatorio", "OK");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(pass.Text))
                {
                    await this.DisplayAlert("Advertencia", "El campo contraseña es obligatorio", "OK");
                }
                else
                {
                    iniciar();
                }
               
                
            }
        }

        public async void verificar2()
        {
                if (String.IsNullOrWhiteSpace(entry_correo.Text))
                {
                    await this.DisplayAlert("Advertencia", "Campo correo obligario", "Aceptar");
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(lblcontraseña.Text))
                    {
                        await this.DisplayAlert("Advertencia", "Campo contraseña obligario", "Aceptar");
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(lblapellido.Text))
                        {
                            await this.DisplayAlert("Advertencia", "Campo apellido obligario", "Aceptar");
                        }
                        else
                        {
                            if (String.IsNullOrWhiteSpace(lblnombre.Text))
                            {
                                await this.DisplayAlert("Advertencia", "Campo nombre obligario", "Aceptar");
                            }
                            else
                            {
                                if (String.IsNullOrWhiteSpace(entry_correo.Text))
                                {
                                    await this.DisplayAlert("Advertencia", "Campo correo obligario", "Aceptar");
                                }
                                else
                                {
                                    registrar();
                                }
                                
                            }
                        }                     
                    }
                }
        }

    }
}