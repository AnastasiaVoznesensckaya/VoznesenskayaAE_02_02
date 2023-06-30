using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoznesenskayaAE_02_02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdActivity :ContentPage
    {
        public ThirdActivity ()
        {
            InitializeComponent();
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}