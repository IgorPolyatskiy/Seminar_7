void GoodPrint(int[,] matrix, int rowsNumber, int columnsNumber)
{
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            Console.Write(matrix[rowIndex, columnIndex]);

            if (columnIndex != columnsNumber - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix, int rowsNumber, int columnsNumber)
{
    var rnd = new Random();
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            matrix[rowIndex, columnIndex] = rnd.Next(0, 10);
        }
    }
}

void PrintNumberAtInputPosition(int inputPosition, int columnsNumber, int[,] matrix)
{
    int resultRow = (inputPosition - 1) / columnsNumber;
    int resultColumn = (inputPosition - 1) % columnsNumber;

    int result = matrix[resultRow, resultColumn];
    Console.WriteLine($"{inputPosition} -> {result}");
}


int rowsNumber = 5;
int columnsNumber = 5;
int[,] matrix = new int[rowsNumber, columnsNumber];

FillMatrix(matrix, rowsNumber, columnsNumber);
GoodPrint(matrix, rowsNumber, columnsNumber);

int inputPosition = int.Parse(Console.ReadLine());
int maxPosition = rowsNumber * columnsNumber;

if (inputPosition > maxPosition || inputPosition < 1)
{
    Console.WriteLine($"{inputPosition} -> Такого числа в массиве нет");
}
else
{
    PrintNumberAtInputPosition(inputPosition, columnsNumber, matrix);
}