// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


internal class Program
{
    private static void Main(string[] args)
    {
        int rows = SetNumber("m");

        int column = SetNumber("n");

        int[,] matrix = GetRandomMatrix(rows, column, 50, 10);

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

        static int[,] NewSwapMatrix(int[,] OldMatrix)
        {
            int row = OldMatrix.GetLength(0);
            int colum = OldMatrix.GetLength(1);
            int[,] matrixMetod = new int[colum, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    matrixMetod[j, i] = OldMatrix[i, j];
                }
            }
            return matrixMetod;
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
    }
}