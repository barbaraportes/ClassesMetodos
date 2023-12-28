

using TipoEnumOuEnumeration;

Console.WriteLine("## Tipo Enum ou Enumeration ##\n");

//tipo de valor
//tipo de dados especial definido pelo usuario
//é uma classe especial que é definida por um conjunto de constantes nomeadas do tipo numerico
//ajuda a tornar o programa mais facil de entender e manter
//por padrão, valor associado aos membros de uma enum são do tipo int (quando ãda é declarado)
//o primeiro membro de um enum tem valor 0 e os seguintes 1, 2, 3 ...
//pode atribuir valores diferentes para cada membro


Console.WriteLine(DiasDaSemana.Domingo);
Console.WriteLine(DiasDaSemana.Terça);

int dia1 = (int)DiasDaSemana.Domingo;
int dia2 = (int)DiasDaSemana.Terça;

Console.WriteLine($"\n{DiasDaSemana.Domingo} vale: {dia1}");
Console.WriteLine($"\n{DiasDaSemana.Terça} vale: {dia2}");

//--------------------------------------------------

Console.WriteLine($"\n{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"\n{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"\n{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"\n{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"\n{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"\n{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");


Console.WriteLine("\nSelecione a categoria teclando seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\nVoce selecionou a categoria: {nomeMembroEnum.ToString()}");



Console.ReadKey();




