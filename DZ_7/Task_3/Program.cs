double[,] array = new double[5, 5]; //задаем массиву количесто строк и столбцов
Random rnd = new Random();
newArray(array);
avgArray(array);
void newArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rnd.Next(1, 10));
            Console.Write(" {0} ", array[i, j]); //вывод полученного массива построчно
        }
        Console.WriteLine();
    }
}

void avgArray(double[,] array)
{
    Console.Write("\nСреднеарифметическое каждого столбца = ");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($" {sum / array.GetLength(0)} ");
    }
}