/* Primeiros passos no arquivo Program.cs
1º Importar o namespace do arquivo pessoa.cs
2º Instanciar a classe Pessoa, Instanciar uma classe é criar um "objeto" baseado na classe.*/
using Introducao.Models;

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Silva"); //Instanciando a classe Pessoa
//p1.Nome = "João"; //Atribuindo valor à propriedade Nome
//p1.Sobrenome = "Silva"; //Atribuindo valor à propriedade Sobrenome
//p1.Idade = 30; //Atribuindo valor à propriedade Idade
//p1.Apresentar(); //Chamando o método Apresentar
/* Quando chamamos o objeto pessoa atravé do nome que atribuimos a ela
que no caso é p1, e digitamos o ponto (.) após o nome ira aparcer os
valores que podemos atribuir a ela representado por uma chave inglesa 
na frente, e o metodos são reprentado por um cubo */

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Oliveira"); //Instanciando a classe Pessoa
//p2.Nome = "Maria"; //Atribuindo valor à propriedade Nome
//p2.Sobrenome = "Oliveira"; //Atribuindo valor à propriedade
//p2.Idade = 25; //Atribuindo valor à propriedade Idade
//p2.Apresentar(); //Chamando o método Apresentar

Curso cursoDeCSharp = new Curso();
cursoDeCSharp.Nome = "Curso de C#";
cursoDeCSharp.Alunos = new List<Pessoa>();

cursoDeCSharp.AdicionarAluno(p1);
cursoDeCSharp.AdicionarAluno(p2);
cursoDeCSharp.ListarAlunos();