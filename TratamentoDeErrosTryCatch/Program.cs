
Console.WriteLine("## Tratamento de Erros: Bloco Try/Catch ##\n");

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

try
{    
    int z = x / y;

    Console.WriteLine($"\n{x} / {y} = {z}");

}

catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por 0, tente outro número...");

    Console.WriteLine($"\nErro: <<<{ex.Message}>>>");
    Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("\nProcessamento concluido.");
}




Console.ReadKey();



