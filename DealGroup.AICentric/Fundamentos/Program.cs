using Fundamentos.Models; // Importando o namespace Fundamentos.Models para usar a classe Pessoa
// O namespace é como uma "caixa" que organiza as classes. Para usar a classe Pessoa, devemos importar este namespace.


// Toda execução do programa em C# começa pelo método Main. 
// É aqui que o código do programa será executado, como se fosse o ponto de entrada.
class Program
{
    static void Main(string[] args)
    {
        // Declarando e criando uma instância (objeto) da classe Pessoa
        // Uma instância é como uma "cópia" da classe, onde podemos armazenar valores específicos para ela.
        Pessoa pessoa1 = new Pessoa(); // Criação do objeto pessoa1 da classe Pessoa

        // Atribuindo valores aos atributos do objeto pessoa1
        pessoa1.Nome = "Lucas"; // Atribuindo o valor "Lucas" ao atributo Nome de pessoa1
        pessoa1.Idade = 25; // Atribuindo o valor 25 ao atributo Idade de pessoa1

        // Chamando o método Apresentar da pessoa1
        // O método Apresentar é uma ação que o objeto pode executar, neste caso, exibe uma mensagem no console
        pessoa1.Apresentar(); // Chama o método Apresentar da classe Pessoa e exibe no console

        // Explicações importantes:
        // 1. O ponto (.) é utilizado para acessar membros (atributos e métodos) de um objeto.
        // 2. O C# é case-sensitive, ou seja, ele diferencia maiúsculas de minúsculas. Então, "Nome" é diferente de "nome".
        // 3. O ponto e vírgula (;) encerra uma instrução em C#.
        // 4. O estilo camelCase é usado para declarar variáveis: começa com minúscula e as palavras subsequentes começam com maiúsculas. Exemplo: nomeCompleto.

        // ---------------- Exemplos de declaração de variáveis -----------------

        // Declaração de variáveis de diferentes tipos de dados
        string apresentacao = "Olá, seja bem-vindo ao curso de C#"; // Variável de tipo string (texto)
        int quantidade = 1; // Variável de tipo int (número inteiro)
        double altura = 1.80; // Variável de tipo double (número com casas decimais)
        decimal preco = 1.80M; // Variável do tipo decimal (também número com casas decimais) com o sufixo M indicando que é decimal
        bool condicao = true; // Variável do tipo bool (booleano), que pode ser verdadeiro ou falso

        // Exibindo o valor das variáveis no console
        Console.WriteLine(apresentacao); // Exibe a string "Olá, seja bem-vindo ao curso de C#"
        Console.WriteLine("Quantidade: " + quantidade); // Exibe o número inteiro armazenado na variável quantidade
        Console.WriteLine("Altura: " + altura.ToString("0.00")); // Exibe a altura formatada com 2 casas decimais
        Console.WriteLine("Preço: " + preco); // Exibe o preço
        Console.WriteLine("Condição: " + condicao); // Exibe o valor booleano (true ou false)

        // ---------------------- Trabalhando com datas ----------------------

        // A classe DateTime permite trabalhar com datas e horas
        DateTime dataAtual = DateTime.Now.AddDays(5); // Cria uma variável com a data e hora atual + 5 dias
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // Exibe a data formatada como dia/mês/ano hora:minuto

        // ------------------- Operadores de atribuição ---------------------

        int a = 10; // Declarando e inicializando a variável a com o valor 10
        int b = 20; // Declarando e inicializando a variável b com o valor 20
        int c = a + b; // Somando os valores de a e b e atribuindo o resultado à variável c
        Console.WriteLine("Valor de c: " + c); // Exibe o valor da soma, ou seja, 30

        // O operador "=" é o operador de atribuição, que atribui o valor da expressão à esquerda para a variável à direita.

        // ---------------- Operadores de atribuição compostos ----------------

        c = c + 5; // Soma 5 ao valor de c e atribui o novo valor a c
        // Podemos simplificar isso usando o operador de atribuição composto +=
        c += 5; // O mesmo que c = c + 5, mas de forma mais compacta
        Console.WriteLine("Valor de c após c += 5: " + c); // Exibe o novo valor de c, que agora é 40

        // --------------- Convertendo tipos de variáveis ---------------

        // Converting (Casting) de tipos de dados
        int numeroConvertido = Convert.ToInt32("5"); // Converte a string "5" para o tipo int
        Console.WriteLine("Valor de numeroConvertido: " + numeroConvertido); // Exibe o valor convertido (5)

        // Alternativa ao Convert é o método Parse
        // Exemplo: int numeroParse = int.Parse("5"); // Também converte a string "5" para int

        // -------------------- Diferenças entre Parse e Convert --------------------

        // A principal diferença entre os dois métodos é o tratamento de erros.
        // O método Convert retorna um valor padrão se não conseguir realizar a conversão (ex: 0 para int).
        // Já o Parse lança uma exceção se não conseguir converter (ex: ArgumentNullException se a string for null).

        int a2 = Convert.ToInt32(null); // Não gera erro, apenas atribui 0 a variável a2
        Console.WriteLine("Valor de a2 após Convert.ToInt32(null): " + a2); // Exibe 0

        // int.Parse(null); // Isso geraria uma exceção do tipo ArgumentNullException, pois Parse não aceita valores nulos.

        // -------------------- Conversão para String--------------------
        int inteiro = 5;
        string d = inteiro.ToString(); // Converte o int para string
        Console.WriteLine("Valor de a (int convertido para string): " + d); // Exibe "5" como string 
                                                                            // Também podemos converter outros tipos para string usando ToString(), como double, decimal, bool, DateTime, etc, pois todos herdam da classe Object que possui o método ToString().


        // -------------------- Casting implícito--------------------
        int g = 5;
        double f = g; // Conversão implícita de int para double, pois double tem maior capacidade
        Console.WriteLine("Valor de bf (double): " + f); // Exibe 5 como double (5.0)

        // -------------------- Casting explícito--------------------
        long v = 5;
        int h = Convert.ToInt32(v); // Conversão implícita de int para long, pois long tem maior capacidade
        Console.WriteLine("Valor de h (long): " + h); // Exibe 5 como long

        // -------------------- Ordem dos operadores --------------------
        Double resultado = 4 / 2 + 2; // A divisão e multiplicação têm precedência sobre a adição e subtração
        Console.WriteLine("Valor de resultado: " + resultado); // Exibe 4, pois 4/2 = 2 + 2 = 4
        resultado = (4 / (2 + 2)); // Usando parênteses para alterar a ordem das operações
        Console.WriteLine("Valor de resultado com parênteses: " + resultado);

        // -------------------- Covertendo de maneira segura--------------------
        string valor = "15-abc"; // String que não pode ser convertida diretamente para int
        // Usando TryParse para tentar converter a string para int de forma segura
        int numero = 0; // Variável para armazenar o valor convertido
        int.TryParse(valor, out numero); // Tenta converter valor para int e armazena em numero. Se falhar, numero permanece 0  
        Console.WriteLine("Valor de numero após TryParse: " + numero); // Exibe 0, pois a conversão falhou

        // -------------------- Operadores Consicionais--------------------
        int quantidadeEmEstoque = 10;
        int quantidadeCompra = 0;
        bool compraPossivel = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; // Verifica se há estoque suficiente para a compra e se a compra é maior que zero
        Console.WriteLine($"Quantidade em estoque: " + quantidadeEmEstoque);
        Console.WriteLine($"Quantidade da compra: " + quantidadeCompra);
        Console.WriteLine($"Compra possível?  {compraPossivel}"); // Verifica se a compra é possível (true ou false)

        if (quantidadeCompra == 0) // Verifica se a quantidade de compra é zero
        {
            Console.WriteLine("Venda inválida"); // Mensagem se a quantidade de compra for zero
        }
        else if (compraPossivel) // If aninhado: Verifica se a compra é possível
        {
            Console.WriteLine("Venda Realizada"); // Mensagem se a compra for possível
        }
        else
        {
            Console.WriteLine("Compra não possível. Estoque insuficiente."); // Mensagem se a compra não for possível
        }
    }
        
        // -------------------- Switch case --------------------    
        class ExemploSwitch
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma letra ");
            string letra = Console.ReadLine();
            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal");
                    break;

                default:
                    Console.WriteLine("Consoante");
                    break;
            }
        }
    }

        // -------------------- Operador ou || --------------------    
      
    
}
