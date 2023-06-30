using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VoznesenskayaAE_02_02
{
    public partial class MainPage :ContentPage
    {
        public MainPage ()
        {
            InitializeComponent();
            Log.Text = Preferences.Get("login","" );
            Pass.Text = Preferences.Get("password","");
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
           if(Log.Text!="ects"|| Pass.Text != "ects2023")
            {
                await DisplayAlert("Внимание", "Не все поля заполнены", "ОК");
            } 
           else
            {
                Preferences.Set("login", $"{Log.Text}");
                Preferences.Set("password", $"{Pass.Text}");
            await Navigation.PushAsync(new SecondActivity());
            }
            
        }
    }
}
