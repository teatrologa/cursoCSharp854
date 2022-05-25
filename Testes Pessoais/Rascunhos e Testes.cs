/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadLine();

//Criando variáveis

string msg = "TODOS PASSARAM!";

int primeiroNumero = 1;
int segundoNumero = 2;

int resultado = primeiroNumero + segundoNumero; // atribuiçao de valor a 
												// operação +
decimal numeroDecimal = decimal.MaxValue;

DateTime dtAgora = DateTime.Now; // retorna data e horario atual 
								 // 12/28/2020 1:20:55 AM
bool estaChovendo = true;

Console.WriteLine(dtAgora);










Console.WriteLine("Insira sua senha numérica:");

string inputSenha = Console.ReadLine();

 while (inputSenha.Length < 4)
{

    Console.WriteLine("Insira uma senha numerica com mais de 4 digitos.");
    inputSenha = Console.ReadLine();
    //vai escrever essa mensagem na tela quando a senha for aceita, entretanto ela não tem limite de parada
    //BUSCAR COMO PARAR APÓS 3 TENTATIVAS por exemplo

}

int senha = int.Parse(inputSenha); //retorna o valor inteiro
Console.WriteLine($"Sua senha {senha} foi aceita");
int.TryParse(inputSenha, out senha); // retorna um booleano que indica se converteu
Console.WriteLine(" ");
//Console.WriteLine(senha*2);

















int tempAtual = 25;
//Adicionado a variavel chuva e definida como false
bool chuva = true;

if (tempAtual > 30 && chuva == false)
{
    Console.WriteLine("Usar Shorts");
}
//Aqui comparamos se a temperatura é maior que 30 e se a chuva é verdadeira
// como curiosidade, pela chuva ja ser um tipo booleano, nao precisamos comparar com True ou False, basta apenas 
// adiciona-la na condição    
else if (tempAtual > 30 && chuva)
{
    Console.WriteLine("Usar Calça e capa de chuva");
}
else
{
    Console.WriteLine("Coloque calça.");
}


//Operadores ternários, reduzem BEM o código.
int tAtual = 35;
string mensagem = (tAtual > 30) ? "Usar Shorts" : "Usar Calça";
Console.WriteLine(mensagem);





//EXEMPLO DE AULA - EMENTA CLASS

// Declaro a varivel int mes
var mes = 1;

//Defino que o mes sera comparado com todas as opcoes abaixo
switch (mes)
{
    //caso o valor mes, seja igual a 1, ele irá exibir janeiro
    case 1:
        Console.WriteLine("Janeiro");
           //Apos ele exibir janeiro, ele automaticamente ele ira parar de validar as outra opções devido ao comando break
        break;
    case 2:
        Console.WriteLine("Fevereiro");
        break;
    case 3:
        Console.WriteLine("Março");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Maio");
        break;
    case 6:
        Console.WriteLine("Junho");
        break;
    case 7:
        Console.WriteLine("Julho");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 9:
        Console.WriteLine("Setembro");
        break;
    case 10:
        Console.WriteLine("Outubro");
        break;
    case 11:
        Console.WriteLine("Novembro");
        break;
    case 12:
        Console.WriteLine("Dezembro");
        break;
    // Caso o mes selecionado nao esteja no range de 1 a 12, ele exibira a mensagem que o mes informado nao existe            
    default:
        Console.WriteLine("Mês nao existe");
        break;
}





Console.WriteLine("Digite sua senha numérica: ");
string inputUsuarioSenha = (Console.ReadLine());
var i = 1;




for (i = 1; i <= 3; i++)
{
    if (i == 3) //deixar esse if primeiro se não o código quebra e não funciona corretamente o else
    { //note que i == 3 funciona para as 3 tentativas
        Console.WriteLine("Sua conta foi bloqueada.");
        Console.WriteLine($"{i}");
        break;
    }

    if (inputUsuarioSenha.Length < 4)
    {
        Console.WriteLine("Senha inválida!");
        Console.WriteLine(" ");
        Console.WriteLine("Insira sua senha novamente: ");
        inputUsuarioSenha = (Console.ReadLine());
        Console.WriteLine($"{i}");

       // if (i == 2) // i==2 pois começa i ==0 Não sei o motivo
       // {
       //     Console.WriteLine("Sua conta foi bloqueada.");
       //     Console.WriteLine($"{i}");
       //     break;
       // }  

    }


    else
    {
        int senha = int.Parse(inputUsuarioSenha);
        Console.WriteLine(" ");
        Console.WriteLine($"Sua senha {senha} foi aceita");
        Console.WriteLine(inputUsuarioSenha);
        break;
    }
    

    
}

while (n < 3)
{
    if (inputUsuarioSenha.Length < 4)
    {
        Console.WriteLine("Senha inválida!");
        Console.WriteLine(" ");
        Console.WriteLine("Insira sua senha novamente: ");
        inputUsuarioSenha = (Console.ReadLine());
        
      
    }
    else
    {
        int senha = int.Parse(inputUsuarioSenha);
        Console.WriteLine($"Sua senha {senha} foi aceita");
        Console.WriteLine(inputUsuarioSenha);
    }
    n++;
   
}

Console.WriteLine("Tentativas bloquadas."); 

 
 */


int[] array2 = new int[] { 1, 3, 5, 7, 9 };
int cont = 0;
foreach (int element in array2)
{
    cont++;
}
Console.WriteLine(cont); //forma 1 de saber quantos elementos tem o array

Console.WriteLine(array2.Length); // forma 2 de saber quantos elementos tem o array


//matrizes multidimencionais

int[,] theArray = new int[5, 10];
Console.WriteLine("A Matriz passui {0} dimensoes.", theArray.Rank);
