
Console.WriteLine("## Structs ##\n");
//tipo de dado definido pelo usuario composta por outros tipos de dados e funcionalidades
//pode contar campos, metodos, constantes, construtores, propriedades
//diferença entre classe e structs: structs são tipos de valor e classes são tipos de referencia
//faz tudo que uma classe faz, porém mais leve
//struct aloca na memoria stack
//classe aloca na memoria heap
//usar struct se instancias forem pequenas e de curta duração



Cliente cliente = new();
cliente.Nome = "Maria";
cliente.Idade = 19;
Console.WriteLine($"{cliente.Nome} - {cliente.Idade}");


Console.ReadKey();


public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
