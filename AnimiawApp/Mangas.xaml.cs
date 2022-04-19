using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimiawApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mangas : ContentPage
    {
        ServicioWeb conexion = new ServicioWeb();
        public Mangas()
        {
            InitializeComponent();
            proxyListo();
        }
        void proxyListo()
        {
            webView.IsVisible = false;
            webView.Source = conexion.dominio + "consultaMangas.php";
        }
         void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        async void webView_Navigating(System.Object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            Indicador.IsRunning = true;
            Indicador.IsEnabled = true;

            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            try
            {
                var response = await httpClient.GetAsync(conexion.dominio + "consultaMangas.php");
                if (!response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Sin servicio", "Intente más tarde por favor...", "Ok");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                    webView.IsVisible = true;
            }
            catch (Exception)
            {
                await DisplayAlert("Sin servicio", "Intente más tarde por favor...", "Ok");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            Indicador.IsVisible = false;
            vistaOpaca.IsVisible = false;
        }
    }
}