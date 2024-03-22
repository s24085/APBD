namespace APBD;

using System;

class MaxValue {

    public static int MaxMethod(int[] numbers)
    {
        if( numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica pusta, błąd");
        }
        int MaxValue=numbers[0];
        foreach(int number in numbers)
        {
            if(number > MaxValue)
            {
                MaxValue=number;
            }
        }
        return MaxValue;
    }
    static void Main (string [] args)
    {
        int[] numbersArray={3,5,6,9,12,10,14,8,2};
        int max= MaxMethod(numbersArray);
        Console.WriteLine("Max value if given is " + max);
    }
}
	