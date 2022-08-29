// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] arr = new double[5, 10];

Random random = new Random();

void PrintArray(double[,] matr)
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

void FillArray(double [,]matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        arr[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2} ", arr[i, j]);
    }
    Console.WriteLine();
}
}

FillArray(arr);
//PrintArray(arr);

//создал метод для вывода печати PrintArray, но при его активации дважды выводит массив -
// в первом варианте округлен до 2-х знаков после запятой, 
// а во втором варианте без округления
//при его деактивации соответсвенно выыодит только один масси с числами
//вопрос: обязательно ли создавать метод печати массива(PrintArray)?