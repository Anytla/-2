using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length: ");
        int length = int.Parse(Console.ReadLine());
        int[] a = new int[length];
        int[] sum;
        int[] a1 = new int[length];

        Console.WriteLine("Enter the array: ");

        for (int i = 0; i < length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the count of rotation: ");

        int r = int.Parse(Console.ReadLine());

        //for (int i = 0; i < length; i++)
        //{
        //    a1[i] = (a[i] + r) % length;
        //    Console.Write(a1[i]);
        //}

        for (int i = 0; i != length; i++)
        {
            for (int j = i - 1; j != 0; j++)
            {

            }
        }

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(a[i]);
        }

        //int n = numbers.Length; 
        //int k = n / 2;          
        //int temp;               
        //for (int i = 0; i < k; i++)
        //{
        //    temp = numbers[i];
        //    numbers[i] = numbers[n - i - 1];
        //    numbers[n - i - 1] = temp;
        //}
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} \t");
        //}
    }
}
