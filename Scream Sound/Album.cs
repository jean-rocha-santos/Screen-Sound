public class Album
{
    private List<Musica> _musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => _musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }
    public void ExibirAlbum()
    {
        Console.WriteLine($"Exibindo musicas do álbum: {Nome}");
        Console.WriteLine($"Para ouvir esse album inteiro você utilizara {DuracaoTotal}s\n");
        foreach (var musica in _musicas)
            Console.WriteLine($"Musica: {musica.Nome} \n " +
                $"Gênero: {musica.Generos.NomeGenero} \n ");

        /* musicas.ForEach(musica =>
         {
             Console.Write($"Musica {musica.Nome}: {musica.Genero.NomeGenero} ");

             if (musica.Duracao > 215)
                 Console.WriteLine($"Duração musica: {musica.Duracao}");
         });*/

        

    }
}