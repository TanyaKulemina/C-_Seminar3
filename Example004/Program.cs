/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
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

void Square (int a)
{
    for (int i = 1; i <= a; i++)
    {
        int sqr = i * i;
        Console.Write($"{sqr}, ");
    }
}

int x = GetNumber("Введите число");
Square(x);