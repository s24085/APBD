namespace APBD;

using System;

class Average
{
     public static double GetAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty");
        }

        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }

    static void Main(string[] args)
    {
        int[] numbersArray = { 21, 24, 31, 4, 59 };
        double average = GetAverage(numbersArray);
        Console.WriteLine("Avegrage of numbers given is: " + average);
    }
}


