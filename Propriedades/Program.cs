
Console.WriteLine("## Propriedades ##\n");

//get - somente leitura
//set - somente gravação

//vantagens:
//melhor controle dos membros da classe, evita bagunçar o codigo


Produto p1 = new();
p1.Nome = "Caderno Espiral";
p1.Preco = 10.00;
//p1.Desconto = 0.05;
//p1.PrecoFinal = p1.Preco - (p1.Preco * p1.Desconto);
p1.EstoqueMinimo = 10;
p1.Exibir();



Console.ReadKey();


public class Produto
{
    private string? nome;
    public string? Nome 
    {
        get { return nome.ToUpper(); }
        set { nome = value; } 
    }
    private double preco;
    public double Preco 
    { 
        get { return preco; }
        set 
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco =  value;
        } 
    }
    private double desconto = 0.05; //valor fixo encapsulado dentro da classe
    public double Desconto 
    { 
        get { return desconto; }
    }


    public double PrecoFinal 
    { 
        get { return Preco - (Preco * Desconto); }
    }

    private int minimo;
    public int EstoqueMinimo 
    { 
        set {  minimo = value; }
    }   


    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco:c} \n{Desconto}" +
                          $"\n{PrecoFinal:c} \n{minimo}");
    }

}

