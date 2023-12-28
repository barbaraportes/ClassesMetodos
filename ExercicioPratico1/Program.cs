

Console.WriteLine("## Exercicio pratico 1 ##\n");

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


Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
//chevrolet.Modelo = "Sedan";
//chevrolet.Montadora = "Chevrolet";
//chevrolet.Marca = "Onix";
//chevrolet.Ano = 2016;
//chevrolet.Potencia = 110;

Console.WriteLine($"{chevrolet.Modelo} - {chevrolet.Montadora} - {chevrolet.Marca} - {chevrolet.Ano} - {chevrolet.Potencia}\n");
chevrolet.Acelerar("Onix");

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
//ford.Modelo = "SUV";
//ford.Montadora = "Ford";
//ford.Marca = "EcoSport";
//ford.Ano = 2018;
//ford.Potencia = 120;
Console.WriteLine($"{ford.Modelo} - {ford.Montadora} - {ford.Marca} - {ford.Ano} - {ford.Potencia}\n"); 
ford.Acelerar("EcoSport");



Console.ReadKey();

public class Carro
{
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia= potencia;
    }

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}\n");
    }
}