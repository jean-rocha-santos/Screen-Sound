class Deposito
{

    private int _preco;
    public int Preco
    {
        get => _preco; set
        {
            if (value > 0)
            {
                _preco = value;
            }
            else
            {
                _preco = 0;
            }
        }
    }
    private int _estoque;
    public int Estoque { get => _estoque; }

    public void SetEstoque(int estoque)
    {
        _estoque = estoque;
    }
}