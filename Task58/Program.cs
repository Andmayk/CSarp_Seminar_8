// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] = matrixC[i, j] + matrixA[i, k] * matrixB[k, j];
            }

        }
    }
    return matrixC;
}

///=======================
int rowsA = ReadInt("Введите количество строк матрицы А: ");
int colsA = ReadInt("Введите количество стобцов матрицы А: ");
int rowsB = ReadInt("Введите количество строк матрицы B: ");
int colsB = ReadInt("Введите количество стобцов матрицы В: ");

if (colsA == rowsB)
{
    int[,] matrixA = FillMatrix(rowsA, colsA, 0, 4);
    System.Console.WriteLine();
    PrintMatrix(matrixA);

    int[,] matrixB = FillMatrix(rowsB, colsB, 0, 4);
    System.Console.WriteLine();
    PrintMatrix(matrixB);

    int[,] matrixC = MultMatrix(matrixA, matrixB);
    System.Console.WriteLine();
    PrintMatrix(matrixC);
    System.Console.WriteLine();
}
else
{
    System.Console.WriteLine("Не возможно выполнить умножение матриц!");
}
