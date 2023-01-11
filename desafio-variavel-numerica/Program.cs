//--------------------------------------------------------
Console.WriteLine("\n -- Desafio 1 -- \n");
// RESOLVA TODOS OS ERROS DE COMPILAÇÃO ABAIXO.
// O PROGRAMA DEVE EXIBIR O RESULTADO 433,79153 NA TELA


int num1 = 21474831;

uint num2 = 2147483648;

long num3 = num1 + num2;

float resultado = (float)num3 / 5000002;

Console.WriteLine("Numero 1: " + num1);
Console.WriteLine("Numero 2: " + num2);
Console.WriteLine(num1 + " + " + num2 + " = " + num3);
Console.WriteLine(num3 + " / " + 5000002 + " = " + resultado);

//--------------------------------------------------------
Console.WriteLine("\n -- Desafio 2 -- \n");
// RESOLVA TODOS OS ERROS DE COMPILAÇÃO ABAIXO.
// O PROGRAMA DEVE EXIBIR O RESULTADO 2147483643 NA TELA

uint val1 = 10;

short val2 = -15;

long val3 = val1 + val2;

decimal resultado1 = val3 + 2147483648;

Console.WriteLine("Numero 1: " + val1);
Console.WriteLine("Numero 2: " + val2);
Console.WriteLine(val1 + " + (" + val2 + ") = " + val3);
Console.WriteLine(val3 + " + " + 2147483648 + " = " + resultado1);

//--------------------------------------------------------
Console.WriteLine("\n -- Desafio 3 -- \n");
// LUCAS RECEBE 50000 E QUER SABER QUANTO IRÁ GANHAR DE FGTS POR MÊS
// DESENVOLVA UM PROGRAMA QUE CALCULE O FGTS DO LUCAS 
// Formula: salario * 8% = valorFgts;
//Resultado 4000,04

float salario = 50000.50f;

float fgts = 0;

fgts = salario * 8 / 100;


Console.WriteLine("Salario: " + salario);
Console.WriteLine("FGTS: " + fgts);