using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimiawApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recomendaciones : ContentPage
    {
        public Recomendaciones()
        {
            InitializeComponent();
        }
        private async void pagEstrenos(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Estrenos());
        }
        private async void pagEmision(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Emision());
        }
        private async void pagAccion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Accion());
        }
        private async void pagMisterio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Misterio());
        }
        private async void pagComedia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Comedia());
        }
        private async void pagRomance(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Romance());
        }
        private async void pagEscolares(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Escolares());
        }
        private async void pagMusicales(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Musicales());
        }
        private async void pagMecha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mecha());
        }
        private void pagFondos(object sender, EventArgs e)
        {

        }
        private void pagAcerca(object sender, EventArgs e)
        {

        }
    }
}