
Console.WriteLine("## Parametros Opcionais ##");

Console.WriteLine("Informe o destino:");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo:");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto:");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

//não posso fazer
//email.Enviar(destino, , titulo); //->erro

email.Enviar(destino, assunto: assunto);


Console.ReadKey();


public class Email
{
    //parametros obrigatorios vem primeiro, depois os opcionais
    public void Enviar(string destino, string titulo = "Titulo padrão", string assunto = "Assunto padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}


