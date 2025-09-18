using MeuProjeto.Models;

// ======================================================
// 1️⃣ DECLARAÇÃO E ATRIBUIÇÃO DE VALORES AO ARRAY
// ======================================================

// Criando um array de inteiros com 3 posições (índices: 0, 1 e 2)
int[] arrayInteiros = new int[3];

// Atribuindo valores a cada posição do array
arrayInteiros[0] = 72; // Posição 0 recebe 72
arrayInteiros[1] = 64; // Posição 1 recebe 64
arrayInteiros[2] = 50; // Posição 2 recebe 50
// arrayInteiros[3] = 100; // ❌ ERRO: Índice 3 não existe, o array só tem 3 posições!

// ======================================================
// 2️⃣ PERCORRENDO O ARRAY COM FOR
// ======================================================
Console.WriteLine("============== EXEMPLO 1: FOR ==============");
Console.WriteLine("Percorrendo o array usando FOR\n");

for (int i = 0; i < arrayInteiros.Length; i++) // arrayInteiros.Length retorna o número total de posições
{
    Console.WriteLine($"📌 Posição {i} → Valor: {arrayInteiros[i]}");
}

// ======================================================
// 3️⃣ PERCORRENDO O ARRAY COM FOREACH
// ======================================================
Console.WriteLine("\n============== EXEMPLO 2: FOREACH ==============");
Console.WriteLine("Percorrendo o array usando FOREACH\n");

int contador = 0; // Variável auxiliar para mostrar a posição
foreach (var item in arrayInteiros) // foreach percorre automaticamente todos os itens do array
{
    Console.WriteLine($"📌 Posição {contador} → Valor: {item}");
    contador++;
}

// ======================================================
// 4️⃣ REDIMENSIONANDO O ARRAY (USANDO ARRAY.RESIZE)
// ======================================================
Console.WriteLine("\n============== EXEMPLO 3: REDIMENSIONANDO ==============");

// Observação: arrays são de tamanho fixo, mas podemos criar um NOVO array maior
// e copiar os valores do antigo usando Array.Resize()

System.Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// Explicação:
// - ref → passa o array por referência (permite alterar o tamanho de fato)
// - arrayInteiros.Length * 2 → define o novo tamanho (nesse caso, dobrando o tamanho atual)

// Adicionando valores nas novas posições para demonstrar que o array agora é maior
arrayInteiros[3] = 99;
arrayInteiros[4] = 88;
arrayInteiros[5] = 77;

Console.WriteLine($"Novo tamanho do array: {arrayInteiros.Length} posições\n");
Console.WriteLine("Percorrendo o array redimensionado usando FOR\n");

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"📌 Posição {i} → Valor: {arrayInteiros[i]}");
}

// ======================================================
// 5️⃣ COPIANDO O ARRAY PARA OUTRO ARRAY (USANDO ARRAY.COPY)
// ======================================================
Console.WriteLine("\n============== EXEMPLO 4: COPIANDO ARRAY ==============");

// Criando um novo array com o mesmo tamanho do array original
int[] arrayCopia = new int[arrayInteiros.Length];

// Usando System.Array.Copy para copiar os valores
System.Array.Copy(arrayInteiros, arrayCopia, arrayInteiros.Length);
// Explicação:
// - arrayInteiros → array de origem (de onde vamos copiar)
// - arrayCopia → array de destino (para onde vamos copiar)
// - arrayInteiros.Length → quantidade de elementos a copiar (neste caso, todos)

// Exibindo o conteúdo do array copiado
Console.WriteLine("Conteúdo do array copiado:\n");
for (int i = 0; i < arrayCopia.Length; i++)
{
    Console.WriteLine($"📄 Cópia - Posição {i} → Valor: {arrayCopia[i]}");
}
