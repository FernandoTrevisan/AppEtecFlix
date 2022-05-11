using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using etecflix.Filmes;

namespace etecflix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("etecflix.Img.logo.png");

            btnCapitaMarvel.Source = ImageSource.FromResource("etecflix.Posters.capitamarvel.png");
        }

        private async void Btn_Open_CapitaMarvel(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CapitaMarvel());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro :(", ex.Message, "OK");
            }
        }
    }
}