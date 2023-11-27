using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;



        public string Nome //propriedade com get e set
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


        public string Sobrenome { get; set; } // Propriedade  só para get



        // Criando uma propriedade para exibir o nome completo só com o get
        public string NomeCompleto => $"{this.Nome} {this.Sobrenome}".ToUpper();



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



        public void Apresentar() // métodos
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, eu tenho {this.Idade} anos.");
        }



    }
}