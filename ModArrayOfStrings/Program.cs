/* Задача:
Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


string[] GetArrayStringConsole (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(" ");
    return arraySimvol;
}

string[] GetArrayThreeSimvol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSimvol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayThreeSimvol[j] = array[i];
            j++;
        }
    }
    return arrayThreeSimvol;
}

void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}” ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите набор строк латинскими символами через пробел: ");
string inStringSimvol = (Console.ReadLine()!);
string[] arraySimvol = GetArrayStringConsole(inStringSimvol);
Console.WriteLine();
Console.WriteLine("Введённые строки:");
Print(arraySimvol);
Console.WriteLine();
Console.WriteLine("Введённые строки длиной меньшей либо равной 3 символам:");
Print(GetArrayThreeSimvol(arraySimvol));
Console.WriteLine();