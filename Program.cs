namespace APBD;

using System;

class MaxValue {

    public static int MaxMethod(int[] numbers)
    {
        if( numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica pusta, błąd");
        }
        int maxValue=numbers[0];
        foreach(int number in numbers)
        {
            if(number > maxValue)
            {
                maxValue=number;
            }
        }
        return maxValue;
    }
    static void Main (string [] args)
    {
        int[] numbersArray={3,5,6,9,12,10,14,8,2};
        int max= MaxMethod(numbersArray);
        Console.WriteLine("Max value if given is " + max);
    }
}
	