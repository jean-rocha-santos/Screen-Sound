using System.Linq.Expressions;
using System;

public class Musica
// Em C#, uma classe(class) é uma estrutura de programação que serve como um modelo para criar objetos.
{

    public Musica(Banda artista, string nome, Genero nomeGenero)
    {
        Artista = artista;
        Nome = nome;
        Generos= nomeGenero;
    }
    public string Nome { get; }
    // public= ficar visivel para abas fora
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
    $"A música {Nome} pertence a banda {Artista}";
    public Genero Generos { get;}

    // => = Lambda é um método compilado, que pode ser executado,
    // e passado como se fosse uma variável para quem necessitar. 
    //unções anônimas ou funções de flecha, comumente usadas para 
    //criar delegates ou expressões de árvore de expressão.
    //No C#, lambdas são funções anônimas que podem ser usadas para
    //criar expressões ou blocos de código compactos e concisos. Eles
    //são especialmente úteis quando se trata de trabalhar com coleções
    //de dados, realizar operações em uma sequência de elementos ou lidar
    //com delegados.
    //

    // A palavra reservada "private" é usada para especificar que um membro
    // de uma classe só pode ser acessado dentro dessa mesma classe.
    // bool = Booleana Verdadeiro ou falso 

 /*   public void DesignTitulos(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);

    }*/

    public void ExibirFichaTecnica()
    {
        Console.Write($"Musica: {Nome}, ");
        Console.Write($"Artista: {Artista.Nome}, ");
        Console.Write($"Duração: {Duracao}, ");
        Console.WriteLine($"Gênero: {Generos.NomeGenero}. ");
        

        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira no plano plus\n");
        }

    }
    public void ExibirNomes()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}