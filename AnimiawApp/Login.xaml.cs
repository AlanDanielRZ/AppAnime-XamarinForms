using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AnimiawApp.Modelos;

namespace AnimiawApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        ServicioWeb obj = new ServicioWeb();
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void btnEntrar_Clicked(System.Object sender, System.EventArgs e)
        {
            Usuarios usu = new Usuarios
            {
                Email = txtCorreo.Text,
                Contrasena = txtContrasena.Text,
                perfil = ""
            };
            Uri RutaUri = new Uri(obj.dominio+"autentica.php");
            var cliente = new HttpClient();
            var json = JsonConvert.SerializeObject(usu);
            var contenidoJson = new StringContent(json, Encoding.UTF8, "application/json");
            var respuesta = await cliente.PostAsync(RutaUri, contenidoJson);

                if (respuesta.StatusCode == HttpStatusCode.OK)
                {
                    var contenido = await respuesta.Content.ReadAsStringAsync();
                    //txtRespuesta.Text = contenido;
                    Usuarios tmp = JsonConvert.DeserializeObject<Usuarios>(contenido);
                    if (tmp.Respuesta == "OK")
                    {
                        Application.Current.Properties["Email"] = txtCorreo.Text;
                        Application.Current.Properties["Contrasena"] = txtContrasena.Text;
                        Application.Current.Properties["perfil"] = tmp.perfil;
                        await Application.Current.SavePropertiesAsync();
                        Navigation.InsertPageBefore(new MainPage(), this);
                        await Navigation.PopAsync();
                    }
                    if(tmp.Respuesta == "OK")
                    {
                    await Navigation.PushAsync(new MainPage());
                    }
                    else
                        await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
                }
                else
                    await DisplayAlert("Error", "No hay conexión", "OK");
        }
    }
}