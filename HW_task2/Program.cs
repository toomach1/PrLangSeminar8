//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = SetNumber("m");

int columns = SetNumber("n");

int[,] matrix = GetRandomMatrix(rows, columns, 5, 1);
PrintMatrix(matrix);

int minSummLine = 0;
int SummLine = SummLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSummLine = SummLineElements(matrix, i);
  if (SummLine > tempSummLine)
  {
    SummLine = tempSummLine;
    minSummLine = i;
  }
}

Console.WriteLine($"{minSummLine+1} - строкa с наименьшей суммой элементов ");

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

int SummLineElements(int[,] matrix, int i)
{
  int SummLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    SummLine += matrix[i,j];
  }
  return SummLine;
}

void PrintMatrix(int[,] matrixMetod)
{
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            System.Console.Write($"{matrixMetod[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
