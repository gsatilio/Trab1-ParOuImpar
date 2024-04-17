// 1 - faça um algoritmo que leia um numero e informe se ele é par ou impar


float numero, resto;

Console.WriteLine("Por favor, informe um numero.");
numero = float.Parse(Console.ReadLine());

resto = (numero % 2);

if(resto == 0)
{
    Console.WriteLine("O numero eh par!");
} else
{
    Console.WriteLine("O numero eh impar!");
}

Console.ReadKey();