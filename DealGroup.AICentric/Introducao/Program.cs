using Introducao.Models;
using System.Globalization;
using System.Collections.Generic; // necessário para usar Queue

// ==============================================================
// Configuração de cultura para formatação monetária e datas
// ==============================================================
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); 

// ==============================================================
// 📂 Exemplo de leitura de arquivo com tratamento de exceções
// ==============================================================
try
{
    // Aqui ele abre o arquivo que tá na pasta "Arquivos" e pega todas as linhas
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    // Percorre cada linha do arquivo
    foreach (string linha in linhas) 
    {
        Console.WriteLine(linha); // Mostra cada linha no console
    }
}
catch (FileNotFoundException ex) 
{
    Console.WriteLine($"⚠️ Arquivo não encontrado! Detalhes: {ex.Message}");
}
catch (DirectoryNotFoundException ex) 
{
    Console.WriteLine($"⚠️ Diretório não encontrado! Detalhes: {ex.Message}");
}
catch (UnauthorizedAccessException ex) 
{
    Console.WriteLine($"⚠️ Sem permissão para acessar o arquivo! Detalhes: {ex.Message}");
}
catch (IOException ex) 
{
    Console.WriteLine($"⚠️ Erro de I/O (entrada/saída)! Detalhes: {ex.Message}");
}
catch (Exception ex) 
{
    Console.WriteLine($"⚠️ Ocorreu um erro inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("Finalizando a leitura do arquivo.\n");
}











/* Fomrmatando tipos de datas
string dataString = "2023-06-15 14:30"; // formato ISO 8601
bool sucesso = DateTime.TryPardeExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);// tenta converter a string para DateTime
if
(!sucesso) // ! significa "não" operador de negação
{
    Console.WriteLine("Data inválida");
    return; // sai do programa se a data for inválida
}
Console.WriteLine(dataConvertida); // imprime a data convertida
DateTime data = DateTime.Now; //pega a data e hora atual do sistema podemos usaro o DateTime.pase("2023-06-15 14:30") para converter uma string em data
Console.WriteLine(data); // imprime a data e hora atual do sistema
//Mostrando apenas a data
Console.WriteLine(data.ToString("d")); // formata a data para o formato curto dd/MM/aaaa
//Moostrando apenas a hora
Console.WriteLine(data.ToString("T")); // formata a hora para o formato longo HH:mm:ss
*/





/*formatando valores monetários
decimal valorMonetario = 82.50;
//Console.WriteLine($"Valor monetário: {valorMonetario:C}"); // :C formata como moeda o C maiúsculo formata conforme a cultura do sistema, o c minúsculo formata como moeda mas em dólar
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-Us"))); // formata como moeda em dólar mesmo o sistema estando em pt-BR
Console.WriteLine(valorMonetario.ToString("C8")); // formata como moeda com 8 casas decimais podemos troca o c po r n para número, p para porcentagem etc

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P")); // formata como porcentagem

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##")); // formata o número conforme o padrão definido separado por hífen
*/




/* 
Exemplo simples de concatenação
int numero1 = 10; // int de verdade, não string
int numero2 = 20;
int resultado = numero1 + numero2; // soma
Console.WriteLine(resultado); // 30
*/


// ==============================================================
// 📌 Instanciando objetos Pessoa
// ==============================================================
Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Silva");
p1.Nome = "João"; 
p1.Sobrenome = "Silva"; 
p1.Idade = 30; 
p1.Apresentar(); //Chamando o método Apresentar

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Oliveira");
p2.Nome = "Maria";
p2.Sobrenome = "Oliveira";
p2.Idade = 25;
p2.Apresentar();

// ==============================================================
// 📌 Criando curso e adicionando alunos
// ==============================================================
Curso cursoDeCSharp = new Curso();
cursoDeCSharp.Nome = "Curso de C#";
cursoDeCSharp.Alunos = new List<Pessoa>();

cursoDeCSharp.AdicionarAluno(p1);
cursoDeCSharp.AdicionarAluno(p2);
cursoDeCSharp.ListarAlunos();


// ==============================================================
// ⚡ Exemplo de tratamento de exceção com idade
// ==============================================================
try
{
    Pessoa p3 = new Pessoa("Lucas", "Ianovski");
    p3.Idade = -5; // Isso vai disparar exceção
}
catch (ArgumentException ex)
{
    Console.WriteLine($"⚠️ Ocorreu um erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Finalizando o exemplo de tratamento de exceções.\n");
}


// ==============================================================
// 📌 Exemplo de fila (Queue)
// ==============================================================
Queue<string> fila = new Queue<string>();

// Adicionando elementos na fila (Enqueue)
fila.Enqueue("Lucas");
fila.Enqueue("Maria");
fila.Enqueue("João");

Console.WriteLine("\nFila atual:");
foreach (string pessoa in fila)
{
    Console.WriteLine(pessoa);
}

// Tirando o primeiro da fila (Dequeue)
string atendido = fila.Dequeue();
Console.WriteLine($"\nAtendido: {atendido}");

Console.WriteLine("Fila depois do atendimento:");
foreach (string pessoa in fila)
{
    Console.WriteLine(pessoa);
}

// Só espiar quem é o próximo sem tirar
Console.WriteLine($"\nPróximo da fila: {fila.Peek()}");

// Tamanho da fila
Console.WriteLine($"\nTamanho da fila: {fila.Count}");

// Evitando erro ao remover de fila vazia
if (fila.Count > 0)
{
    Console.WriteLine($"Dequeue seguro: {fila.Dequeue()}");
}
else
{
    Console.WriteLine("A fila está vazia, não dá pra atender ninguém!");
}
