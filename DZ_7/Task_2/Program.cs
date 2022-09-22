Console.Write("Введите строку искомого элемента: ");
int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец искомого элемента: ");
int position2 = Convert.ToInt32(Console.ReadLine()) - 1;
int strsCount = 5; 
int columnsCount = 7;
Random rnd = new Random();
int[,] array = new int[strsCount, columnsCount];
Console.WriteLine("\nСлучайный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(-99, 99);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (position1 < 0 | position1 > array.GetLength(0) - 1 | position2 < 0 | position2 > array.GetLength(1) - 1)
{
    Console.WriteLine("\nИскомый элемент в массиве не существует");
}
else
{
    Console.WriteLine("Значение искомого элемента в массиве = {0}", array[position1, position2]);
}
