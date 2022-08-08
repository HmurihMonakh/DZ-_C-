//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

/*Console.WriteLine("Введите число : ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());

int Stepen(int A, int B)
{
    int sum = 1;

    for (int i = 1; i <= B; i++)
    {
        sum = sum * A;
    }
    return sum;

}
Console.WriteLine(Stepen(A, B));*/

Console.Write("Введите число 'А': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'В': ");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;
for (int i = 1; i < b; i++)
    {
        degree = degree * a;
    }
Console.Write($"{a} в степени {b} равно {degree}");





