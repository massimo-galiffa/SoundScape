namespace SoundScape.View;

public partial class FaqPage : ContentPage
{
	public FaqPage()
	{
		InitializeComponent();
	}
    private void OnQuestionTapped(object sender, EventArgs e)
    {
        if (sender is Label questionLabel && questionLabel.Parent is StackLayout stackLayout)
        {
            // Assuming the answer label is the next sibling of the question label
            var answerIndex = stackLayout.Children.IndexOf(questionLabel) + 1;
            if (answerIndex < stackLayout.Children.Count)
            {
                var answerLabel = stackLayout.Children[answerIndex] as Label;
                if (answerLabel != null)
                {
                    // Toggle visibility
                    answerLabel.IsVisible = !answerLabel.IsVisible;
                }
            }
        }
    }
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
    private async void Button_Clicked_Subscribed(object sender, EventArgs e)
    {
        string email = emailEntry.Text;

        if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
        {
            // Email is potentially valid
            await DisplayAlert("Subscription", "You have been subscribed successfully!", "OK");
        }
        else
        {
            // Email is invalid
            await DisplayAlert("Error", "Please enter a valid email address.", "OK");
        }
    }
}
