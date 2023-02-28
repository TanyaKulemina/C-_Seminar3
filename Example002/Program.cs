/* Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/
int GetNumber(string message)
{
    int resultQuarter = 0;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out resultQuarter) && (resultQuarter > 0) && (resultQuarter < 5))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод!");
        }
    }
    return resultQuarter;
}

void GetDiapazon(int resultQuarter)
{
    if (resultQuarter == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (resultQuarter == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (resultQuarter == 3)
        Console.WriteLine("x < 0, y < 0");
    else
        Console.WriteLine("x > 0, y < 0");
}

int quarter = GetNumber("Введите номер четверти");
GetDiapazon(quarter);
