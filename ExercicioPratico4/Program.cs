Console.WriteLine("## Exercicio pratico 4 ##\n");


//EXERCICIO 1
//1 - Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
//potencia com os tipos de dados string, string, string, int e int.

//Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

//a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet, Onix, 2016, 110
//b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120
//c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
//para cada objeto
//d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
//mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.
//e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
//modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)
//f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
//método Acelerar passando o valor do argumento para o parâmetro no método Acelerar
//Obs- Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os
//membros da classe

//-----------------------------------------------------------------------------------------------

//EXERCICIO 2
//g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
//use a palavra-chave this)
//h- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
//i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
//vai retornar um double representando a velocidade máxima do carro ( Para calcular a velocidade multiplique a potencia por 1.75)
//j- Explique o comportamento da palavra return


//-----------------------------------------------------------------------------------------------

//EXERCICIO 3

//l - Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
//potencia e retorna um int representando o aumento de potencia.
//(para aumentar a potência incremente 3 ao parâmetro recebido)
//m- Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o
//comportamento da passagem do argumento por valor
//n- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
//chamado potencia e retorna um int representando o aumento de potencia.(para aumentar a potência incremente 5 ao parâmetro recebido)
//o- Explique a sobrecarga de métodos
//p- Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o
//comportamento da passagem do argumento por referência.


//-----------------------------------------------------------------------------------------------

//EXERCICIO 3


//r - Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
//como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai
//retornar a nova velocidade como um double.
//(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
//s- Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o
//comportamento do parâmetro out.


Console.WriteLine("-------------------------------## CARRO 1 ##----------------------------------\n");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
//Carro chevrolet = new Carro("Sedan", "Chevrolet");
//chevrolet.Modelo = "Sedan";
//chevrolet.Montadora = "Chevrolet";
//chevrolet.Marca = "Onix";
//chevrolet.Ano = 2016;
//chevrolet.Potencia = 110;

Console.WriteLine($"{chevrolet.Modelo} - {chevrolet.Montadora} - {chevrolet.Marca} - {chevrolet.Ano} - {chevrolet.Potencia}\n");
chevrolet.Acelerar("Onix");
Console.WriteLine($"\nVelocidade máxima: {chevrolet.VelocidadeMaxima(110)}\n");

Console.WriteLine("Aumentando a Potencia (por valor + 3CV):");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.WriteLine($"\n-> {novaPotenciaChevrolet}");
Console.WriteLine($"\nO valor do campo potencia não foi alterado: {chevrolet.Potencia}");

Console.WriteLine("\nUsando parametro out -> Aumenta potencia e velocidade ");
double novaPotencia = chevrolet.AumentarPotenciaEVelocidade(chevrolet.Potencia, out double velocidade);
Console.WriteLine("Nova Potencia: " + novaPotencia);
Console.WriteLine("Nova velocidade máxima: " + velocidade);


Console.WriteLine("\n------------------------------------------------------------------------------\n");

Console.WriteLine("\n-------------------------------## CARRO 2 ##----------------------------------\n");
Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
//Carro ford = new Carro("SUV", "Ford");
//ford.Modelo = "SUV";
//ford.Montadora = "Ford";
//ford.Marca = "EcoSport";
//ford.Ano = 2018;
//ford.Potencia = 120;
Console.WriteLine($"{ford.Modelo} - {ford.Montadora} - {ford.Marca} - {ford.Ano} - {ford.Potencia}\n");
ford.Acelerar("EcoSport");
Console.WriteLine($"\nVelocidade máxima: {chevrolet.VelocidadeMaxima(120)}\n");

Console.WriteLine("Aumentando a Potencia (por referencia + 5CV):");
var novaPotenciaFord = ford.AumentarPotencia(ford.Potencia);
Console.WriteLine($"\n-> {novaPotenciaFord}");
Console.WriteLine($"\nO valor do campo potencia foi alterado: {ford.Potencia}");


Console.WriteLine("\n------------------------------------------------------------------------------\n");


Console.ReadKey();

public class Carro
{
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    //public Carro(string? modelo, string? montadora) 
    //{
    //    Modelo = modelo;
    //    Montadora = montadora;
    //}

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}\n");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        potencia *= 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia *= 5;
        return potencia;
    }

    public int AumentarPotenciaEVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }


}