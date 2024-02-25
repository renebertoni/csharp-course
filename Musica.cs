class Music{
    private string name;
    private string artist;
    private int duration;
    private bool available;

    public Music(string name, string artist, int duration, bool available){
        this.name = name;
        this.artist = artist;
        this.duration = duration;
        this.available = available;
    }

    public void ShowInformations()
    {
        System.Console.WriteLine($"Name: {name}");
        System.Console.WriteLine($"Artist: {artist}");
        System.Console.WriteLine($"Duration: {duration}");
        System.Console.WriteLine($"Available: {available}");
    }
}