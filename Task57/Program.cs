// 57. Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

Console.Clear();

int[,] matrix = CreateMatrixInt(4, 4, 1, 5);
PrintMatrix(matrix);

int[] arrUniqueElem = GetArrUniqueElements(matrix);
int[,] dictionary = CreateDictionary(matrix, arrUniqueElem);
PrintDictionary(dictionary);

//////////////////////////////////////////////////////////////////////////////
int[,] CreateMatrixInt(int countRows, int countColumns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[countRows, countColumns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] CreateDictionary(int[,] matrix, int[] uniqueElements)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    int countElements = uniqueElements.Length;
    int[,] dictionary = new int[countElements, 2];

    for (int i = 0; i < countElements; i++)
    {
        int element = uniqueElements[i];
        dictionary[i, 0] = element;

        int count = 0;
        for (int r = 0; r < numRows; r++)
        {
            for (int c = 0; c < numCols; c++)
            {
                if (matrix[r, c] == element)
                {
                    count++;
                }
            }
        }
        dictionary[i, 1] = count;
    }
    return dictionary;
}

int[] GetArrUniqueElements(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    int[] uniqueElements = new int[numRows * numCols];
    int numUniqueElements = 0;

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            int element = matrix[i, j];
            bool isUnique = true;

            for (int k = 0; k < numUniqueElements; k++)
            {
                if (uniqueElements[k] == element)
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                uniqueElements[numUniqueElements] = element;
                numUniqueElements++;
            }
        }
    }

    int[] resultUniqueElements = new int[numUniqueElements];

    for (int i = 0; i < numUniqueElements; i++)
    {
        resultUniqueElements[i] = uniqueElements[i];
    }

    return resultUniqueElements;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDictionary(int[,] dictionary)
{
    for (int i = 0; i < dictionary.GetLength(0); i++)
    {
        int elem = dictionary[i, 0];
        int count = dictionary[i, 1];

        Console.WriteLine($"Элемент {elem} встречается {count} раз(а)");
    }
}