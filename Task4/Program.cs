// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
int number;

Console.WriteLine("Введите число");
number =Convert.ToInt32(Console.ReadLine());
while (number > 0)
{
    if (number % 2 == 0)
    {
     Console.Write.(number + ", ");
     number --;
    }
    else
    {
        number --;
}
}