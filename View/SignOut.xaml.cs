namespace SoundScape.View;

public partial class SignOut : ContentPage
{
	public SignOut()
	{
		InitializeComponent();
	}
    private async void OnGoToHomeClicked(object sender, EventArgs e)
    {
        // Navigate to the home page
        await Shell.Current.GoToAsync("//HomePage");
    }
    private async void OnGoToRegisterClicked(object sender, EventArgs e)
    {
        // Navigate to the Register page
        await Shell.Current.GoToAsync("register");
    }
}