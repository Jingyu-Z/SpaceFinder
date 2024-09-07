namespace BookingApp.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
        NavigateToLoginPage();
    }

    private async void NavigateToLoginPage()
    {
        await Task.Delay(2000);
        await Navigation.PushAsync(new LoginPage());
    }
}