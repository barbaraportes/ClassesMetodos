
Console.WriteLine("## Passando argumentos por valor ##\n");

//é passado uma copia do valor da variavel, não altera o valor do argumento

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x); //x = 20

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\nValor do argumento x depois de passar por valor " + x); //x = 20


Console.ReadKey();


public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parametro y no método Dobrar " + y); //y = 40
    }
}