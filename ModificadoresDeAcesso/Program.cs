
using ModificadoresDeAcesso;

Console.WriteLine("## Modificadores de Acesso ##\n");

// palavras chave usadas para especificar o acesso de um membro(campo, propriedade, método) ou de um tipo(classe, struct)
// public - tipo ou membro pode ser acessado por qualquer outro codigo no mesmo assembly ou outro assembly
// private - pode ser acessado somente pelo codigo na mesma classe ou struct
// internal - pode ser acessado por qualquer codigo no mesmo assembly, mas não de outro assembly
// protected - pode ser acessado por qualquer codigo no assembly no qual ele é declarado ou de uma classe derivada em outro assembly
// (classe derivada = herança)
// file - restringe o escopo e a visibilidade de um tipo de nivel superior ao arquivo no qual ele for declarado




MinhaClasse minhaClasse = new MinhaClasse();
//minhaClasse. -> não tem acesso aos membros pq é internal

MinhaStruct minhaStruct = new MinhaStruct();
//minhaStruct. -> não tem acesso aos membros pq é internal
MinhaEnum minhaEnum = new MinhaEnum();
//minhaEnum. -> não tem acesso aos membros pq é internal





Console.ReadKey();






