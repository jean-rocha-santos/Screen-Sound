/*ContaBancaria conta1= new ContaBancaria();
conta1.Titular = "Jean Rocha Santos";
conta1.IdConta = 1;
conta1.Saldo = 300;
conta1.Senha = 12345;

conta1.ExibirConta();*/



Titular titular1 = new Titular("Jean Rocha", "111.111.111-11", "Rua dos vianas 63");
Conta conta1 = new Conta(titular1, 123, 12345, 600.40, 850.00);

conta1.ExibirConta();

