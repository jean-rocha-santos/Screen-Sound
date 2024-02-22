public class CatalogoJogos
{
    private List<Jogo> _jogos { get; set; }
    public bool CatalogoVazio => _jogos.Count == 0;
    public CatalogoJogos()
    {
        _jogos = new List<Jogo>();
    }
    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        _jogos.Add(novoJogo);
        Console.WriteLine($"O jogo \"{nome}\" adicionado ao catálogo.");
    }
    public void VizualizarJogo()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("Não há nenhum jogo no catalogo");
        }
        else {
            Console.WriteLine("\nJogos do catalogo");
            foreach (var jogo in _jogos) { 
        Console.WriteLine($"\nNome: {jogo.Nome}\n" +
            $"Genero: {jogo.Genero}\n" +
            $"Lançamento: {jogo.Anolancamento}");
            }
        }
    }
}