Console.WriteLine("## Métodos Estáticos - Métodos de classe ##");
//são metodos que não dependem de um objeto, não depende de uma criação de instancia da classe pra ser acessado
//pertencem a classe, e não ao objeto 
//não pode usar variaveis de instancia
//exemplos: Math /  Console / Main

var somar = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);





Console.ReadKey();
//para visualizar metodos da classe console, selecione a palavra e aperte f12


public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }


}


