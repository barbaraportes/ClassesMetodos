﻿Console.WriteLine("## Métodos ##\n");


MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();




Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo");
        ExibirDataAtual();

    }

    public void ExibirDataAtual() =>    
        Console.WriteLine(DateTime.Now.ToShortDateString());
    //apenas 1 linha de instrução pode usar essa expressão mais compacta =>
}
