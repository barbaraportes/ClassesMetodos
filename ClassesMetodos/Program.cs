Console.WriteLine("## Classes ##\n");


Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.Idade = 25;
p1.Sexo = "feminino";

Console.WriteLine($"{p1.Nome} {p1.Idade} {p1.Sexo}");




Console.ReadKey();


class Pessoa
{
    public string? Nome;
    public int? Idade;
    public string? Sexo;
}