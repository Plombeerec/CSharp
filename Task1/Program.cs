// Напишите программу, которая на 
//вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a , b;
Console.WriteLine("Введите сравниваемые числа");
a =Convert.ToInt32(Console.ReadLine());
b =Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее значение = " + a);
}
else
{
    Console.WriteLine("Большее значение = " + b);
}