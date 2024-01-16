namespace SoundScape.View;

public partial class HomePage : ContentPage
{
    private PlaylistManager _playlistManager;

    public HomePage()
    {
        InitializeComponent();
        _playlistManager = new PlaylistManager();
        this.BindingContext = _playlistManager;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        recentlyPlayedList.ItemsSource = new RecentlyPlayed().Songs;
    }
    
}