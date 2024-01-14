using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SoundScape.View;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
        BindingContext = new SettingsViewModel();
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

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}