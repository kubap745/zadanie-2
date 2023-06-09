using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double bmi, kg, m;

        Console.WriteLine("Podaj swoja wage w kilogramach np 56,7");
        kg = inputValue();

        Console.WriteLine("Podaj swoj wzrost w metrach np 1,87");
        m = inputValue();

        bmi = kg/Math.Pow(m,2);

        Console.WriteLine("Twoje bmi wynosi " + bmi);
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
