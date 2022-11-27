//Задача 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите натуральное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 2)
{
    int N = number % 2;
    int count = 2;
    if(N == 1)
    {
        while(count < number)
        {
            Console.Write($"{count}, ");
            count = count + 2;
        }
    }
    else  
    {
        while(count < number+1)
        {
            Console.Write($"{count}, ");
            count = count + 2;
        }
    }
}  
else
{
    Console.Write("Ошибка! Введите натуральное число, больше 1");
}