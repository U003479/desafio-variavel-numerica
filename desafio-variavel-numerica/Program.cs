﻿//--------------------------------------------------------
Console.WriteLine("\n -- Desafio 1 -- \n");
// RESOLVA TODOS OS ERROS DE COMPILAÇÃO ABAIXO.
// O PROGRAMA DEVE EXIBIR O RESULTADO 433,79153 NA TELA

int num1 = 21474831;

int num2 = 2147483648;

int num3 = num1 + num2;

int resultado = num3 / 5000002;

Console.WriteLine("Numero 1: " + num1);
Console.WriteLine("Numero 2: " + num2);
Console.WriteLine(num1 + " + " + num2 + " = " + num3);
Console.WriteLine(num3 + " / " + 5000002 + " = " + resultado);

//--------------------------------------------------------
Console.WriteLine("\n -- Desafio 2 -- \n");
// RESOLVA TODOS OS ERROS DE COMPILAÇÃO ABAIXO.
// O PROGRAMA DEVE EXIBIR O RESULTADO 433,79153 NA TELA

uint val1 = 10;

short val2 = -15;

uint val3 = val1 + val2;

int resultado1 = (float)num3 + 2147483648;

Console.WriteLine("Numero 1: " + num1);
Console.WriteLine("Numero 2: " + num2);
Console.WriteLine(num1 + " + " + num2 + " = " + num3);
Console.WriteLine(num3 + " / " + 5000002 + " = " + resultado);


//--------------------------------------------------------
Console.WriteLine("\n -- Desafio 3 -- \n");
// LUCAS RECEBE 50000 E QUER SABER QUANTO IRÁ GANHAR DE FGTS POR MÊS
// DESENVOLVA UM PROGRAMA QUE CALCULE O FGTS DO LUCAS 
// Formula: salario * 8% = valorFgts;

float salario = 50000.50f;

var fgts = 0;

Console.WriteLine("Salario: " + salario);
Console.WriteLine("FGTS: " + fgts);