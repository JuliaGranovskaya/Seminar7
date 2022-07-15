// Задать двумерный массив размером m*n

int[,] GenerateRandomArray(int l, int k)
{
    int[,] array = new int[l, k];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; i < k; j++)
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
        Console.Write(array[row, column] +" ");
    }
 }   
    Console.WriteLine();
}

Console.Write("Введите кол-во сток таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray = GenerateRandomArray(m, n);
ShowArray(myarray);
