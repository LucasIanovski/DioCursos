using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao.Models
{
    public class Pessoa
    {
        /*
        Criando propriedades da classe Pessoa.
        Usamos o atalho prop + enter para criar uma propriedade.
        O tipo tem que ser condizente com o que queremos armazenar.
        Se for um nome, por exemplo, o tipo tem que ser string.
        get e set significa duas ações que podemos fazer na propriedade
        get:ele está otendo o valor que nós armazenamos
        set: atribui um valor insere um valor */

        private string _nome; //Campo que
        public string Nome { get; set; } //Dessa forma aceita qualquer valor até nulo
        public int Idade { get; set; }

        /* Criando um método para a classe Pessoa.
        O método é uma ação que a classe pode realizar.
        */
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
