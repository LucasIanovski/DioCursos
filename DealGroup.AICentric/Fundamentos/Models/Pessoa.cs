using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models // Definindo o namespace do projeto podemos definir o nome que quisermos
{
    public class Pessoa //Nome de classe deve ser sempre com a primeira letra maiúscula e no singular (PascalCase), diferente de java a classe nao precisa ter o mesmo nome do arquivo, mas é uma boa prática de programação
    { // Criando a classe Pessoa
        // Definindo atributos da classe Pessoa
        public string? Nome { get; set; } // Nome é texto, então recebe string, get e set são métodos de acesso, get para ler o valor e set para atribuir um valor
        public int Idade { get; set; } // Idade é número inteiro, então recebe int
        
        public string? NomeRepLegal { get; set; } // Nome do representante legal, que pode ser pai, mãe ou responsável, dessa forma está ilegivel pois não pode conter abrevisção
        // Criando um método (ação que a classe Pessoa pode fazer)
        public void Apresentar() // Método agora é void e não retorna nada
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade} anos."); // Imprime a mensagem e vai para a próxima linha, sem quebra linha fica console.Write, o sifrão $ antes de uma string, serve para que o C# permite que você coloque expressões dentro das chaves {} na string.
            //Console é uma classe, WriteLine é um método da classe Console e o que a indentifica o método é o parênteses () que serve para passar parâmetros para o método.
            // Podemos dar quebra de linha usando o /n ou o Environment.NewLine que é mais recomendado, pois funciona em qualquer sistema operacional ex:Console.WriteLine($"Olá, meu nome é {Nome} /n e minha idade é {Idade} anos.");
            // Podemos usar o @ antes de uma string para que o C# interprete a string exatamente como está escrita, inclusive com quebras de linha e tabulações, sem precisar usar o \n ou \t e forçar o uso de palavras reservadas como console, por exemplo.
        }
    } // Fim da classe Pessoa
}
