/*class ContaBancaria
{
    public string Titular { get; set; }
    public int IdConta { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }

public void ExibirConta()
{
    Console.WriteLine($"Titular: {Titular}");
    Console.WriteLine($"Saldo da conta: {Saldo}");
}*/

/*}*/


class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }
}
class Conta
{
    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }
    public Titular Titular { get; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}," +
        $" Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public void ExibirConta()
    {
        Console.WriteLine($"Olá {Titular.Nome}, você tem R${Saldo} em sua conta, e R${Limite} de limite para utilizar. ");
    }

}

