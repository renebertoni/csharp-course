class Music{
    private readonly string name;
    private readonly string artist;
    private readonly int duration;
    private bool available;
    public bool canSwitchAvailable = true;

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


    public Music(string name, string artist, int duration, bool available)
    {
        this.name = name;
        this.artist = artist;
        this.duration = duration;
        Available = available;
    }

    public void ShowInformations()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Duration: {duration}");
        Console.WriteLine($"Available: {Available}");
    }
}