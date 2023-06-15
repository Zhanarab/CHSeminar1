// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

int max = 0;


Console.Write("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number:");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > max)
{
    max = num1;
}
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine("max =" + max);