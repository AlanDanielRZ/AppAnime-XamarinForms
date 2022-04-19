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
    public partial class Acerca : ContentPage
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Contacto());
        }
    }
}