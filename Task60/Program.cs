// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int ReadInt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ExistsInMatrixNumber(int[,,] matrixForFinde, int number)
{
    for (int i = 0; i < matrixForFinde.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForFinde.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForFinde.GetLength(2); k++)
            {
                if (number == matrixForFinde[i, j, k]) return true;
            }
        }
    }
    return false;
}


int[,,] FillMatrix(int x, int y, int z, int rangLeft, int rangRight)
{
    int[,,] tempMatrix = new int[x, y, z];
    Random rand = new Random();
    int number = 0;

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                do // проверим на повторяимость числа в массиве
                {
                    number = rand.Next(rangLeft, rangRight + 1);
                } while ((ExistsInMatrixNumber(tempMatrix, number)));
                tempMatrix[i, j, k] = number;
            }
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForPrint.GetLength(2); k++)
            {
                System.Console.Write($"{matrixForPrint[i, j, k]} ({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

///==================================

int size1 = ReadInt("Введите 1 размер трёх мерного массива: ");
int size2 = ReadInt("Введите 2 размер трёх мерного массива: ");
int size3 = ReadInt("Введите 3 размер трёх мерного массива: ");
int maxRangRight = 99;

if ((size1 * size2 * size3) > 90)
{
    System.Console.WriteLine("невозможно заполнить весь массив двузначными числами");
}
else
{
    int[,,] matrix = FillMatrix(size1, size2, size3, 10, maxRangRight);
    PrintMatrix(matrix);
}


