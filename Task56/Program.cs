// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int rangLeft, int rangRight)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(rangLeft, rangRight + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int SumRow(int[,] matrix, int row)
{
    int sum = 0;
    if (row < matrix.GetLength(0))
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[row, j];
        }
    }
    else
    {
        System.Console.WriteLine(" В массиве нет строки с индексом: " + row);
    }
    return sum;
}

int RowMinSum(int[,] matrix)
{
    int rowIndex = 0;
    int sum = SumRow(matrix, rowIndex);
    int sumI;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sumI = SumRow(matrix, i);
        if (sumI < sum)
        {
            rowIndex = i;
            sum = sumI;
        }
    }
    return rowIndex;
}

///==================================

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine("Индекс строки с наименьшей суммой элементов: "+RowMinSum(matrix));
