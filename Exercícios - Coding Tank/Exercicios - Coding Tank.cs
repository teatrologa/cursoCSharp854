//Exercício 4 - verificando senha

//Exercício de verificação de senha

int senhaCorreta = 5190;
var senha = 0;
int tentativa = 0;

do
{
    //Condição de parada após 3 tentativas erradas
    if (tentativa >= 3)
    {
        Console.WriteLine("Senha Bloqueada");
        Console.WriteLine(" ");
        break;
    }

    //Leitura da senha
    Console.WriteLine("Insira sua senha de 4 dígitos numéricos:");
    senha = Convert.ToInt32(Console.ReadLine());



    //contador de entrada (tentativa de inserir a senha)
    tentativa++;

    if (senha == senhaCorreta)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Senha Correta");
        Console.WriteLine(" ");
        break;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Senha incorreta");
        Console.WriteLine(" ");
    }

}
while (senha != senhaCorreta);



return;





// Exercício da música dos 5 patinhos
//REFAZER O EXERCÍCIOS QUANDO DER

int [] arrayPatinhos = new int[5];

/*
 * int [] array Patinhos =  { 1, 2, 3, 4, 5};
 * Apenas outra forma de fazer que funciona igualemnte bem nesse caso.
*/

arrayPatinhos[0] = 1;
arrayPatinhos[1] = 2;
arrayPatinhos[2] = 3;
arrayPatinhos[3] = 4;
arrayPatinhos[4] = 5;


for (int i = 4; i >= 0; i--)
{
    Console.WriteLine($"{ arrayPatinhos[i]} patinhos foram passear ");
    Console.WriteLine("além das montanhas, para brincar.");
    Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá!");
    Console.WriteLine($"Mas só {arrayPatinhos[i] - 1} patinhos voltaram de lá.");
    Console.WriteLine(' ');

}

Console.WriteLine("A mamãe patinha foi procurar");
Console.WriteLine("Além das montanhas, na beira do mar.");
Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá!");
Console.WriteLine($"E os {arrayPatinhos[4]} patinhos voltaram de lá.");










//EXERCÍCIO DOIS

double salario = 0;
double desconto = 0;


//Entrando com valor de salário
Console.WriteLine("Insira o valor do seu salário:(Ex: 1456,00) ");
Double.TryParse(Console.ReadLine(), out salario);

if (salario < 1212.00)
{

    desconto = salario * 0.075;
    Console.WriteLine("Seu desconto será de R$" + desconto);
}

else if (2427.00 >= salario && salario >= 1212.00)
{
    desconto = salario * 0.09;
    Console.WriteLine("Seu desconto será de R$" + desconto);
}

else if (3641.03 >= salario && salario >= 2427.36)
{
    desconto = salario * 0.12;
    Console.WriteLine("Seu desconto será de R$" + desconto);
}

else if (7087.22 >= salario && salario >= 3641.04)
{
    desconto = salario * 0.14;
    Console.WriteLine("Seu desconto será de R$" + desconto);
}

else
{
    desconto = 1500.00;
    Console.WriteLine("Seu desconto será de R$" + desconto);
}








// pRIMEIRO CÓDIGO

var perguntaUm = "";
var perguntaDois = "";
var perguntaTres = "";
var perguntaQuatro = "";
var perguntaCinco = "";

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;
int soma = 0;


Console.WriteLine("Telefonou para a vítima? (Responda: 'Sim' ou 'Não')");
perguntaUm = Console.ReadLine();
if (perguntaUm == "Sim")
{
    p1 = 1;
}

else if (perguntaUm == "sim")
{
    p1 = 1;
}

else
{
    p1 = 0;
}


Console.WriteLine("Esteve no local do crime? (Responda: 'Sim' ou 'Não')");
perguntaDois = Console.ReadLine();
if (perguntaDois == "Sim")
{
    p2 = 1;
}

else if (perguntaDois == "sim")
{
    p2 = 1;
}

else
{
    p2 = 0;
}


Console.WriteLine("Mora perto da vítima? (Responda: 'Sim' ou 'Não')");
perguntaTres = Console.ReadLine();
if (perguntaTres == "Sim")
{
    p3 = 1;
}

else if (perguntaTres == "sim")
{
    p3 = 1;
}

else
{
    p3 = 0;
}


Console.WriteLine("Devia para a vítima? (Responda: 'Sim' ou 'Não')");
perguntaQuatro = Console.ReadLine();
if (perguntaQuatro == "Sim")
{
    p4 = 1;
}

else if (perguntaQuatro == "sim")
{
    p4 = 1;
}

else
{
    p4 = 0;
}

Console.WriteLine("Já trabalhou com a vítima? (Responda: 'Sim' ou 'Não')");
perguntaCinco = Console.ReadLine();
if (perguntaCinco == "Sim")
{
    p5 = 1;
}

else if (perguntaCinco == "sim")
{
    p5 = 1;
}

else
{
    p5 = 0;
}

Console.WriteLine(" ");

soma = p1 + p2 + p3 + p4 + p5;

if (soma == 5)
{
    Console.WriteLine("Assassino");
}

else if (soma == 0)
{
    Console.WriteLine("Inocente");
}

else if (soma <= 2)
{
    Console.WriteLine("Suspeito");
}

else
{
    Console.WriteLine("Cúmplice");
}

