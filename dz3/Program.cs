int RandomNumberBetween(Random rnd)
{
    return rnd.Next(0, 10);
}

void GoodPrint(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentRowLength = matrix.GetLength(1);
        for (int j = 0; j < currentRowLength; j++)
        {
            Console.Write(matrix[i, j]);
            if (j != currentRowLength - 1)
            {
                Console.Write("; ");
            }
        }
        Console.WriteLine();
    }
}

int GetIntFromConsole(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());

}

void FillArray(int[,] matrix, Random rnd)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = RandomNumberBetween(rnd);
        }
    }
}

void PrintColumnAverage(int columnIndex, int[,] matrix, int rowsNumber, int columnsNumber)
{
    double sum = 0.0;
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        sum = sum + matrix[rowIndex, columnIndex];
    }

    double average = sum / rowsNumber;
    Console.Write(average.ToString("0.#"));

    if (columnIndex != columnsNumber - 1)
    {
        Console.Write("; ");
    }
}

int rowsNumber = GetIntFromConsole("Введите количество строк: ");
int columnsNumber = GetIntFromConsole("Введите количество столбцов: ");
int[,] matrix = new int[rowsNumber, columnsNumber];
FillArray(matrix, new Random());
GoodPrint(matrix);

Console.WriteLine(new string('-', columnsNumber * 3));
for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
{
    PrintColumnAverage(columnIndex, matrix, rowsNumber, columnsNumber);
}