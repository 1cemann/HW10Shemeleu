//Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.


using System;
using static System.Console;
Clear();

int [,] array= new int[4,4];
FillArray(array);
PrintArray(array);
WriteLine();
int[,] positionSmallElement = new int[1, 2];
positionSmallElement = Minvalue(array, positionSmallElement);
Write("Индексы минимального элемента =  ");
PrintArray(positionSmallElement);

int[,] myMatrixNew = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
NewArray(array, positionSmallElement, myMatrixNew);
WriteLine("Матрица после изменений: ");
WriteLine();
PrintArray(myMatrixNew);

void NewArray(int[,] array, int[,] positionSmallElement, int[,] myMatrixNew)
{
  int k = 0, l = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        myMatrixNew[k, l] = array[i, j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0, 0] != i)
    {
      k++;
    }
  }
}

int[,] Minvalue(int[,] array, int [,] position)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (array[i, j] <= temp)
            {
            temp = array[i, j];
            position[0, 0] = i;
            position[0, 1] = j;
            }
        }
        break;
    }
    WriteLine("Минимальный элемент = {0}", temp);
    return position;
}



void FillArray(int[,] newarr)
{
    for (int i = 0; i < newarr.GetLength(0); i++)
    {
        for (int j = 0; j < newarr.GetLength(1); j++)
        {   
            newarr[i,j]=new Random().Next(0,10);
        }
    }
}


void PrintArray(int[,] newarr)
{
    for (int i = 0; i < newarr.GetLength(0); i++)
    {
        for (int j = 0; j < newarr.GetLength(1); j++)
        {
            Write($"{newarr[i,j]} ");
        }
        WriteLine();
    }
}