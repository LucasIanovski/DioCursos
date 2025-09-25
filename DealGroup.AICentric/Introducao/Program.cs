/* Primeiros passos no arquivo Program.cs
1º Importar o namespace do arquivo pessoa.cs
2º Instanciar a classe Pessoa, Instanciar uma classe é criar um "objeto" baseado na classe.*/
using Introducao.Models;
using System.Globalization; //necessário para formatar valores monetários, muda a localizaçao do codigo

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //define a cultura padrão do sistema para pt-BR se colocarmos en-US o formato monetário será em dólar

// Fomrmatando tipos de datas
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

Instanciando a classe Pessoa
Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Silva");
p1.Nome = "João"; //Atribuindo valor à propriedade Nome
p1.Sobrenome = "Silva"; //Atribuindo valor à propriedade Sobrenome
p1.Idade = 30; //Atribuindo valor à propriedade Idade
p1.Apresentar(); //Chamando o método Apresentar
Quando chamamos o objeto pessoa através do nome que atribuimos a ela
que no caso é p1, e digitamos o ponto (.) após o nome irá aparecer os
valores que podemos atribuir a ela representado por uma chave inglesa 
na frente, e os métodos são representados por um cubo 

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Oliveira");
p2.Nome = "Maria";
p2.Sobrenome = "Oliveira";
p2.Idade = 25;
p2.Apresentar();

Criando curso e adicionando alunos
Curso cursoDeCSharp = new Curso();
cursoDeCSharp.Nome = "Curso de C#";
cursoDeCSharp.Alunos = new List<Pessoa>();

cursoDeCSharp.AdicionarAluno(p1);
cursoDeCSharp.AdicionarAluno(p2);
cursoDeCSharp.ListarAlunos();
*/