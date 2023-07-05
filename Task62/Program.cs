// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int ReadInt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            Console.Write((matrixForPrint[i, j]<10) ? $"0{matrixForPrint[i, j]}\t" : $"{matrixForPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixSpiral(int[,] tempMatrix)
{
    int count = 1;
    int rightC = tempMatrix.GetLength(1) - 1;
    int downC = tempMatrix.GetLength(0) - 1;
    int leftC = 0;
    int upC = 0;

    while (rightC >= leftC || downC >= upC)
    {
        for (int i = leftC; i <= rightC; i++)  //      ->
        {
            tempMatrix[upC, i] = count;
            count++;
        }
        upC++;

        if (upC > downC) break;
        for (int i = upC; i <= downC; i++)     //       V
        {
            tempMatrix[i, rightC] = count;
            count++;
        }
        rightC--;

        if (rightC < leftC) break;
        for (int i = rightC; i >= leftC; i--)    //      A
        {
            tempMatrix[downC, i] = count;
            count++;
        }
        downC--;

        if (downC < upC) break;
        for (int i = downC; i >= upC; i--)       //       /\
        {
            tempMatrix[i, leftC] = count;
            count++;
        }
        leftC++;
    }
}

///===============================
int size1 = ReadInt("Введите количество строк: ");
int size2 = ReadInt("Введите количество стобцов: ");

int[,] matrix = new int[size1, size2];

FillMatrixSpiral(matrix);
PrintMatrix(matrix);

