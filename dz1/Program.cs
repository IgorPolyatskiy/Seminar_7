double RandomNumberBetween(double minValue, double maxValue, Random rnd)
{
    var next = rnd.NextDouble();
    return minValue + (next * (maxValue - minValue));
}

void GoodPrint(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentRowLength = matrix.GetLength(1);
        for (int j = 0; j < currentRowLength; j++)
        {
            Console.Write(matrix[i, j].ToString("F1"));
            if (j != currentRowLength - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

int ReadDimension(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());

}

void FillArray(double[,] matrix, Random rnd)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomNumberBetween(-10, 10, rnd);
        }
    }
}

int m = ReadDimension("Введите m: ");
int n = ReadDimension("Введите n: ");
double[,] matrix = new double[m, n];
Random rnd = new Random();
FillArray(matrix, rnd);
GoodPrint(matrix);