Console.WriteLine("## Argumentos Nomeados ##");

Email email = new();
email.Enviar("teste@email.com", "urgente", "Reunião de orçamento");

//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião de orçamento");



Console.ReadKey();


public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}


