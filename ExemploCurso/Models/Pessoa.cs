using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploCurso.Models
{
    public class Pessoa
    {

        //Construtor
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {

            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }




        //Atributos
        private string _nome;
        private int _idade;




        //Propriedades
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"Meu nome é {this.Nome} {this.Sobrenome}";
        public int Idade
        {
            get => _idade;
            set
            {
                if (_idade < 0)
                {
                    throw new ExecutionEngineException("ERRO na declaracao da idade");
                }
            }
        }




        //Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {NomeCompleto.ToUpper()} e minha idade é {Idade}");
        }
    }
}