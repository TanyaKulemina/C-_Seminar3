﻿/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message); 
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод.");
        }
    }
    return resultNumber;
}

void ThirdDegree (int a)
{
    for (int i = 1; i <= a; i++)
    {
        int thirdDegree = i * i * i;
        Console.Write($"{thirdDegree}, ");
    }
}

int x = GetNumber("Введите число");
ThirdDegree(x);