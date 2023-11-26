// 01. IMPORTANCIA DO NAMESPACE
// 02. CLASSE E CRIAÇÃO DE UM OBJETO - USANDO O PONTO PARA CHAMAR 
// 03. USANDO O $ 
// 04. USANDO O /n PARA QUEBRAR LINHAS 
// 05. CASES = PADRÃO DE ESCRITA; cammelCase(C#) - PascalCase(C#) - snake_case - spinal-case
// 06. PADRAO DE NOMES = NOME DE ARQUIVO = NOME DE CLASSE 
// 07. USANDO VARIÁVES = SINTAXE E TIPOS DE DADOS
// 08. USANDO O TIPO = DATE TIME.NOW 
// 09. COMENTARIOS NO COD = SELECIONA O COD E : CTRL + K + C
// 10. CONVERTENDO -(de um tipo para outro tipo)- COM a CLASSE CONVERT E O MÉTODO TO: int a = Convert.toInt32("s");
// 11. COVERTENDO COM PARSE = CONVERTE DE UM TIPO PARA OUTRO = CAST
// 12. DIFERENÇA ENTRE CONVERT E PARSE = TRATAMENTO DE (NULL) COM CONVERT(RETORNA ZERO) NÃO DARÁ ERRO, JÁ O PARSE NÃO ACEITA NULL.
// 13. CLASSE OBJECT = todas as classes herdarem de object
// 14. FAZENDO UM CAST =  1. CAST IMPLICITO DE INT P/ DOUBLE(MOTIVO: MAIOR QUE UM INT, LOGO SERÁ IMPLICITO).
// 15. CONVERSÃO SEGURA COM O TRYPARSE  
// 16. OPERADORES CONDICIONAIS 
// 17. IF ANINHADO = MAIS DE UM CAMINHO OU VARIAS OPÇÕES POSSIVEIS
// 18. SWITCH CASE
// 19. LAÇO DE REPETICAO = FOR - WHILE - DO WHILE 
// 20. ARRAY = INT[] ARRAY = NEW INT[4]; OR INT[] ARRAY = NEW INT[]{42,75,74,61}; OR STRING[] NOMES = {"jan, "fev};
// 21. FOREACH = SEM CONTADOR => FOREACH(INT IN ARRAY){CONSOLE.WRITELINE(INT)} : USAR QUANDO NÃO NECESSITA DE UM CONTADOR
// 22. MUDANDO O TAMANHO DO ARREY =>COM A CLASS=> ARRAY.RESIZE(REF NOMEDOARRAYPARAAUMENTAR, NOVOTAMANHO.LENGTH * 2); =>obs: cria uma copia e aumenta o tamanho 
// 23. LISTAS = É UM ARRAY MAIS COMPLETO => "MELHORADO" = NÃO NECESSITA DE UMA DECLARAÇÃO DE CAPACIDADE/TAMANHO => List<string> nome =new List<string>();




using System.Diagnostics;
using dotNet.models;
// dotNet.models.Pessoa p = new dotNet.models.Pessoa();


// Pessoa eu = new Pessoa();

// eu.Nome ="Herbert";
// eu.Idade = 40;
// eu.Apresentar();


/*
==============================INICIO===============================

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual); // 24/11/2023 11:00:54

// ADD DIAS
DateTime adicionarDias = DateTime.Now.AddDays(5);
Console.WriteLine(adicionarDias); // 29/11/2023 11:02:56
Console.WriteLine(adicionarDias.ToString("dd/MM/yyyy")); // 29/11/2023

//CONVERTER PARA OUTRO TIPO
Console.WriteLine("==============CONVERT==================");
int a = Convert.ToInt32("5");
Console.WriteLine(a);

//CONVERTER STRING
Console.WriteLine("=============TOSTRING=================");
int inteiro = 115;
string valueString = inteiro.ToString();
Console.WriteLine(valueString); //115

//TRYPARSE
Console.WriteLine("==============TRYPARSE===============");
string idadeString = "40-";
//int teste =0;

int.TryParse(idadeString, out int teste);//tenta conv para int o idade se nao conv retorna o teste

Console.WriteLine("conversão realizada! " + teste); //0 por causa do - depois do 40


//CONDICIONAIS
Console.WriteLine("==============IF===============");
int quantEmEstoque = 10;
int compraUsuario = 9;
Console.WriteLine($"Quantidade em estoque: {quantEmEstoque}\nQuantidade de vendas: {compraUsuario}");
if (quantEmEstoque >= compraUsuario)
{
    Console.WriteLine("Estoque maior que quantidade de vendas!");
}
else
{
    Console.WriteLine("Vendas maior que quantidade de estoque!");
}

//SWITCH CASE
Console.WriteLine("=============SWITCH=======================");
Console.WriteLine("Digite uma letra do alfabeto:");
string letra = Console.ReadLine();


if (letra == "a")
{
    Console.WriteLine("vogal");
}
else if (letra == "e")
{
    Console.WriteLine("vogal");
}
else if (letra == "i")
{
    Console.WriteLine("vogal");
}
else if (letra == "o")
{
    Console.WriteLine("vogal");
}
else if (letra == "u")
{
    Console.WriteLine("vogal");
}
else
{
    Console.WriteLine("É uma Consoante");
}

// outra forma de fazer
Console.WriteLine("============IF================");
if (letra == "a" || letra == "b" || letra == "c")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Consoante");
}


Console.WriteLine("============Swirch================");
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal!!");
        break;

    default:
        Console.WriteLine("Não é vogal!");
        break;
}


Console.WriteLine("=============CALCULADORA================");

Calculadora calc = new Calculadora();
calc.Somar(10, 2);
calc.Subtrair(10, 2);
calc.Resto(5, 2);
calc.Dividir(10, 2);
calc.Multiplicar(10, 2);

// Potencia (^)
Console.WriteLine();
calc.Potencia(3, 3);

// Seno | Coseno | Tangente
Console.WriteLine();
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

// Raiz
Console.WriteLine();
calc.Raiz(36);

//Laco for
Console.WriteLine();
Console.WriteLine("============== Usando FOR =====================");
int numero = 10;

for (int i = 0; i <= numero; i++)
{
    Console.WriteLine($"{numero} X {i} = {numero * i}");
}


//laço WHILE
Console.WriteLine();
Console.WriteLine("============== Usando WHILE =====================");

int condicao = 10;
int num = 0;
while (num <= condicao)
{
    Console.WriteLine($"{condicao} X {num} = {condicao * num}");
    num++;
}

Console.WriteLine();
Console.WriteLine("============== Usando O BREAK NO WHILE =====================");

int condi = 5;
int nu = 0;
while (nu <= condi)
{
    Console.WriteLine($"{condi} X {nu} = {condi * nu}");
    nu++;
    if (nu == 7)
    {
        break;
    }
}

Console.WriteLine();
Console.WriteLine("============== Usando; DO WHILE =====================");

int valor = 7;
int operador = 0;
do
{
    Console.WriteLine($"{valor} X {operador} = {valor * operador}");
    operador++;
} while (operador <= 10);


Console.WriteLine();
Console.WriteLine("============== CALCULADORA =====================");

string opcao;
bool v = true;

while (v)
{
    Console.WriteLine("========= Digite a sua opção: =============");
    Console.WriteLine("1 - Cadastrar clientes");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("============================================");
    Console.WriteLine();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("1 - Cadastrar clientes");
            Console.WriteLine();
            break;
        case "2":
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine();
            break;
        case "3":
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine();
            break;
        case "4":
            Console.WriteLine("4 - Encerrar");
            Console.WriteLine();
            //Environment.Exit(0);
            v = false;
            break;
        default:
            Console.WriteLine("Essa Opção não é válida");
            Console.WriteLine();
            break;
    }

}

// ARRAY
Console.WriteLine();
Console.WriteLine("============== ARRAY ========== ===========");
int[] arreyNumeros = new int[4];
int[] arreyNumeroLancados = new int[] { 12, 45, 72, 65 };
string[] nomes = { "jan", "fev" };


arreyNumeros[0] = 280783;
Console.WriteLine(arreyNumeros[0]);//buscar

//PERCORRER O ARREY COM O FOR
arreyNumeros[0] = 1000;
arreyNumeros[1] = 2001;
arreyNumeros[2] = 3002;
arreyNumeros[3] = 4003;
for (int i = 0; i < arreyNumeros.Length; i++)
{
    Console.WriteLine($"valor na posição:{i} => {arreyNumeros[i]} ");
}

//PERCORRER O ARREY COM O FOREACH => não há contador 'i' logo, nao posso imprimi-lo.. tem que criar um com cont++
Console.WriteLine();
int cont = 0;
foreach (int perrcorrerArrey in arreyNumeroLancados)
{
    cont++;
    Console.WriteLine($"A posição {cont} => {perrcorrerArrey}");
}

Console.WriteLine();
Console.WriteLine("============== MUDANDO TAMANHO DO ARRAY com a class Array.Resize =====================");
Array.Resize(ref arreyNumeros, arreyNumeros.Length * 2);// agora o array tem 8 posições


Console.WriteLine();
Console.WriteLine("============== Copiando um array => Array.copy=====================");

int[] array1 = new int[2]; // com 2 posições
array1[0] = 21;
array1[1] = 22;
//Aumentando com Array.resize(ref)
//Array.Resize(ref array1, array1.Length * 6); // aumentei para 6 posições

//Aumnentando de outra forma
int[] arrey1Dobrado = new int[array1.Length * 2]; // aumentei pra 4 posições


//Array.copy => para copiar
Array.Copy(array1, arrey1Dobrado, array1.Length); // copia o... para... com a capacidade de...

arrey1Dobrado[2] = 23;
arrey1Dobrado[3] = 24;

int contador2 = 0;
foreach (int recebentoArrayDobrado in arrey1Dobrado)
{
    Console.WriteLine($"posição numero: {contador2}=> recebendo: {recebentoArrayDobrado}");
    contador2++;
    Console.WriteLine("=====");
}


======================================================================================
*/

Console.WriteLine();
Console.WriteLine("============== LIST =====================");
//não necessita de informar/declarar sua capacidade=> ela já possui um array interno

List<string> listString = new List<string>();

//adicionar com : .add
listString.Add("Herbert");
listString.Add("Aline");

//percorrer com o for
Console.WriteLine();
Console.WriteLine("============== USANDO O FOR =====================");
for (int contador = 0; contador < listString.Count; contador++)
{
    Console.WriteLine($"Posição número: {contador} => {listString[contador]}");

}

//percorrendo uma lista com foreach

Console.WriteLine("============== USANDO O FOREACH =====================");
int contagem =0;
foreach(string contadorLista in listString){
    Console.WriteLine($"Posição número: {contagem} => {listString[contagem]}");
    contagem++;

}