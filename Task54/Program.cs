// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void CompareSwapMaxToMin(ref int vol1, ref int vol2)
{
    int tempVol = 0;
    if (vol1 < vol2)
    {
        tempVol = vol2;
        vol2 = vol1;
        vol1 = tempVol;
    }
}

void SortInRowsMaxToMin(int[,] matrixToSort)
{
    for (int i = 0; i < matrixToSort.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToSort.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrixToSort.GetLength(1); k++)
            {
                CompareSwapMaxToMin(ref matrixToSort[i, j], ref matrixToSort[i, k]);
            }
        }
    }
}

///==================================

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
SortInRowsMaxToMin(matrix);
PrintMatrix(matrix);
