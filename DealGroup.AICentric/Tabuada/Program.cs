using Tabuada.Models; // Importa o namespace Tabuada.Models (caso você use alguma classe futura aqui)

// Criando uma tabuada para o número 5
int numero = 5; // Armazena o número da tabuada que será gerada

// ------------------ Tabuada usando o laço de repetição FOR ------------------

//Console.WriteLine($"{numero} x 1 = {numero * 1}"); 
// {numero} pega o valor da variável 'numero' e {numero * 1} faz a multiplicação
// Exemplo direto, mas vamos usar laços para repetir automaticamente

// Fazendo com laço de repetição com for
for (int i = 0; i <= 10; i++) // Começa em 0 e vai até 10, incrementando de 1 em 1
{
    // {i} pega o valor da variável 'i' e {numero * i} faz a multiplicação
    Console.WriteLine($"{numero} x {i} = {numero * i}"); 
}

// ------------------ Tabuada usando o laço de repetição WHILE ------------------

// O laço while precisa de um "auxiliar" (variável de controle) fora dele
// Neste caso, a variável 'multiplicador' será nosso auxiliar

int multiplicador = 0; // Inicializa o multiplicador como 0

// Enquanto o multiplicador for menor ou igual a 10, o bloco será executado
while (multiplicador <= 10) // Condição de parada do while
{
    // Imprime a tabuada do número fixo 'numero' com o valor atual do multiplicador
    Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");

    // Incrementa o multiplicador para não criar um loop infinito
    multiplicador++;

    // Interrompendo fluxo de execução com if
    if (multiplicador == 6) // Se o multiplicador chegar a 6
    {
        break; // Interrompe o laço while
    }
}

// ------------------ Laço de repetição com Do While ------------------

// O do while sempre executa pelo menos uma vez, mesmo que a condição seja falsa no início
// Usado para somar números digitados até que o usuário digite 0

int soma = 0; // Variável para armazenar a soma dos números
int entradaUsuario = 0; // Renomeada para evitar conflito com a variável 'numero'

do
{
    Console.Write("Digite um número (0 para sair): ");
    entradaUsuario = Convert.ToInt32(Console.ReadLine()); // Lê o número digitado pelo usuário
    soma += entradaUsuario; // Adiciona o número à soma total
} while (entradaUsuario != 0); // Continua enquanto o número digitado for diferente de 0

Console.WriteLine($"Soma total dos números digitados: {soma}"); // Mostra a soma final

// ------------------ Explicações Adicionais ------------------

/*
    O simbolo de $ antes das aspas permite interpolação de strings, ou seja, inserir variáveis diretamente na string.

    ✔ O FOR é ideal quando você já sabe quantas vezes o loop vai repetir.
    ✔ O WHILE é útil quando você precisa de mais controle ou quando a quantidade de repetições depende de outra lógica.
    ✔ O DO WHILE garante que o código dentro dele será executado pelo menos uma vez, mesmo que a condição seja falsa.

    FOR: a variável de controle (i) é declarada dentro do laço.
    WHILE: a variável de controle (multiplicador) é declarada fora e precisa ser incrementada manualmente.

    ⚠️ Importante: se esquecer de incrementar a variável no while, o programa entra em loop infinito.
    ❌ Também não é permitido declarar duas variáveis com o mesmo nome no mesmo escopo.
*/
