using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string userName = username.Text;
            string passWord = password.Text;
            loginbutton.Text = userName + passWord;
        }

        private async void skipButton_Clicked(object sender, EventArgs e)
        {
            activityIndicator.IsRunning = true;
            await Navigation.PushModalAsync(new MainIconTabbedPage());
            activityIndicator.IsRunning = false;
        }
        
    }
}