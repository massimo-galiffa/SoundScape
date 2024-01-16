namespace SoundScape.View;

public partial class LibraryPage : ContentPage
{
    private PlaylistManager _playlistManager;
    public LibraryPage()
	{
        InitializeComponent();
        _playlistManager = new PlaylistManager();
        this.BindingContext = _playlistManager;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
       
    }

}