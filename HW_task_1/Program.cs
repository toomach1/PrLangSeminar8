//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = SetNumber("m");

int columns = SetNumber("n");

int[,] matrix = GetRandomMatrix(rows, columns, 25, 1);

System.Console.WriteLine();

PrintMatrix(matrix);

System.Console.WriteLine();

SortMatrix(matrix);

PrintMatrix(matrix);

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue, int minValue)
{
    int[,] matrixMetod = new int[rowsMetod, columnMetod];
    var random = new Random();
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            matrixMetod[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrixMetod;
}

void SortMatrix(int[,] InMatrix)
{
    int row = InMatrix.GetLength(0);
    int column = InMatrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {

        for (int j = 0; j < column; j++)
        {
            for (int k = j + 1; k < column; k++)
            {
                if (InMatrix[i, j] < InMatrix[i, k])
                {
                    int temp = InMatrix[i, j];
                    InMatrix[i, j] = InMatrix[i, k];
                    InMatrix[i, k] = temp;
                }
            }
        }
    }
}

void PrintMatrix(int[,] matrixMetod)
{
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
