namespace SoundScape.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        recentlyPlayedList.ItemsSource = new RecentlyPlayed().Songs;
    }
}