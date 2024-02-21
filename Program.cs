// Screen Sound
string welcomeMessage = "\nBem vindo ao Screen Sound";
List<string> bandList = new List<string>();
string[] OPTIONS = new string[4] {
    "criar uma banda",
    "mostrar uma banda",
    "avaliar uma banda",
    "sair"
    };

void ShowMenu()
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
    userNumber = int.Parse(Console.ReadLine()!);

    switch (userNumber)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowBands();
            break;
        case 3:
            Console.WriteLine("Banda avaliada com sucesso!!!");
            break;
        case 4:
            Console.WriteLine("Saindo do sistema");
            break;
        default:
            Console.WriteLine("Valor inválido");
            break;
    }

}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName);
    Console.Write($"A banda {bandName} foi registrada com sucesso!!!");
    Thread.Sleep(2000);
    ShowMenu();
}

void ShowBands()
{
    Console.Clear();
    Console.WriteLine("Listar bandas\n");
    foreach (var band in bandList)
    {
        Console.WriteLine(band);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    ShowMenu();
}

ShowMenu();