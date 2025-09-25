/* ================================================================
   📌 CLASSE CURSO
   Representa um curso que pode ter vários alunos (Pessoa)
   ================================================================ */

using System;
using System.Collections.Generic;

namespace Introducao.Models
{
    public class Curso
    {
        // ---------- PROPRIEDADES ----------
        public string Nome { get; set; } = string.Empty; // nome do curso
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>(); // lista de alunos

        // ---------- MÉTODOS ----------
        
        // Adiciona um aluno ao curso
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        // Remove um aluno (true se removeu, false se não achou)
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        // Lista todos os alunos no console
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome}:");

            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"Nº {i + 1}: {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

        // Retorna a quantidade de alunos matriculados
        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade; 
        }
    }
}
