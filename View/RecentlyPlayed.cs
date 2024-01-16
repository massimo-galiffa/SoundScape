using System.Collections.ObjectModel;

namespace SoundScape.View
{
    public class Song
    {
        public string Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Image { get; set; } 
    }

    public class RecentlyPlayed
    {
        public ObservableCollection<Song> Songs { get; set; }

        public RecentlyPlayed()
        {
            Songs = new ObservableCollection<Song>();
            Songs.Add(new Song { Id = "1", Image = "astroworld.jpg", Title = "STARGAZING", Artist = "Travis Scott", Duration = "3:21" });
            Songs.Add(new Song { Id = "2", Image = "jackboys.jpg", Title = "Gatti", Artist = "Travis Scott", Duration = "2:45" });
            Songs.Add(new Song { Id = "3", Image = "utopia.png", Title = "FE!N", Artist = "Travis Scott", Duration = "4:00" });
            Songs.Add(new Song { Id = "4", Image = "rodeo.png", Title = "Nightcrawler", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Id = "5", Image = "astroworld.jpg", Title = "ASTROWORLD", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Id = "6", Image = "jackboys.jpg", Title = "Jackboys", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Id = "7", Image = "utopia.png", Title = "UTOPIA", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Id = "8", Image = "rodeo.png", Title = "RODEO", Artist = "Travis Scott", Duration = "4:04" });
        }
    }
    public class Playlist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ObservableCollection<Song> Songs { get; set; }

        public Playlist()
        {
            Songs = new ObservableCollection<Song>();
        }
    }
    public class PlaylistManager
    {
        public ObservableCollection<Playlist> Playlists { get; set; }

        public PlaylistManager()
        {
            Playlists = new ObservableCollection<Playlist>();
            
            InitializeSamplePlaylists();
        }

        private void InitializeSamplePlaylists()
        {
            
            Playlists.Add(new Playlist { Id = "1", Name = "Morning Playlist", Image = "morningjpg.jpg" });
            Playlists.Add(new Playlist { Id = "2", Name = "Rap Playlist", Image = "crowd.jpg" });
            Playlists.Add(new Playlist { Id = "3", Name = "Yeat Playlist", Image = "yeat.png" });
            Playlists.Add(new Playlist { Id = "4", Name = "Study Playlist", Image = "study.jpg" });
            
        }

       
    }
}