

/* QUESTÃO 1
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.WriteLine($"{element}, ");
}


//QUESTÃO 2

Console.WriteLine("Digite um número inteiro: ");
var num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O numero digitado foi: " + num);


//QUESTÃO 3

int[] arrInteiro = new int[] {11, 22, 3, 4, 5};
 for (int i=1; i<arrInteiro.Length; i++)
{
    if(arrInteiro[i -1] > arrInteiro[i])
    {
        Console.WriteLine(false);
    }
    else { Console.WriteLine(true); }
    
}


//QUESTÃO 4

int x = 5;
int y = 18;
int z = 7;

for (int i = 0; i <= 3; i++)
{
    if ((x -1) > 2)
    {
        y = y + 1;
    }
    else
    {
        y = y - 1;
    }
    z = z +  x + y;
    x--;
}

Console.WriteLine(x + " " + y + " " + z);

*/
//QUESTÃO 5
var palavra = "palavra";
string output = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    output += palavra[i];
}
Console.WriteLine(output);

/*
QUESTÃO 6 --- MUITO ESTRANHO, MAS PRINTA 2357 VAAAARIAS VEZES

int[] matriz1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] matriz2 = new int[] { 2, 3, 5, 7 };

string output = "";
foreach (int itemMatriz1 in matriz1)
{
    foreach (int itemMatriz2 in matriz2)
    {
        output += itemMatriz2;
    }
}
Console.WriteLine(output);

QUESTÃO 7
DIFERENÇA ENTRE DO WHILE E WHILE
do while irá executar no mínimo uma vez,
enquanto o while irá executar somente se a condição for verdadeira


QUESTÃO 8, RIDICULA POIS JÁ SABIA A RESPOSTA MAS QUIS ESCREVER
AI DESCOBRI QUE NÃO LEMBRAVA PRINTAR UMA POSIÇÃO DO ARRAY
LEMBREI, É ASSIM COMO DEMONSTRADO ABAIXO:

int[] vetorInteiro = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine(vetorInteiro[2]);


QUESTÃO 9 - EASY
int a = 1;
int b = 1;
bool output = a + b == 2;
Console.WriteLine(output);


QUESTÃO 10 - OK

decimal a = 15;
decimal b = 7;
decimal c = 8;
decimal d = 11;

a = b;
b = c;
c = d;
d = a;

b = c + a;
c = d - b;
d = d + a * 2 - b;
a = b / 2;

Console.WriteLine(a + " " + b + " " + c + " " + d);

QUESTÃO 11

for (int i = 0; i < 10; i++)
{
    for (int j =0; j < 10; j++)
    {
        if (j==4)
        {
            break;
        }
        Console.WriteLine($"{i} {j}");
    }
}

Acho que a resposta é:
    Na pratica, o laço mais interno só vai até 3 (inclusive)

outras alternativas:
a instrução break interrompe ambos os laços quando j == 4
O código só exibe uma mensagem na tela quando j == 4
a instrução break interrompe apenas o laço mais externo quando j == 4



QUESTÃO 12
BUSCAR ENTENDER DEPOIS O QUE FOI QUE ACONTECEU ALI

var palavra = "palavras";
string output = "";
for (int i = 0; i < palavra.Length; i+=2)
{
    output += palavra[i + 1];
    output += palavra[i];
}
Console.WriteLine(output);
*/


/*Ao sair do supermercado Vitor recebe a ligação de sua esposa solicitando o seguinte:

Preciso que você compre 4 caixas de leite, se tiver ovos traga 6.

Ao chegar em casa Vitor entregou 6 caixas de leite para a esposa, sua esposa não ficou nem um pouco feliz.
*/

/*
//Questão 1: Solução do Vitor para o problema.
var leite = 4;
var ovoDisponivel = 6;
var pedidoOvoEsposa = 6;
var pLeite = 3.15;
var pOvo = 7.00/12;
bool sol = true;
bool cobertura = true;
var carteiraEsquecida = "";

if (Convert.ToBoolean(ovoDisponivel))
{
    Console.WriteLine("Vitor trouxe " + (pedidoOvoEsposa) + " caixas de leite.");
    Console.WriteLine("O total dessa compra foi: " + (Convert.ToDouble(pedidoOvoEsposa) * pLeite) + " reais.");
}
else
{
    Console.WriteLine("Vitor trouxe " + (leite) + " caixas de leite.");
    Console.WriteLine("O total dessa compra foi: " + (Convert.ToDouble(leite) * pLeite) + " reais.");
}

Console.WriteLine(" ");
Console.WriteLine(" ");

//Questão 2: Solução da "esposa" para o problema.

if (Convert.ToBoolean(ovoDisponivel))
{
    if (ovoDisponivel <= 6)
    {
        Console.WriteLine("Victor trouxe " + (leite) + " caixas de leite e " + (ovoDisponivel) + " ovos.");
        Console.WriteLine("O total dessa compra foi: " + ((Convert.ToDouble(leite) * pLeite) + (Convert.ToDouble(ovoDisponivel) * pOvo)) + " reais.");
    }
    else
    {
        Console.WriteLine("Victor trouxe " + (leite) + " caixas de leite e " + (pedidoOvoEsposa) + " ovos.");
        Console.WriteLine("O total dessa compra foi: " + ((Convert.ToDouble(leite) * pLeite) + (Convert.ToDouble(pedidoOvoEsposa) * pOvo)) + " reais.");
    }
    
}
else
{
    Console.WriteLine("Victor trouxe " + (leite) + " caixas de leite e nenhum ovo.");
    Console.WriteLine("O total dessa compra foi: " + ((Convert.ToDouble(leite) * pLeite)) + " reais.");
}

Console.WriteLine(" ");
Console.WriteLine(" ");

//Questão 3: Precificação do pedido

// Questão 4: Vitor só vai comprar ovos, se tiver no mercado e se a dúzia custar menos que 6 reais.

if (Convert.ToBoolean(ovoDisponivel) && (pOvo*12) < 6.00)
{
    Console.WriteLine("Victor comprou ovos.");
}
else
{
    Console.WriteLine("Vitor não comprou nada no mercado.");
}

//Questão 5: 

Console.WriteLine(" ");
Console.WriteLine(" ");


if (sol || cobertura)
{
    Console.WriteLine("Victor vai ao Mercado.");
}
else
{
    Console.WriteLine("Victor não vai ao mercado.");
}

//Questão 6: esqueceu a carteira não vai ao mercado.

if (carteiraEsquecida == "sim" || carteiraEsquecida == "Sim")
{
    Console.WriteLine("Fiado de forma alguma, vá para casa espertão.");
}
else
{
    Console.WriteLine("Vitor vai ao mercado normalmente.");
}







var nome = "";
var idade = 0;
var carteira = "";
var listaNome = new List<string>();
var listaMotorista = new List<string>();

for (int i = 0; i <+ 15; i++)
{
    Console.WriteLine("Insira seu nome: ");
    nome = Console.ReadLine();
    listaNome.Add(nome);
    Console.WriteLine(" ");
    Console.WriteLine("Insira sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade > 18)
    {
        Console.WriteLine("Você possue carteira de motorista? (Responda com: 'sim' ou 'não') ");
        carteira = Console.ReadLine();
        listaMotorista.Add(nome);
    } else
    {
        continue;
    }

    if (listaMotorista.Count >= 2)
    {
        break;
    }
}


Console.WriteLine("Os motoristas da viagem são:");
foreach(var item in listaMotorista)
{
    Console.WriteLine(item);
}

*/
