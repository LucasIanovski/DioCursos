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
        get e set significa duas ações que podemos fazer na propriedade, pra ser propriedade tem que ter ou get ou set.
        get:ele está otendo o valor que nós armazenamos
        set: atribui um valor insere um valor
        public int string nome { get; set;} Dessa forma aceita qualquer valor até nulo
        abaixo veremos como fazer da maneira correta */

        public Pessoa() //Construtor padrão da classe Pessoa, é um método especial que é executado quando a classe é instanciada
        {
            // Inicializando valores padrão para evitar null
            _nome = string.Empty;
            Sobrenome = string.Empty;
            _idade = 0;
        }

        public Pessoa(string nome, string sobrenome) //Construtor da classe Pessoa, é um método especial que é executado quando a classe é instanciada
        {
            // Ao instanciar já atribuimos valores para evitar null
            Nome = nome;
            Sobrenome = sobrenome;
            _idade = 0;
        }
            
        private string _nome = string.Empty; //Campo que vai armazenar o nome, quando está privado somente a classe pessoa pode acessar, o arquivo Program.cs não consegue acessar
        private int _idade; //Campo que vai armazenar a idade

        public string Nome
        {
            get
            {
                return _nome.ToUpper(); //retorna o nome em maiúsculo podemos deixar o codigo menor assim: get => _nome.ToUpper();
            }
            set
            {
                //Validação para não aceitar nomes vazios ou nulos
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio ou nulo.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; } = string.Empty; //inicializado para evitar null

        public string NomeCompleto => $"{Nome} {Sobrenome}"; //Propriedade somente de leitura, não tem o set, só o get

        public int Idade
        {
            get => _idade; //retorna a idade
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
                _idade = value;
            }
        }

        /* Criando um método para a classe Pessoa.
        O método é uma ação que a classe pode realizar.
        */
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.".ToUpper());
        }

    }
}
 