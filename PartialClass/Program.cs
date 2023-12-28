
using PartialClass;

Console.WriteLine("## Partial Class ##\n");

//Regras:
//1- todas as definições de classes parciais devem estar no mesmo assembly e no mesmo namespace
//2-todas as partes devem possuir a mesma acessibilidade como public, private etc
//3-se qualquer parte for declarada abstract, entao toda a classe sera abstract
//4-o modificador partial somente pode ser usado antes de class, struct ou interface
//5-tipos parciais aninhados são permitidos
//6-os atributos se aplicam a todas as partes da classe
//7-as caracteristicas definidas em qualquer parte estão disponiveis para todas as partes das classes



MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("\nIdade para nascidos em: 07/08/2003\n");

var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para nascidos em: 02/06/2005\n");

var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);
var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");


Console.ReadKey();




