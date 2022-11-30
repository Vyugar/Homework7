/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
9 -> 4
5 -> 9
*/

int[,] CreateRandomArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}
void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] CreateArrayConversion(int[,] array)
{

    int sizeNewArray = array.GetLength(0) * array.GetLength(1);
    int[] newArray = new int[sizeNewArray];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void UserElement(int[] array)
{
    Console.Write("Введите позицию элемента: ");
    int userElement = int.Parse(Console.ReadLine());
    for (int i = 0; i <= array.Length; i++)
    {
        if (userElement == i)
        {
            Console.WriteLine($" Значение элемента под индексом {userElement} = {array[i]}");
        }
    }

    if (userElement > array.Length)
    {
        Console.WriteLine("Такого числа в массиве нет");
        Console.WriteLine();
    }
    if (userElement < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
        Console.WriteLine();
    }

}
Console.WriteLine("Двумерный массив:");
int[,] array1 = CreateRandomArray(4, 4, 100);
print2dArray(array1);
Console.WriteLine();
Console.WriteLine("Преобразованный одномерный массив:");
int[] array2 = CreateArrayConversion(array1);
PrintArray(array2);
Console.WriteLine();
UserElement(array2);