/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message); 
        if (int.TryParse(Console.ReadLine(), out resultNumber) && Convert.ToString (resultNumber).Length == 5)
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


void Check(int resultNumber)
{
    string stringNumber = Convert.ToString (resultNumber);
    if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

int a = GetNumber ("Введите пятизначное число");
Check(a);
