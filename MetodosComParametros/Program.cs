Console.WriteLine("## Métodos com Parâmetros ##\n");


MinhaClasse minhaClasse = new();

//valores dos argumentos

//maneira 1
//minhaClasse.Saudacao("Maria", DateTime.Now.ToShortDateString());


//maneira 2
var nomeCliente = "Maria";
var dataAtual = DateTime.Now.ToShortDateString();

minhaClasse.Saudacao(nomeCliente, dataAtual);


Console.ReadKey();


public class MinhaClasse
{   
    public void Saudacao(string nome, string data) //parametros dos metodos
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}

