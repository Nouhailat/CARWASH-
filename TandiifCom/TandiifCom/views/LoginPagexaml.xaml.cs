using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TandiifCom.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPagexaml : ContentPage
    {
        public LoginPagexaml()
        {
            InitializeComponent();
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Normally you would perform authentication here (e.g., call a web service)
            string enteredUsername = usernameEntry.Text;
            string enteredPassword = passwordEntry.Text;

            // For demonstration, check if username and password match hardcoded values
            if (enteredUsername == "user" && enteredPassword == "password")
            {
                // Navigate to a new page (e.g., MainPage)
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                // Display an alert if login fails
                await DisplayAlert("Login Failed", "Invalid username or password", "OK");
            }
        }
    }
}
