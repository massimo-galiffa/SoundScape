using System.Collections.ObjectModel;

namespace SoundScape.View
{
    public class Song
    {
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
            Songs.Add(new Song { Image = "astroworld.jpg", Title = "STARGAZING", Artist = "Travis Scott", Duration = "3:21" });
            Songs.Add(new Song { Image = "jackboys.jpg", Title = "Gatti", Artist = "Travis Scott", Duration = "2:45" });
            Songs.Add(new Song { Image = "utopia.png", Title = "FE!N", Artist = "Travis Scott", Duration = "4:00" });
            Songs.Add(new Song { Image = "rodeo.png", Title = "Nightcrawler", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Image = "astroworld.jpg", Title = "ASTROWORLD", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Image = "jackboys.jpg", Title = "Jackboys", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Image = "utopia.png", Title = "UTOPIA", Artist = "Travis Scott", Duration = "4:04" });
            Songs.Add(new Song { Image = "rodeo.png", Title = "RODEO", Artist = "Travis Scott", Duration = "4:04" });
        }
    }
}