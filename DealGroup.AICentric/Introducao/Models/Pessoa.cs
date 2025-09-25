/* ================================================================
   📌 CLASSE PESSOA
   Representa uma pessoa com nome, sobrenome e idade
   ================================================================ */

using System;

namespace Introducao.Models
{
    public class Pessoa
    {
        // ---------- CAMPOS PRIVADOS ----------
        // Campos = variáveis internas da classe
        private string _nome;   // vai guardar o nome
        private int _idade;     // vai guardar a idade

        // ---------- CONSTRUTORES ----------
        // Construtor padrão (sem parâmetros)
        public Pessoa()
        {
            _nome = string.Empty;    // evita null
            Sobrenome = string.Empty;
            _idade = 0;
        }

        // Construtor que já recebe nome e sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;                        // usa a validação do set
            Sobrenome = sobrenome ?? string.Empty; 
            _idade = 0;
        }

        // ---------- PROPRIEDADES ----------
        public string Nome
        {
            get => _nome.ToUpper(); // devolve sempre em maiúsculo
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio ou nulo.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; } = string.Empty;

        // Propriedade só de leitura (não tem set)
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
                _idade = value;
            }
        }

        // ---------- MÉTODOS ----------
        // Método = ação que a classe sabe fazer
        public void Apresentar()
        {
            Console.WriteLine(
                $"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos."
                .ToUpper()
            );
        }
    }
}
