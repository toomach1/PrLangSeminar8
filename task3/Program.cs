//  Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.\


int rows = SetNumber("m");

int columns = SetNumber("n");

int[,] matrix = GetRandomMatrix(rows,columns, 3, 1);

int[] rowAr = GetRowArray(matrix);
System.Console.WriteLine();

PrintMatrix(matrix);

// System.Console.WriteLine();

// PrintArray(rowAr);

SortArray(rowAr);

System.Console.WriteLine();

PrintArray(rowAr);

System.Console.WriteLine();

PrintData(rowAr);


int[] GetRowArray(int[,] InArray)
{
    int[] result = new int[InArray.GetLength(0)*InArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            result[index] = InArray[i,j];
            index++;
        }
    }
    return result;
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      System.Console.Write(arr[i]+ " ");  
    }
}

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue, int minValue)
{
    int[,] matrixMetod = new int[rowsMetod,columnMetod];
    var random = new Random();
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            matrixMetod[i,j] =random.Next(minValue,maxValue+  1);
        }
    }
    return matrixMetod;
}

// int[] GetRandomArray(int size, int begin, int last)
// {
//     int[] arr = new int [size];
//     Random random = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = random.Next(begin, last+1);
//     }

//     return arr;
// }

void SortArray(int[] InArray)
{
    for (int i = 0; i < InArray.Length; i++)
    {
        for (int j = i+1; j < InArray.Length; j++)
        {
            if(InArray[i]>InArray[j])
            {
                int k = InArray[i];
                InArray[i] = InArray[j];
                InArray[j]=k;
            }
        }
    }
}

void PrintData(int[] InArray)
{
    int el = InArray[0];
    int count = 1;
    for (int i = 1; i < InArray.Length; i++)
    {
        if(InArray[i] !=el)
        {
            System.Console.WriteLine($"{el} встречается {count} раз(а)");
            el = InArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    System.Console.WriteLine($"{el} встречается {count} раз(а)");
}