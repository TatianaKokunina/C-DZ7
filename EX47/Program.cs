/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк");
int lengthRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int lengthCol = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lengthRow, lengthCol];

void generate2DArray(double[,] array)
{
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
}


void print2DArray(double[,] array)
{
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

generate2DArray(numbers);
print2DArray(numbers);
