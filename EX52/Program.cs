/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк");
int lengthRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int lengthCol = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[lengthRow, lengthCol];

void generate2DArray(int[,] array)
{
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

void print2dArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t",ConsoleColor.DarkMagenta);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i+"\t",ConsoleColor.DarkMagenta);
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

generate2DArray(numbers);
print2dArray(numbers);
Console.WriteLine();

for (int j = 0; j < lengthCol; j++)
{
    double sum = 0;
    for (int i = 0; i < lengthRow; i++)
    {
        sum = (sum + numbers[i, j]);
    }
    sum = sum / lengthRow;
    Console.WriteLine($"Среднее арифметическое {j} столбца: {Math.Round(sum, 2)}");
}