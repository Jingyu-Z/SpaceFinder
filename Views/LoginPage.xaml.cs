using Microsoft.Maui.Controls;
using static BookingApp.Models.User;

namespace BookingApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var username = UsernameEntry.Text.Trim();
            var password = PasswordEntry.Text.Trim();
            
            var user = App.DatabaseService.GetUserByUsername(username);
            if (user != null && user.Password == PasswordEntry.Text) // Password check
            {
                CurrentUser.LoggedInUser = user;

            Application.Current.MainPage = new NavigationPage(new OpeningPage());

            }
            else
            {
                LoginStatusLabel.Text = "Invalid username or password.";
            }
        }

    private void OnSignUpButtonClicked(object sender, EventArgs e)
    {

    }
}