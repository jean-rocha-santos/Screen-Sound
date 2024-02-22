public class Genero
{
    private List<Musica> musicas = new List<Musica>();

    public Genero(string nome)
    {
        NomeGenero = nome;
    }

    public string NomeGenero { get; }


    public void ExibirGenero()
    {
        Console.WriteLine($"O genero da música é {NomeGenero}");
    }

    public void AdicionarGenero(Musica nome)
    {
        musicas.Add(nome);
    }
}
