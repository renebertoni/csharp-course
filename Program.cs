// Screen Sound
string welcomeMessage = "\nBem vindo ao Screen Sound";
// List<string> bandList = new List<string>();

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();

string[] OPTIONS = new string[4] {
    "criar uma banda",
    "mostrar uma banda",
    "avaliar uma banda",
    "sair"
    };

void ShowMainMenu()
{
    Console.Clear();
    Console.WriteLine(@"Screen Sound");
    Console.WriteLine(welcomeMessage);

    for (int i = 0; i < OPTIONS.Length ; i++)
    {
        Console.WriteLine($"Digite {i+1} para {OPTIONS[i]}");
    }
    ActiveInteraction();
}

void ActiveInteraction()
{
    int userNumber;

    Console.Write("Make your choice: ");
    try
    {
        userNumber = int.Parse(Console.ReadLine()!);
    }
    catch(System.Exception)
    {
        Console.Clear();
        Console.WriteLine("O valor digitado não é válido");
        return;
    }

    switch (userNumber)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowRegisteredBands();
            break;
        case 3:
            EvaluateBand();
            break;
        case 4:
            Console.WriteLine("Saindo do sistema");
            break;
        default:
            Console.WriteLine("Valor inválido");
            break;
    }
}

void GenerateTitle(string title)
{
    Console.Clear();
    int titleLetterCount = title.Length;
    GenerateTitleSeparator(titleLetterCount);
    Console.WriteLine(title);
    GenerateTitleSeparator(titleLetterCount);
    Console.Write("\n");
}

void GenerateTitleSeparator(int titleLetterCount)
{
    string separator = string.Empty.PadLeft(titleLetterCount, '*');
    Console.WriteLine(separator);
}

void RegisterBand()
{
    GenerateTitle("Registro de bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());
    Console.Write($"A banda {bandName} foi registrada com sucesso!!!");
    Thread.Sleep(2000);
    ShowMainMenu();
}

void ShowRegisteredBands()
{
    GenerateTitle("Listar bandas");
    
    foreach (var band in registeredBands.Keys)
    {
        Console.WriteLine(band);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    ShowMainMenu();
}

void EvaluateBand()
{
    GenerateTitle("Avaliar banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;

    if(registeredBands.ContainsKey(bandName))
    {
        Console.Write($"Digite a nota que quer atribuir para a banda {bandName}: ");
        try
        {
            int bandNote = int.Parse(Console.ReadLine()!);
            registeredBands[bandName].Add(bandNote);
            Console.WriteLine("\nA nota foi atribuída com sucesso");
        }
        catch (System.Exception)
        {
            Console.WriteLine("O valor digitado não é válido");
        }
    } else
    {
        Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
    }

    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    ShowMainMenu();
}

ShowMainMenu();