class Song{
    private readonly string artist;
    private bool available;
    public bool canSwitchAvailable = true;
    
    public string Name{ get; }
    public int Duration{ get; }

    public bool Available
    {
        get
        {
            return available;
        }
        set
        {
            if(canSwitchAvailable)
            {
                available = value;
            }
            else
            {
                available = false;
                Console.WriteLine("Você não pode alterar a propriedade Available!");
            }
        }
    }


    public Song(string name, string artist, int duration, bool available)
    {
        Name = name;
        Duration = duration;
        this.artist = artist;
        Available = available;
    }

    public void ShowInformations()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Available: {Available}");
    }
}