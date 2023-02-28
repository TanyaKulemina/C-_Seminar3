/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}

double Distance(int x1, int x2, int y1, int y2)
{
    double dist = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
    return dist;   
}

int x1 = GetNumber("Введите координату X первой точки");
int y1 = GetNumber("Введите координату Y первой точки");
int x2 = GetNumber("Введите координату X второй точки");
int y2 = GetNumber("Введите координату Y второй точки");
double distance = Distance(x1, x2, y1, y2);
Console.WriteLine($"Расстояние между ({x1},{y1}) и ({x2},{y2}) составляет {distance}");


