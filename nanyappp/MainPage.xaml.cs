using Microsoft.Maui.Controls;

namespace nanyappp

{ 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método para manejar clic en "Forgot Password?"
        private async void OnForgotPasswordClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Forgot Password", "This will navigate to password recovery.", "OK");
        }

        // Método para manejar clic en "Create an account"
        private async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Create Account", "This will navigate to account creation.", "OK");
        }
    }
}
