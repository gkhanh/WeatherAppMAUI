namespace WeatherAppMAUI.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
        InitializeComponent();
	}

	private void BtnGetStarted_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new MainPage());
	}
}