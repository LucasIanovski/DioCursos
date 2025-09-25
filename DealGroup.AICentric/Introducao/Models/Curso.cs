using System;
using System.Collections.Generic;

namespace Introducao.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        // Método para adicionar um aluno ao curso
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        // Método para remover aluno
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        // Método para listar alunos
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome}:");

            for (int i = 0; i < Alunos.Count; i++) // corrigido
            {
                string texto = $"Nº {i + 1}: {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

        // Método para obter quantidade de alunos
        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade; // todo método que tem retorno precisa de return
        }
    }
}
