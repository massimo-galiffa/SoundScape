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
}
