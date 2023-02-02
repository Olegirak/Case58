/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}
int[,] get2DDoubleArray(int colLength,
                        int rowLength,
                        int start,
                        int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
void print2Darray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int [,] ProizxMatric(int [,] mas1, int [,] mas2)
{
    int [,] prmatr = new int [mas1.GetLength(0),mas2.GetLength(1)];
    for (int i =0; i< mas1.GetLength(0);i++)
    {
        for (int j = 0; j< mas2.GetLength(1);j++)
        {
            int sum = 0;
            for (int k = 0; k< mas1.GetLength(0);k++)
            {
                    sum = sum + mas1[i,k]*mas2[k,j];

            }
            prmatr[i,j]=sum;
        }
    }
    return prmatr;
}









int n1 = GetDataFromUser("Введите количество строк матрицы 1");
int m1 = GetDataFromUser("Введите количество столбцов матрицы 1");
int[,] Array1 = get2DDoubleArray(n1, m1, 1, 5);
int n2 = GetDataFromUser("Введите количество строк матрицы 2");
int m2 = GetDataFromUser("Введите количество столбцов матрицы 2");
int[,] Array2 = get2DDoubleArray(n2, m2, 1, 15);
print2Darray(Array1);
print2Darray(Array2);
if (n1 != m2)
{
    Console.Write("Произведение матриц невозможно");
}
else
{
    print2Darray(ProizxMatric(Array1,Array2));
}
