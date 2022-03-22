using Refit;
using Refit_SampleApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Refit_SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            button_getf2p.Clicked += Button_getf2p_Clicked; ;
        }

        private async void Button_getf2p_Clicked(object sender, EventArgs e)
        {
            try
            {
                var apiClient = RestService.For<IFreeToPlayApi>(BaseFreeToPlayApi.BaseUrl);
                var listF2P = await apiClient.GetF2PAsync();
                StacklayoutListF2P.ItemsSource = listF2P;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Oups " + ex.Message);
            }
        }
    }
}
