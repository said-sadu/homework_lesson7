Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToInt32(new Random().Next(0, 21));
        }
        Console.WriteLine();
    }
}

void Math(int[,] matr)
{
    Console.WriteLine("Введите координаты");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > m && b > n)
        Console.WriteLine("такого числа нет");
    else
    {
        object c = matr.GetValue(a, b);
        Console.WriteLine(c);
    }
}


int[,] matrix = new int[m, n];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
Math(matrix);