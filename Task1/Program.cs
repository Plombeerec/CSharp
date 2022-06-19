// Напишите программу, которая на 
//вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double a , b;
Console.WriteLine("Введите сравниваемые числа");
a =Convert.ToDouble(Console.ReadLine());
b =Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее значение = " + a + " Меньшее значение = " + b);
}
else
{
    Console.WriteLine("Большее значение = " + b + " Меньшее значение = " + a);
}