using Fundamentos.Models; // Importando o namespace Fundamentos.Models para usar a classe Pessoa
// Precisamos fazer a importação do namespace onde a classe está para poder usá-la.
// Em projetos maiores, podemos ter várias classes em vários namespaces diferentes, até com o mesmo nome.


// Toda ação em C# começa pelo método Main. Aqui é onde o programa começa a executar.
// Variáveis são declaradas dentro deste método ou em outras classes, e servem para armazenar dados.
// No C#, variáveis não podem conter espaços, acentos ou caracteres especiais, apenas o _ (underline).
// Exemplo: nome_completo é válido, mas nome completo ou nome@completo não são.

//Pessoa pessoa1 = new Pessoa(); // Criando uma nova instância (objeto) da classe Pessoa

// Atribuindo valores aos atributos do objeto pessoa1
//pessoa1.Nome = "Lucas"; // Atribuindo o valor "Lucas" ao atributo Nome da pessoa1
//pessoa1.Idade = 25; // Atribuindo o valor 25 ao atributo Idade da pessoa1

// Chamando o método Apresentar do objeto pessoa1
//pessoa1.Apresentar(); // O método Apresentar imprime uma mensagem no console

// Explicações sobre o código:
// - O ponto (.) é usado para acessar os membros (atributos e métodos) de uma classe ou objeto.
// - O C# é case-sensitive, ou seja, ele diferencia maiúsculas de minúsculas. Então, "Nome" é diferente de "nome".
// - O ponto e vírgula (;) é usado para finalizar uma instrução em C#.
// - Quando declaramos variáveis, utilizamos o estilo camelCase, ou seja, a primeira letra é minúscula e as palavras subsequentes começam com letras maiúsculas. Exemplo: nomeCompleto.

// ------------ Exemplos de declaração de variáveis em C# ------------
// string apresentacao = "olá, seja bem, vindo ao curso de C#"; // Declarando uma variável do tipo string (texto) chamada apresentacao e atribuindo um valor a ela
// int quantidade = 1; // Declarando uma variável do tipo int (número inteiro)
// double altura = 1.80; // Declarando uma variável do tipo double (número com casas decimais)
// decimal preco = 1.80M; // Declarando uma variável do tipo decimal (número com casas decimais) e o M no final indica que é um decimal
// bool condicao = true; // Declarando uma variável do tipo bool (booleano) que pode ser true ou false

// Console.WriteLine(apresentacao); // Imprimindo o valor da variável apresentacao no console
// Console.WriteLine("Quantidade: " + quantidade); // Imprimindo o valor da variável quantidade no console
// Console.WriteLine("Altura: " + altura.ToString("0.00")); // Imprimindo o valor da variável altura no console, o .ToString("0.00")) formata o número para ter 2 casas decimais, como a variável é do tipo double, que pode ter várias casas decimais, usamos o ToString para formatar a saída
// Console.WriteLine("Preço: " + preco); // Imprimindo o valor da variável preco no console
// Console.WriteLine("Condição: " + condicao); // Imprimindo o valor da variável condicao no console

//----------- Representação de datas em C# -----------
DateTime dataAtual = DateTime.Now.AddDays(5); // Declarando uma variável do tipo DateTime (data e hora) e atribuindo a data e hora atual a ela ou seja esta pegando a data e hora do sistema
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // Imprimindo o valor da variável dataAtual no console

