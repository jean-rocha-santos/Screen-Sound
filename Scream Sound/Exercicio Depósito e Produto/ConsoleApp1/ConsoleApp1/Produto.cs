
class Produto : Deposito
{
    public Produto()
    {

    }
    public Produto(string nome, string marca)
    {
        Nome = nome;
        Marca = marca;
    }

    public string Nome { get; set; }
    public string Marca { get; set; }
    public int preco;
    public int Preco
    {
        get => preco; set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 0;
            }
        }
    }
    private int _estoque;
    public int Estoque
    {
        get => _estoque; set
        {
            if (value > 0)
            {
                _estoque = value;
            }
            else { _estoque = 0; }
        }
    }

    /*public int Estoque { get => _estoque; }*/

    public void SetEstoque(int estoque)
    {
        _estoque = estoque;
    }
    public string Descricao =>
        $"O produto {Nome} da marca {Marca}, está custando {Preco} no atacado, e temos {_estoque} no estoque";
}
