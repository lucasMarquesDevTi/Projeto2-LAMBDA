using Projeto2;

Musica musica1 = new Musica()
{
    Nome = "Doce veneno",
    Artista = "Costa gold",
    Duracao = 300,
    Disponivel = true
};

Musica musica2 = new Musica()
{
    Nome = "Conexões de mafia",
    Artista = "Matuê",
    Duracao = 450,
    Disponivel = false
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();


