//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int N = number % 2;
if(N == 1)
{
    Console.WriteLine($"Число {number} нечетное");
}
else
{
    Console.WriteLine($"Число {number} четное");
}
