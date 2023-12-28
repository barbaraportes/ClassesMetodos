Console.WriteLine("## Construtores ##\n");

/*Aluno aluno = new("Maria", 22, "feminino", "S"); *///tem que passar os valores por conta do construtor com parametros

/*Aluno aluno = new("Maria"); *///o construtor com parametro atribui o nome Maria e o restante é atribuido o valor padrão, pelo construtor padrão

Aluno aluno = new("Maria",22, "feminino", "S");

//quando não cria um construtor com parametros, é criado automaticamente um construtor padrão com valores padrões
Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);



Console.ReadKey();

public class Aluno
{
    public Aluno(string nome) => Nome = nome; //usa expressão mais compacta (=>) quando tem apenas 1 linha de instrução

    //construtor com parametros
    public Aluno(string nome, int idade, string sexo, string aprovado):this(nome) //this chama o outro construtor
    {        
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}