// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// 

int max = 0;
int min = 0;



Console.Write("Enter first number:");
int number = Convert.ToInt32(Console.ReadLine());


Console.Write("Enter second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number > number2)
{
    max = number;
    min = number2;
}
else 
{
    max = number2;
    min = number;
}

Console.WriteLine("max =" + max + "and" + "min = " + min);



