// 1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
 
// Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
// escapes.


 string nome = "Paulo";
 int idade = 17;
 double nota = 7.5;

 string saidaConcatenacao = "Aluno " + nome + " tem " + idade + " anos e nota " + nota;
 Console.WriteLine(saidaConcatenacao);

 string saidaInterpolacao = $"Aluno {nome} tem {idade} anos e nota {nota}";
 Console.WriteLine(saidaInterpolacao);

 Console.WriteLine($"Aluno: {nome}\nIdade: {idade}\nNota: {nota}");


// 2 - Para qual tipo de dados você pode converter um float implicitamente ?

( ) int
( ) double // resposta correta
( ) long
( ) decimal

// 3 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?

( ) int para long
( ) double para long
( ) double para float // resposta correta
( ) decimal para float // resposta correta
( ) long para int // resposta correta
( ) double para decimal

// 4 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings.

Console.WriteLine("Digite a primeira letra:");
char letra1 = Console.ReadKey().KeyChar;
Console.WriteLine("\nDigite a segunda letra:");
char letra2 = Console.ReadKey().KeyChar;
Console.WriteLine("\nDigite a terceira letra:");
char letra3 = Console.ReadKey().KeyChar;

// Usando concatenação de strgs
string resultadoConcatenacao = "" + letra3 + letra2 + letra1;
Console.WriteLine("\nResultado com concatenação: " + resultadoConcatenacao);

// Usando interpolação de strgs
string resultadoInterpolacao = $"{letra3}{letra2}{letra1}";
Console.WriteLine("Resultado com interpolação: " + resultadoInterpolacao);

// 5 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(F) long resultado = 1.32; // pois 1.32 é um valor do tipo double e não pode ser atribuído diretamente a uma variável do tipo long.
(V) var nome = “Maria”; // pois o compilador infere que a variável nome é do tipo string devido ao valor atribuído.
(F) string resultado = 100.ToString(); // pois 100.ToString() retorna uma string e não pode ser atribuído diretamente a uma variável do tipo string.
(V) A sequência de escape \n inclui uma nova linha // \n representa uma nova linha em strings.
(F) float f = 5.45; // pois 5.45 é um valor do tipo double e não pode ser atribuído diretamente a uma variável do tipo float.
(V) decimal valor = (decimal) 10.99f; // pois (decimal) realiza um cast do valor float para decimal.
(F) var status = null; // pois var requer uma inicialização com um valor, e null não é suficiente.
(V) object o = 12.45m; // pois 12.45m é um literal de decimal.
(F) string titulo = true.ToString(); // pois true.ToString() retorna uma string e não pode ser atribuído diretamente a uma variável do tipo string.
(F) A sequencia \t inclui uma tabulação vertical // \t representa uma tabulação horizontal.

// 6 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado:

Console.WriteLine("Digite o primeiro valor:");
double valor1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
double valor2 = Convert.ToDouble(Console.ReadLine());

double soma = valor1 + valor2;
double subtracao = valor1 - valor2;
double multiplicacao = valor1 * valor2;
double exponenciacao = Math.Pow(valor1, valor2);
double divisao = valor1 / valor2;
double modulo = valor1 % valor2;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Exponenciação: {exponenciacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Módulo: {modulo}");

//  7 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário).

Console.WriteLine("Digite o nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite a senha:");
int senha = Convert.ToInt32(Console.ReadLine());

string mensagem = (nome == "admin" || nome == "maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido";
        
Console.WriteLine(mensagem);


// 8 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. Use o operador condicional ternário (?

Console.WriteLine("Digite o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

string parOuNaoX = x % 2 == 0 ? "par" : "ímpar";
string parOuNaoY = y % 2 == 0 ? "par" : "ímpar";

Console.WriteLine($"x é {parOuNaoX}");
Console.WriteLine($"y é {parOuNaoY}");
