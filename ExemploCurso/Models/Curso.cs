using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploCurso.Models
{
    public class Curso
    {


        //propriedades
        public string NomeCurso { get; set; }

        //Propriedade do tipo lista/coleção com List<>
        public List<Pessoa> Alunos { get; set; }



        // Métodos com : tipo (void = vazio => não retora ou não te mostra/ não tras um resultado) no void ele só add ou imprime.
        // Métodos com: Nome legÍvel.
        // Métodos com: Parâmetros ou Argumentos. 
        public void AdicionarAluno(Pessoa alunoNovo)
        {
            Alunos.Add(alunoNovo);

        }


        public bool RemoverAluno(Pessoa removerAluno)
        {

            return Alunos.Remove(removerAluno);
        }




        public void ListaAluno()
        {
            int contador = 0;
            foreach (Pessoa alunos in Alunos)
            {
                contador++;
                Console.WriteLine($"Aluno {contador}:  {alunos.NomeCompletp}");
            }
        }




        public int ObterAlunosMatriculados()
        {
            //int quant = Alunos.Count;
            //return qaunt;

            int contador = 0;
            for (int i = 0; i < Alunos.Count; i++)
            {
                contador++;
            }

            return contador;
        }
    }
}