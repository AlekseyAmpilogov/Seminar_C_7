Console.Clear();

int[,] array = new int[4, 5];
Random rnd = new Random();

Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 9);
        Console.Write("\t" + array[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("Преобразованный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.Write("\t" + array[i, j]);
    }
    Console.WriteLine();
}