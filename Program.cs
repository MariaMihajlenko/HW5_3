//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int s = 5;
        int[] a = new int[s];
        int max = 0; int min = 100;
        for (int i = 0; i < s; i++)
            a[i] = random.Next(100);
          { for (int i = 0; i <  s; i++)
            Console.Write(" "  +a[i]);}
        for (int i = 0; i < s; i++)
        {
            if (a[i] < min) 
            min = a[i];
            if (a[i] > max) 
           max = a[i];
            
        }
        
        Console.WriteLine("  ");
        Console.WriteLine("Разность max и min:");
        Console.Write(+(max - min));
        
    }

}


