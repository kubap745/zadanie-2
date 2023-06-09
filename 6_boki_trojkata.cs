using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwszy bok trójkąta");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok trójkąta");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok trójkąta");
        c = inputValue();
        if (a == b)
        {
            if (b == c)
            { Console.WriteLine("Podane boki tworzą trójkąt równoboczny"); }
            else
            { Console.WriteLine("Podane boki nie tworzą trójkątu równobocznego"); }
        }
        else
        { Console.WriteLine("Podane boki nie tworzą trójkątu równobocznego"); }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}