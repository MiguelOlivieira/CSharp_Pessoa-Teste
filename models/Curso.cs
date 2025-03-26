using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ExemploExplorando.models
{
    public class Curso
    {
        public  string Nome { get; set; }

        public  List<Pessoa> Alunos { get; set; }

        public  void AdicionarAlunos(Pessoa aluno) //Pessoa = tipo
        {
             Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

            //metodo Remove retorna um bool, então, definimos bool como tipo em nosso método removerAluno
        public bool RemoverAluno(Pessoa aluno)
        {
           return Alunos.Remove(aluno); //true //false
        }

        public void ListarAlunos()
        {
                Console.WriteLine($"Alunos do curso de: {Nome}\n\n");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
        
    }
}