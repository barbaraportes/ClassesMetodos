Console.WriteLine("## Passando argumentos por referência (ref) ##\n");

//é passado a referencia da area da memoria
//as alterações feitas no parametro, afetam o argumento

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por referencia " + x); //x = 20

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por referencia " + x); //x = 40


Console.ReadKey();


public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parametro y no método Dobrar " + y); //y = 40
    }
}