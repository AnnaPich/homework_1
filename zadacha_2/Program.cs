//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите целое число 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 >= number_2)
{
    Console.WriteLine($"Максимум = {number_1}, минимум = {number_2}");
}
else
{
    Console.WriteLine($"Максимум = {number_2}, минимум = {number_1}");
}
