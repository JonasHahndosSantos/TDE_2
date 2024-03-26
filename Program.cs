
string nome = "paulo";
int idade = 17;
float nota = 7.5f;
 Console.WriteLine($"O {nome} tem {idade} de idade, e sua nota é {nota}");
 Console.ReadLine();


string nome1 = "paulo";
int idade1 = 17;
float nota1 = 7.5f;
Console.WriteLine($"O nome é {nome1} \n a idade é {idade1} \n e sua nota é {nota1}");
 Console.ReadLine();


//   Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (X) double para long
// ( ) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal


Console.WriteLine("Digite a primeira letra:");
        char letra1 = Console.ReadKey().KeyChar;
        Console.WriteLine("\nDigite a segunda letra:");
        char letra2 = Console.ReadKey().KeyChar;
        Console.WriteLine("\nDigite a terceira letra:");
        char letra3 = Console.ReadKey().KeyChar;
        string ordemReversaConcatenacao = "" + letra3 + letra2 + letra1;
        Console.WriteLine("\nUsando concatenação de strings: " + ordemReversaConcatenacao);
        string ordemReversaInterpolacao = $"{letra3}{letra2}{letra1}";
        Console.WriteLine($"Usando interpolação de strings: {ordemReversaInterpolacao}"); 


// V ou F
// (F ) long resultado = 1.32;
// ( V) var nome = “Maria”;
// (F ) string resultado = 100.ToString();
// (V ) A sequência de escape \n inclui uma nova linha
// (F ) float f = 5.45;
// (F ) decimal valor = (decimal) 10.99f;
// (V ) var status = null;
// (F ) object o = 12.45m;
// (V ) string titulo = true.ToString();
// (V ) A sequencia \t inclui uma tabulação vertical
 

Console.WriteLine("informe o valor de x");
 int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a soma de x + y = {x+y}");
Console.WriteLine($"a subitração de x - y = {x-y}");
Console.WriteLine($"a divisao de x / y = {x/y}");
Console.WriteLine($"a multiplicao de x * y = {x*y}");
Console.WriteLine($"valor de x elevado a y {Math.Pow (x, y)}");


 Console.WriteLine("Digite o nome:");
        string nome3 = Console.ReadLine();

        Console.WriteLine("Digite a senha:");
        int senha;
        if (!int.TryParse(Console.ReadLine(), out senha)) 
        {
            Console.WriteLine("Senha inválida. Por favor, insira um número inteiro para a senha.");
            return; 
        }
        string mensagem = (nome3 == "admin" || nome3 == "maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido";
        Console.WriteLine(mensagem);


//Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("informe o valor de x");
int x6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o valor de y");
int y6 = Convert.ToInt32(Console.ReadLine());

 string xPar = x6 % 2 == 0 ? "par" : "ímpar";
        Console.WriteLine($"O número {x6} é {xPar}.");

 string yPar = y6 % 2 == 0 ? "par" : "ímpar";
        Console.WriteLine($"O número {y6} é {yPar}.");