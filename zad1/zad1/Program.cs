using System;

public class Helpers
{
    public static int Binary(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Dane wejściowe nie mogą być ujemne!!!");
        }

        int count = 0;
        string binary = Convert.ToString(number, 2);

        foreach (char digit in binary)
        {
            if (digit == '1')
            {
                count++;
            }
        }

        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int input = int.Parse(Console.ReadLine());

        try
        {
            int result = Helpers.Binary(input);
            Console.WriteLine("Wynik: " + result);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Błąd: " + e.Message);
        }
    }
}
