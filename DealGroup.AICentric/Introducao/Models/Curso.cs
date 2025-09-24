using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
             
        }

         public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome}:");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            
            return quantidade; // todo metodo que tem retorno tem que ter a palvara return
        }
    }
}