﻿// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
int number;

Console.WriteLine("Введите число");
number =Convert.ToInt32(Console.ReadLine());

int count = number *(-1);

while (count <= number)
{
    if ((count > 0) &&(count % 2 ==0))
    {
        Console.Write(count +", ");
       count ++;
    }
    else
    {
        count ++;
    }
}
