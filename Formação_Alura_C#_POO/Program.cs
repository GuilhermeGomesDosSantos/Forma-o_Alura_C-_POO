// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void exibirMensagemDeBoasVindas()
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

exibirMensagemDeBoasVindas();

void ExibirOpcoesDoMenu()
{
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
        case 1: Console.WriteLine("Você escolheu a opção " + OpcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + OpcaoEscolhidaNumerica);
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

ExibirOpcoesDoMenu();