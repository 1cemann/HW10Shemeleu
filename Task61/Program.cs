//Задача 61: Показать треугольник Паскаля. 
//*Сделать вывод в виде равнобедренного треугольника.


using System;
using static System.Console;
Clear();

Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int c = 1;
    for (int j = 0; j < n - i; j++)
    {
        Write("   ");
    }

    for (int k = 0; k <= i; k++)
    {
        Write("   {0:D} ", c);
        c = c * (i - k) / (k + 1);
    }
    WriteLine();
    
}



