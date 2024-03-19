// 1.Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
sbyte idade = 35;
Console.WriteLine(idade);

// 2.Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

// 3.Crie uma variável chamada altura e atribua a ela o valor 3.45.
decimal altura;
altura = 3.45m;
Console.WriteLine(altura);

// 4.Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
// *OBS é preciso comentar todos os outros códigos para funcionar
    // class Programa
    // {
    //     static void Main()
    //     {
    //         const int ano = 12;
    //         Console.WriteLine(ano);
    //     }
    // }


// 5.Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = 7.80;
Console.WriteLine(nota);

// 6.Quais as diferenças entre os tipos por valor e os tipos por referência ?
// R =  Variáveis de tipos de referência funcionam como etiquetas que apontam para onde os dados estão guardados na memória, enquanto variáveis de tipos de valor armazenam diretamente os dados.

// 7 - O que é um nullable type e qual a sua utilidade ?
// R = Um "nullable type" é um conceito utilizado em programação para indicar que um tipo de dado pode armazenar tanto um valor válido quanto um valor nulo.
// Eles podem armazenar um valor válido do tipo que foi especificado (como um número, uma palavra, etc.), ou podem não armazenar nada (valor nulo).

// 8 - O que é Camel Case ? Dê um exemplo de sua aplicação.
// Camel case é um estilo de nomenclatura de texto usado em programação para nomear variáveis, funções e outros identificadores compostos por mais de uma palavra. 
// Se quisermos nomear uma variável que representa a idade de uma pessoa, em Camel Case, poderíamos chamá-la de "idadeDaPessoa"

// 9 - O que é Pascal Case ? Dê um exemplo de sua aplicação
// O "Pascal Case" é uma convenção de escrita de texto utilizada na programação de computadores para nomear identificadores compostos por mais de uma palavra, onde cada palavra é iniciada com uma letra maiúscula e não há espaços entre elas.

// Um exemplo seria um método que calcula o dobro de um número, onde, poderíamos chamá-lo de "CalcularDobro".


// 10 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
// seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
// operação de soma)
int x = 77;
int y = 66;
int soma = (x+y);
Console.WriteLine(soma);

// 11 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

// bool booleano;    // valor padrão: false
// char caractere;   // valor padrão: '\0'
// int numeroInteiro; // valor padrão: 0
// double numeroDouble; // valor padrão: 0.0
// float numeroFloat; // valor padrão: 0.0f
// decimal numeroDecimal; // valor padrão: 0.0m
// string texto;     // valor padrão: null