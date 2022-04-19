using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Com.OneSignal;
using Com.OneSignal.Abstractions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AnimiawApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_sesion_Clicked(object sender, EventArgs e)
        {
            var resp = await DisplayAlert("Salir", "¿Deseas cerrar la sesión?", "Sí", "No");
            if(resp == true)
            {
                Application.Current.Properties.Clear();
                Navigation.InsertPageBefore(new Login(), this);
                await Navigation.PopAsync();
            }
        }
    }
}
