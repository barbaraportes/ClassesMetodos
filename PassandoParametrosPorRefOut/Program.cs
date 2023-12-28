
Console.WriteLine("## Argumentos por referência - out ##\n");

Console.WriteLine("Informe o valor do círculo\n");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro da circunferencia: {perimetro}");
Console.WriteLine($"Area da circunferencia: {area}");




Console.ReadKey();




public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

    

}

