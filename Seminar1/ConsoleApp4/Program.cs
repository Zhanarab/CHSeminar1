﻿//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(num > 1)
{
    while(evenNumber <= num)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
