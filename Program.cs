// See https://aka.ms/new-console-template for more information
using ExemploExplorando.models;



Pessoa pessoa1= new Pessoa();

pessoa1.Nome = "Lucas";
pessoa1.Sobrenome = "Santos";
;

Pessoa pessoa2 = new Pessoa();

pessoa2.Nome = "Eduardo";
pessoa2.Sobrenome = "Araujo";

Curso geografiaCurso = new Curso();
geografiaCurso.Nome = "Geografia";
geografiaCurso.Alunos = new List<Pessoa>();

geografiaCurso.AdicionarAlunos(pessoa1);
geografiaCurso.AdicionarAlunos(pessoa2);
//geografiaCurso.RemoverAluno(pessoa1);
geografiaCurso.ListarAlunos();
