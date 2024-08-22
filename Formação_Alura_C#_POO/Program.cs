// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();
void exibirLorgo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    exibirLorgo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção escolhida: "); // o comando write, é usado para o usuário digitar o número na mesma linha da mensagem e o WriteLine irá aparecer para digitar a informação na linha de baixo
    string OpcaoEscolhida = Console.ReadLine()!;
    /*Ele é usado para suprimir avisos de nulidade que o compilador pode gerar em situações onde ele não tem certeza se um valor pode ser null,
     mas o programador sabe que o valor não será null em tempo de execução*/

    int OpcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida); // o int.Parse, é utilizado para converter uma variavel do tipo string, em uma variavel do tipo numerica
    
    switch (OpcaoEscolhidaNumerica)
    {
        case 1: CadastrarBanda();
            break;
        case 2: mostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + OpcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + OpcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Tchau Tchau");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}

void CadastrarBanda()
{
    Console.Clear(); // clear, é usado para limpar todo o conteúdo exibido na janela do console
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda: ");
    string NomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(NomeDaBanda);
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); // Thread, é usado para suspender a execução da thread atual por um período especificado de tempo
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void mostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************");

    for (int i = 0; i < listaDasBandas.Count; i++)/*é usado para definir o número de vezes que o loop deve ser executado, com base no número de elementos em uma coleção*/
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu(); 
}

ExibirOpcoesDoMenu();