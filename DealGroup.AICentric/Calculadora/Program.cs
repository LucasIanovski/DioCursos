using CalculadoraApp.Models; // Importando o namespace da pasta Models

// -------------------- Instanciando a Classe Calculadora --------------------
Calculadora calc = new Calculadora(); // Criando um novo objeto da classe Calculadora

// -------------------- Chamando os Métodos --------------------
calc.Somar(10, 30);           // Soma: 10 + 30
calc.Subtrair(10, 50);        // Subtração: 10 - 50
calc.Multiplicar(15, 45);     // Multiplicação: 15 * 45
calc.Dividir(2, 2);           // Divisão: 2 / 2
calc.Potencia(3, 3);          // Potência: 3³
calc.Seno(30);                // Seno de 30°
calc.Coseno(30);              // Cosseno de 30°
calc.Tangente(30);            // Tangente de 30°
calc.RaizQuadrda(9);          // Raiz quadrada de 9

// -------------------- Incremento e Decremento --------------------

// Declarando a variável número
int numero = 10;
Console.WriteLine("Valor inicial: " + numero); // Exibe 10

// --------- Incremento ---------

// Forma 1: Pré-incremento (++numero)
// Primeiro incrementa, depois exibe
Console.WriteLine("Incrementando com ++numero:");
Console.WriteLine(++numero); // Exibe 11

// Forma 2: Atribuição direta (numero = numero + 1)
numero = numero + 1; // Agora número = 12
Console.WriteLine("Incrementando com numero = numero + 1:");
Console.WriteLine(numero); // Exibe 12

// --------- Decremento ---------

// Forma 1: Pós-decremento (numero--)
// Primeiro exibe, depois decrementa
Console.WriteLine("Decrementando com numero--:");
Console.WriteLine(numero--); // Exibe 12, depois decrementa para 11

// Valor atual após pós-decremento
Console.WriteLine("Valor atual depois de numero--:");
Console.WriteLine(numero); // Exibe 11

// Forma 2: Pré-decremento (--numero)
// Primeiro decrementa, depois exibe
Console.WriteLine("Decrementando com --numero:");
Console.WriteLine(--numero); // Exibe 10

// Forma 3: Atribuição direta (numero = numero - 1)
numero = numero - 1; // Agora número = 9
Console.WriteLine("Decrementando com numero = numero - 1:");
Console.WriteLine(numero); // Exibe 9

/* 
Resumo:
- ++numero: incrementa antes de usar
- numero++: usa o valor atual e incrementa depois
- --numero: decrementa antes de usar
- numero--: usa o valor atual e decrementa depois
- numero = numero + 1 ou - 1: forma tradicional de modificar manualmente
*/
