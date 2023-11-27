

using ExemploCurso.Models;

Pessoa p1 = new Pessoa(nome: "Herbert", sobrenome: "Emidio");
//p1.Nome ="Herbert";
//p1.Sobrenome="Emidio";
p1.Idade = 40;

Pessoa p2 = new Pessoa(nome: "Aline", sobrenome: "Cavalcante");
//p2.Nome="Aline";
//p2.Sobrenome="Cavalcante";
p2.Idade = 39;


Curso cursoDeIngles = new Curso("Ingles");
//cursoDeIngles.NomeCurso ="Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListaAluno();