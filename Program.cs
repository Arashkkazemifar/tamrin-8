using System;

class tavan2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(tavan(number));
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
    }
    public static int tavan(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return 2 * tavan(number - 1);
        }
    }
}
