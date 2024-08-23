﻿// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//é uma coleção que armazena pares de chave-valor, onde cada chave é única e está associada a um valor.
bandasRegistradas.Add("Banda 1", new List<int> { 10, 4, 6 });
bandasRegistradas.Add("Banda 2", new List<int>());

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
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda: ");
    string NomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(NomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); // Thread, é usado para suspender a execução da thread atual por um período especificado de tempo
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void mostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    /*for (int i = 0; i < listaDasBandas.Count; i++)/*é usado para definir o número de vezes que o loop deve ser executado, com base no número de elementos em uma coleção
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/
    foreach (string banda in bandasRegistradas.Keys)// o foreach, itera sobre cada elemento na lista listaDasBandas, A cada iteração, o valor do elemento atual é atribuído à variável banda
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu(); 
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    /*
    é usado para criar uma nova string que é uma versão da string original,
    mas com caracteres de preenchimento adicionados à esquerda até que a string atinja um comprimento especificado*/
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

ExibirOpcoesDoMenu();