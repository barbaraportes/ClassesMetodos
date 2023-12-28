
Console.WriteLine("## Tipos Anônimos ##\n");

// é uma classe sem nenhum nome que pode conter apenas propriedades publicas somente leitura
// é inicializado usando o operador new, combinado com um inicializador de objetos (chaves)
// são normalmente usados em clausula select de uma expressao de consulta, geralmente com a LINQ, para retornar um subconjunto das propriedades de cada objeto



//  - propriedade do tipo anonimo

//var aluno = new
//{
//    Id = 1,
//    Nome = "Maria",
//    Email = "maria@email.com",
//    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" } 
//};

//Console.WriteLine(aluno.Nome);
//Console.WriteLine(aluno.Endereco.Cidade);


// - array do tipo anonimo

var alunos = new[] {
             new {Id = 1, Nome = "Maria", Email = "maria@email.com"},
             new {Id = 2, Nome = "Jorge", Email = "jorge@email.com"},
             new {Id = 3, Nome = "Barbara", Email = "barbara@email.com"}
};

Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);

Console.WriteLine();

//para saber qual nome o compilador da
Console.WriteLine(alunos.GetType().ToString()); 



Console.ReadKey();



