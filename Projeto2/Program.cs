using Projeto2;

Album albumDoCosta = new Album()
{
    Nome = "Epifania"
};

Musica musica1 = new Musica()
{
    Nome = "Alameda weed",
    Duracao = 111
};

Musica musica2 = new Musica()
{
    Nome = "Nada Bom",
    Duracao = 111
};

albumDoCosta.AdicionarMusica(musica1);
albumDoCosta.AdicionarMusica(musica2);

Banda costaGold = new Banda();
costaGold.Nome = "Costa Gold";
costaGold.AdicionarAlbum(albumDoCosta);
costaGold.ExibirDiscografica();


