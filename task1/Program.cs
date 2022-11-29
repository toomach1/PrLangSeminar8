// задайте двумерный массив. напишите программу, которая поменяет местами первую и последнюю строку массива.

int rows = SetNumber("m");

int column = SetNumber("n");

int[,] matrix = GetRandomMatrix(rows, column, 20, 1);

// int[,] swapMatrix = NewSwapMatrix(matrix);

PrintMatrix(matrix);

System.Console.WriteLine();

int[,] newmatrix = NewSwapMatrix(matrix);

PrintMatrix(newmatrix);

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue = 100, int minValue = -100)
{
    int[,] matrixMetod = new int[rows, column];
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

static  int[,] NewSwapMatrix(int[,] OldMatrix)
{
    

    int[,] matrixRet = OldMatrix;

    for (int j = 0; j < matrixRet.GetLength(1); j++)
    {
        
        int temp = matrixRet[0, j];
        matrixRet[0, j] = matrixRet[matrixRet.GetLength(0) - 1, j];
        matrixRet[matrixRet.GetLength(0) - 1, j] = temp;
    }
    
    return matrixRet;
}

void PrintMatrix(int[,] PrintMatrixMetod)
{
    for (int i = 0; i < PrintMatrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < PrintMatrixMetod.GetLength(1); j++)
        {
            System.Console.Write($"{PrintMatrixMetod[i, j]} ");
        }
        System.Console.WriteLine();
    }
}