public class Jogo
{
    public Jogo(string nome, string genero, int anolancamento)
    {
        Nome = nome;
        Genero = genero;
        Anolancamento = anolancamento;
    }

    public string Nome { get;  }
    public string Genero { get;  }
    public int Anolancamento { get;  }
}
