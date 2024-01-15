using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace SoundScape.View;

    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            BindingContext = new SearchViewModel();
        }

    }

public class SearchViewModel : INotifyPropertyChanged
{
    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            OnPropertyChanged();
            // Optionally trigger search when text changes
            PerformSearch();
        }
    }

    public ObservableCollection<string> RecentSearches { get; }

    public ICommand PerformSearchCommand { get; }
    public ICommand ClearSearchCommand { get; }

    public SearchViewModel()
    {
        RecentSearches = RecentSearches = new ObservableCollection<string>();
        PerformSearchCommand = new Command(PerformSearch);
        ClearSearchCommand = new Command(ClearSearch);
    }

    private void PerformSearch()
    {
        // Implement your search logic here
        // For example, update RecentSearches based on SearchText
        if (!string.IsNullOrWhiteSpace(SearchText))
        {
            RecentSearches.Insert(0, SearchText); // Placeholder for actual search results

        }
    }

    private void ClearSearch()
    {
        SearchText = string.Empty;
        RecentSearches.Clear();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}



