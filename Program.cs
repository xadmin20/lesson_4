// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);
int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++) array[i] = rd.Next(1, 100);
    return array;
}

void printArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i==0) Console.Write($"[{Array[i]}, ");
        else if (i>0 && i!=N-1) Console.Write($"{Array[i]}, ");
        else Console.WriteLine($"{Array[i]}]");
    }
    Console.Write("");
}

printArray(arr);