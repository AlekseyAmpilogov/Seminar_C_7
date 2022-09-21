Console.Clear();

double[,] array = new double[3, 4];
Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToDouble(rnd.Next(-1000, 1000)/100.0);
        Console.Write("\t" + array[i, j]);
    }
    Console.WriteLine();
}
