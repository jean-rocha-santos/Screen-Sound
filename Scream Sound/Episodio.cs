public class Episodio
{
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
        _convidado = new List<string>();
    }

    private List<string> _convidado { get; set; }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo =>
        $"O episódio {Titulo} tem uma duração de {Duracao}- {string.Join(", ", _convidado)}";

    public void ExibirResumo()
    {
        foreach (var convidado in _convidado)
        {
            Console.WriteLine($"O episódio '{Titulo}' tem uma duração {Duracao}s, convidado - {convidado}");
        }
    }

    public void AdicionarConvidado(string nomeConvidado)
    {
        string convidado = new(nomeConvidado);
        _convidado.Add(convidado);
    }
}