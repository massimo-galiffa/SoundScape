using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;

namespace SoundScape.View;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
        BindingContext = new SettingsViewModel();
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

public class SettingsViewModel : INotifyPropertyChanged
{
    private bool shuffleSongs;
    public bool ShuffleSongs
    {
        get => shuffleSongs;
        set
        {
            shuffleSongs = value;
            OnPropertyChanged();
        }
    }

    private double TransitionLevel;
    public double TransitionLevell
    {
        get => TransitionLevel;
        set
        {
            TransitionLevel = value;
            OnPropertyChanged();
        }
    }

    private int favoriteGenreIndex;
    public int FavoriteGenreIndex
    {
        get => favoriteGenreIndex;
        set
        {
            favoriteGenreIndex = value;
            OnPropertyChanged();
        }
    }

    private DateTime birthday;
    public DateTime Birthday
    {
        get => birthday;
        set
        {
            birthday = value;
            OnPropertyChanged();
        }
    }

    private ObservableCollection<string> genres;
    public ObservableCollection<string> Genres
    {
        get => genres;
        set
        {
            genres = value;
            OnPropertyChanged();
        }
    }

    public SettingsViewModel()
    {
        ShuffleSongs = false;
        TransitionLevel = 0.5;
        FavoriteGenreIndex = 0;
        Birthday = DateTime.Now;
        Genres = new ObservableCollection<string> { "Rock", "Pop", "Jazz", "Classical", "Hip Hop" };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    }
