
//Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());//452

int SumNumbers(int numbers)
{

    int result = 0;
    int sum = 0;
    while(numbers > 0)
        {
            result = numbers % 10;//452 % 10 = 2result
            sum = sum + result;// 2 + 0 = 2(sum)
            numbers = numbers / 10;
        } 
        return sum;
        //Console.WriteLine(sum);// sum вывожу сумму заданных чисел
}
Console.WriteLine(SumNumbers(numbers));

/*Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());//452

int SumNumbers(int numbers)
{
    int result = 0;
    int sum = numbers;
    for (int i = 0; i < numbers.ToString().Length; i++)
    {
        result = result + sum % 10;
        sum = sum / 10; 
    }    
    return result;

}
Console.WriteLine(SumNumbers(numbers));
*/








