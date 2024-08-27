Musica musica1 = new Musica();// essa variavel musica1, é do tipo musica

musica1.nome = "Roxane";
musica1.artista = "The police";

Musica musica2 = new Musica();

musica2.nome = "Vertigo";
musica2.artista = "U2";

/*Console.WriteLine($"Nome: {musica1}");
como não foi adicionado nenhuma variavel da classe, será retornado, o proprio nome da classe*/

Console.WriteLine($"Nome: {musica1.nome}");
Console.WriteLine($"Artista: {musica2.artista}");