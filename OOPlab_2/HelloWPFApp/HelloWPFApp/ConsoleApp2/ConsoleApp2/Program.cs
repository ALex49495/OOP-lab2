using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть значення n та k:");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Оберіть суму (1, 2 або 3):");
        int choice = int.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Sum1(k);
                break;
            case 2:
                result = Sum2(n, k);
                break;
            case 3:
                result = Sum3(n, k);
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                return;
        }

        Console.WriteLine($"Результат: {result:F3}");
    }

    static double Sum1(int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += Math.Pow(i, i);
        }
        return sum;
    }

    static double Sum2(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(i, k);
        }
        return sum;
    }

    static double Sum3(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / Math.Pow(n, i);
        }
        return sum;
    }
}
