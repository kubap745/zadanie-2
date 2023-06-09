﻿using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, wynik;

      
        Console.WriteLine("Podaj cyfre odpowiadającą działaniu (1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie )");
        c = inputValue();
        Console.WriteLine("Podaj pierwszą liczbe");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbe");
        b = inputValue();

        if (c == 1)
        {
            wynik = a + b;
            Console.WriteLine($"Wynik wynosi:" + wynik);
        }
        else if (c == 2)
        {
            wynik = a - b;
            Console.WriteLine($"Wynik wynosi:" + wynik);
        }
        else if (c == 3)
        {
            wynik = a * b;
            Console.WriteLine($"Wynik wynosi" + wynik);
        }
        else if (c == 4)
        {
            if (b != 0)
            {
                wynik = a / b;
                Console.WriteLine($"Wynik wynosi:" + wynik);
            }
            else
            {
                Console.WriteLine($"Wynik wynosi: " +a+"/"+b);
            }
        }
        else
        {
            Console.WriteLine("Nie wybrano prawidłowej cyfry działania");
        }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}