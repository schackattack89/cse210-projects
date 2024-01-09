using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 0;
        do
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while(number !=0);
        int sum = 0;
        for (int i = 0; i<numbers.Count; i++){
            sum+=numbers[i];
        }
        float average = ((float)sum)/(numbers.Count-1);
        int max = numbers[0];
        for (int i = 0; i<numbers.Count; i++){
            if(numbers[i]>max){
                max = numbers[i];
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}