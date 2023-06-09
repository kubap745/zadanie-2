using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double pole, r, obwod;

        Console.WriteLine("Podaj wartosc pola okregu");

        pole = inputValue();

        r = Math.Sqrt(pole - 3.14);

        obwod = 2 * 3.14 * r;

        Console.WriteLine("Obwod okręgu wynosi "+obwod);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
