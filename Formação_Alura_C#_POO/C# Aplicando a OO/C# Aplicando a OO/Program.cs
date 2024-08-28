Musica musica1 = new Musica();// essa variavel musica1, é do tipo musica

musica1.Nome = "Roxane";
musica1.Artista = "The police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();

musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

/*Console.WriteLine($"Nome: {musica1}");
como não foi adicionado nenhuma variavel da classe, será retornado, o proprio nome da classe*/

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();