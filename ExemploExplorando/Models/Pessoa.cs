using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;

        private int _idade;

        public string Nome
        {

            //uma forma de escrever com ayron =>
            //get => _nome.ToUpper();

            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }
        }


        public int Idade
        {
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade inválida!");
                }

                _idade = value;
            }
        }



        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {this.Nome}, eu tenho {this.Idade} anos.");
        }
    }
}