Console.WriteLine("## this ##\n");

// <- instruções do exemplo 2
//Teste t1 = new Teste(); 
//t1.Num1 = 10;
//t1.Num2 = 20;
//t1.Exibir();

//Teste t2 = new Teste();
//t2.Num1 = 88;
//t2.Num2 = 99;
//t2.Exibir();


//instrução exemplo 3
Teste t1 = new Teste(999); //executa o construtor com um parametro, como ele esta usando 'this' para chamar o construtor com 2 parametros, são exibidos 3 valores



Console.ReadKey();

//exemplo 1
//public class Cliente
//{
//    public string? Nome;
//    public int Idade;

//    public Cliente(string? Nome, int Idade)
//    {
//        this.Nome = Nome;
//        this.Idade = Idade;
        
//    }
//}

//exemplo 2

//public class Teste
//{
//    public int Num1;
//    public int Num2;

//    public void PassarParametro(Teste t)
//    {
//        Console.WriteLine($"\nthis = {this}");
//        Console.WriteLine($"Num1: {t.Num1}");
//        Console.WriteLine($"Num2: {t.Num2}");
//    }

//    public void Exibir()
//    {
//        //passando this como um parametro (a classe Teste)
//        PassarParametro(this); 
//    }
//}


//exemplo 3

public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parametros {num1} e {num2}");
    }

    public Teste(int num) : this(777, 888)
    {
        Console.WriteLine($"\nConstrutor com um parametro {num}");
    }
}
