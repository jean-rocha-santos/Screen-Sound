/*Musica musica1 = new Musica();
musica1.Nome = "Céu Azul";
musica1.Artista = "Charlie Brown";
musica1.Duracao = 240;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Love Love";
musica2.Artista = "Gilsons";
musica2.Duracao = 280;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
Console.WriteLine(musica1.DescricaoResumida);
musica2.ExibirNomes();

*/
Banda LegiaoUrbana = new Banda("Legião Urbana");
Album albumLegiao = new Album("Dois");
Genero Rock = new Genero("Rock");




Musica musica1 = new Musica(LegiaoUrbana, "Quase sem Querer", Rock)
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(LegiaoUrbana, "Tempo Perdido", Rock)
{
    Duracao = 250,
    Disponivel = true,
};


Musica musica3 = new Musica(LegiaoUrbana, "Índios", Rock)
{
    Duracao = 230,
    Disponivel = false,
};


albumLegiao.AdicionarMusica(musica1);
albumLegiao.AdicionarMusica(musica2);
albumLegiao.AdicionarMusica(musica3);
LegiaoUrbana.AdicionarAlbum(albumLegiao);

/*albumLegiao.ExibirAlbum();*/

LegiaoUrbana.ExibirDiscografia();
albumLegiao.ExibirAlbum();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();

PodCast Flow = new PodCast("Igão","Flow Podcast",100);
Episodio episodio1 = new Episodio(240, 1, "CBUM - Flow #1");
Flow.AdicionarEpisodeo(episodio1.Duracao,episodio1.Ordem, episodio1.Titulo);

episodio1.AdicionarConvidado("CBUM");
episodio1.ExibirResumo();
Flow.ExibirDetalhes();