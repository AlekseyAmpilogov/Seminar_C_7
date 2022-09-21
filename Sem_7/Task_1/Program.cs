Console.Write("Введите количество строк в двумерном массиве: ");
int strsCount = Convert.ToInt32(Console.ReadLine()); // число строк
Console.Write("Введите количество столбцов в двумерном массиве: ");
int columnsCount = Convert.ToInt32(Console.ReadLine()); // число столбцов

int[,] twoDimArray = new int[strsCount, columnsCount]; //создаем массив

Random rnd = new Random();
for (int i = 0; i < strsCount; i++)
{
    for (int j=0; j<columnsCount;j++) // вложенный цикл for выводит очередную строку
    {
        twoDimArray[i, j] = rnd.Next(1, 100); // заполняем массив числами от 1 до 100
        Console.Write("\t" + twoDimArray[i, j]); //выводим на экран полученный массив
    }
    Console.WriteLine();
}
Console.WriteLine();

