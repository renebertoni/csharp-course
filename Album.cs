class Album
{
    private List<Song> songs = new ();
    public string Name { get; set; }
    public int Duration => songs.Sum(m => m.Duration );

    public Album(string name)
    {
        Name = name;
    }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public void ShowAllSongs()
    {
        foreach (var song in songs)
        {
            Console.WriteLine($"Musica: {song.Name}");
        }
    }
}