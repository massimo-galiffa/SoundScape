namespace SoundScape.View;

public partial class SignOut : ContentPage
{
    public SignOut()
    {
        InitializeComponent();
    }

    private async void OnGoToHomeClicked(object sender, EventArgs e)
    {
        // validation before navigating
        if (IsValidEmail(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
        {
            ErrorMessageLabel.IsVisible = false;

            await Shell.Current.GoToAsync("//HomePage");
        }
        else
        {
 
            ErrorMessageLabel.IsVisible = true;
        }
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        bool isValidEmail = IsValidEmail(EmailEntry.Text);

        ErrorMessageLabel.IsVisible = !isValidEmail;
    }

    private bool IsValidEmail(string email)
    {
        return !string.IsNullOrEmpty(email) && email.Contains("@");
    }
}