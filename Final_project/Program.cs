Console.WriteLine("Введите размер массива");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите размер массива");   
}

int i = 0;
string[] arr = new string[N];

while (i<N)
{
    Console.WriteLine ($"Введите {i+1} элемент массива");
    arr[i] = Console.ReadLine();
    i++;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

void CountAndNewArr(string[] arr)
{
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    string[] arr2 = new string[count];

    count = 0;
    int i2 = 0;
    for (int i = 0; i < N; i++)
    {
        if (arr[i].Length <= 3) 
        {
            arr2[i2] = arr[i];
            i2++;
        }
    }
    Console.WriteLine();
    Console.WriteLine ("Отсортированный массив:");
    PrintArray(arr2);
}

Console.WriteLine();
Console.WriteLine ("Массив:");
PrintArray(arr);
CountAndNewArr(arr);



