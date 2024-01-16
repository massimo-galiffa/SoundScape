namespace SoundScape.View;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
    private async void OnGoToRegisterClicked(object sender, EventArgs e)
    {
        // Navigate to the Register page
        await Shell.Current.GoToAsync("//HomePage");
    }
}