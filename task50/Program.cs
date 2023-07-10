//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец


int rows = Prompt("Введите количество строк массива: ");
int colums = Prompt("Введите количество столбцов массива: ");
int [,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;
}
 
 void PrintArray (int [,] arr)
 {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
 }

int rowX = Prompt("Введите номер строки нужного элемента: ");
int columnX = Prompt("Введите номер столбца нужного элемента: ");
ValueX(array);

 void ValueX(int [,] arr)
 {
    if (rowX >= arr.GetLength(0)+1 || columnX >= arr.GetLength(1)+1)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        int X = arr [rowX-1,columnX-1];
        Console.WriteLine($"Этот элемент = {X}");
        
    }
 }
 
