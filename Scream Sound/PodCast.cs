public class PodCast
{
    private List<Episodio> _episodio { get; set; }

    public PodCast(string host, string nome, int totalEpisodeos)
    {
        Host = host;
        Nome = nome;
        TotalEpisodeos = totalEpisodeos;
        _episodio = new List<Episodio>();
    }
   
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodeos { get; }
    public void AdicionarEpisodeo(int duracao, int ordem, string titulo)
    {
        Episodio novoEpisodio = new Episodio(duracao, ordem, titulo);
        _episodio.Add(novoEpisodio);
        Console.WriteLine($"Um novo episódio foi adicionado a {Nome}\n");
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Exibindo detalhes do Podcast {Nome}" +
            $"Host: {Host}\n" +
                $"Total episódeos: {TotalEpisodeos}");

        foreach (var episodio in _episodio)
        {
            Console.WriteLine($"Episódio: {episodio.Ordem}\n" +
                $"Titulo: {episodio.Titulo}" +
                $"Duração: {episodio.Duracao}");
                
        }
        Console.WriteLine($"Total episódios {_episodio.Count}");
    }
}
