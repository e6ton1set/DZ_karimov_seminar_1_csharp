//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
    
for (int index = 1; index <= number; index++)
    if (index % 2 == 0)
        Console.WriteLine(index);