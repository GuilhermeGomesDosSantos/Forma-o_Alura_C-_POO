Musica musica1 = new Musica();// essa variavel musica1, é do tipo musica

musica1.nome = "Roxane";
musica1.artista = "The police";
musica1.duracao = 273;
musica1.disponivel = true;

Musica musica2 = new Musica();

musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;

/*Console.WriteLine($"Nome: {musica1}");
como não foi adicionado nenhuma variavel da classe, será retornado, o proprio nome da classe*/

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();