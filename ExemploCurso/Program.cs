

using ExemploCurso.Models;

Pessoa p1 = new Pessoa();
p1.Nome ="Herbert";
p1.Idade =40;
p1.Sobrenome="Emidio";

Pessoa p2 = new Pessoa();
p2.Nome="Aline";
p2.Idade =39;
p2.Sobrenome="Cavalcante";


Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso ="Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListaAluno();