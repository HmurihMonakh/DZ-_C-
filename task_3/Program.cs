
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33] 

int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray(); 
foreach (int i in a)
  Console.WriteLine(i);









