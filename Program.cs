// Задать двумерный массив размером m*n
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
*/
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    } 
    Console.WriteLine();
 }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    } 
    Console.WriteLine();
 }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.WriteLine();
for (int index = 0; index < m; index = index + 2)
    {
        for (int count = 0; count < n; count = count + 2)
        {
            myarray[index, count] = myarray[index, count] * myarray[index, count];
        }
    }
ShowArray(myarray);
*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.Write("Сумма элементов главной диагонали: ");
int sum = 0;
for (int index = 0; index < m; index++)
    {
        for (int count = 0; count < n; count++)
        {
            if (index == count)
            {
                sum = sum + myarray[index, count];
                Console.Write($"{myarray[index, count]} +");
            }
        }
    }
Console.Write($"= {sum}");
*/
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] GenerateRandomArray(int l, int k)
{
    double[,] array = new double[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().NextDouble()*(30-1);
        }
    }
    return array;
}
void ShowArray(double[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write($"{array[row,column]:f1} ");
    }
    Console.WriteLine();
 }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}
void FindElement(int[,] array, int i, int j)
{
    if (i <= array.GetLength(0) && j <= array.GetLength(1))
    {
        int num = array[i-1,j-1];
        Console.WriteLine($"{i}, {j} - {num}");
    }
    else
    {
        Console.WriteLine($"{i}, {j} - такого числа в массиве нет");
    }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
Console.Write("Укажите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
FindElement(myarray, x, y);
*/
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
 for (int row = 0; row < array.GetLength(0); row++)
 {
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[row,column] +" ");
    }
    Console.WriteLine();
 }
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);

double average;
double sum = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum = sum + myarray[j,i];
    }
    average = sum / m;
    Console.Write($"{average:f1}, ");
    average = 0;
    sum = 0;
}
*/