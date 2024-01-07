using exemplofundamentos.Models;

Pessoa p1 = new Pessoa("Daniel", "Cabral");
p1.Idade = 34;

Pessoa p2 = new Pessoa("Rafaela", "Araújo");
p2.Idade = 31;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();