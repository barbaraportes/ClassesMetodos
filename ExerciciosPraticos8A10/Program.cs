

Console.WriteLine("## Exercicios Praticos (8 A 10) ##\n");

// EXERCICO 8

//w3 - Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade
//do tipo int
//w4- Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao
//valor da idade.
//w5- Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros
//de entrada para criar um objeto do tipo Cliente
//w6- Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e
//idade e exiba as informações de Nome, Email e Idade. Defina idade como um parâmetro opcional.
//w7- Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas
//vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e
//na segunda não informe o ano.
//w8- Explique o que uma struct e qual a principal diferença entre struct e classe

//------------------------------------------------------------------------------------------------------------------

// EXERCICIO 9


//-Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros :
//Branco, Vermelho, Preto, Cinza, Prata e Azul
//- Inicie o valor da enumeração com 1
//- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro
//- Defina um menu de opções exibindo o nome da Cor e o seu valor
//- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor
//- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da
//cor a partir do valor da Cor recebida
//- Altere o construtor da classe incluindo o campo Cor para criar objetos usando a Cor selecionada



//------------------------------------------------------------------------------------------------------------------

// EXERCICIO 10

//-Explique como poderíamos substituir o método ObterValorIPVA() de forma a inicializar o campo estático
//ValorIpva quando uma instância da classe fosse criada.
//- Implemente o código que realiza essa substituição
//- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para internal ?
//-Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para private ?



//------------------------------------------------------------------------------------------------------------------

Cliente cliente = new("Maria", "maria@email.com", 19);
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, idade: cliente.Idade);
Console.WriteLine("\nExibindo informação sem informar a idade");
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);



Console.ReadKey();



public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cliente menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Cliente maior que 18 anos");
                idade = value;
            }
        }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }
    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"{nome} - {email} - {idade}");
    }
}

