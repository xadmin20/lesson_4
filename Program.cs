// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void sqr()
    {   
    Console.Write("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень числа: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int temp = A;
    for (int i = 1; i < B; i++) temp = temp*A;
    Console.WriteLine(temp); 
    }

sqr();