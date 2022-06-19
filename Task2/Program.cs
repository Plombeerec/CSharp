//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
double a , b, c;

Console.WriteLine("Введите три числа");
a =Convert.ToInt32(Console.ReadLine());
b =Convert.ToInt32(Console.ReadLine());
c =Convert.ToInt32(Console.ReadLine());

if ((a > b) & (a > c))
{
    Console.WriteLine("Наибольшее число = " + a);
}
if ((b > a) & (b > c))
{
    Console.WriteLine("Наибольшее число = " + b);
}
if ((c > b) & (c > a))
{
    Console.WriteLine("Наибольшее число = " + c);
}