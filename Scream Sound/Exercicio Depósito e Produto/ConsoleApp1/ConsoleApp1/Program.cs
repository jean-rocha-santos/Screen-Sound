Produto grao1 = new Produto();
grao1.Nome = "Arroz";
grao1.Marca = "Camil";
/*grao1.Estoque = -10;*/
grao1.SetEstoque(-10);
grao1.Preco = 28;

Produto produto = new Produto()
{
    Nome = "tanana",
    Marca = "nana"
};
Produto produto2 = new Produto("tananas", "nanas");

Console.WriteLine(grao1.Descricao);