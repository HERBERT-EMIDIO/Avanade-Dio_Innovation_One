namespace dotNet.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade{get;  set;}

        public void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome} e minha idade é {Idade} anos");
        }
    }
}