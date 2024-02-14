class Musica
// Em C#, uma classe(class) é uma estrutura de programação que serve como um modelo para criar objetos.
{
    public string nome;
    // public= ficar visivel para abas fora
    public string artista;
    public int duracao;
    public bool disponivel;
    // bool = Booleana Verdadeiro ou falso 

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");

        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira no plano plus");
        }

    }
}