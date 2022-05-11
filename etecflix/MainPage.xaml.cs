using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using etecflix.Categorias;

namespace etecflix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("etecflix.Img.logo.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro :(", ex.Message, "OK");
            }
        }

        private async void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Comedia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro :(", ex.Message, "OK");
            }
        }

        private async void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Drama());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro :(", ex.Message, "OK");
            }
        }

    }
}
