using Lista.Models;

List<string> listaString = new List<string>();// Declarando uma lista de strings

listaString.Add("SP"); // Adicionando itens na lista
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na lista: {listaString.Count} - capacidade: {listaString.Capacity}"); // Mostrando a quantidade de itens na lista
listaString.Add("SC"); // Adicionando mais um item na lista

Console.WriteLine($"Itens na lista: {listaString.Count} - capacidade: {listaString.Capacity}"); // Mostrando a quantidade de itens na lista
listaString.Remove("BA"); // Removendo o item "BA" da lista
Console.WriteLine($"Itens na lista: {listaString.Count} - capacidade: {listaString.Capacity}"); // Mostrando a quantidade de itens na lista

//Percorrendo a lista com FOR
Console.WriteLine("============== EXEMPLO 1: FOR ==============");
for (int i = 0; i < listaString.Count; i++) // listaString.Count retorna o número total de itens na lista
{
    Console.WriteLine($"📌 Posição {i} → Valor: {listaString[i]}");
}

//Percorrendo a lista com FOREACH
Console.WriteLine("\n============== EXEMPLO 2: FOREACH ==============");
int contador = 0; // Variável auxiliar para mostrar a posição
foreach (var item in listaString) // foreach percorre automaticamente todos os itens da lista
{
    Console.WriteLine($"📌 Posição {contador} → Valor: {item}");
    contador++;
}