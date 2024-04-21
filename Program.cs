using System;

class Program
{
    static void Main(string[] args) {
        int number;
        int summa = 0;
        int maxValue = 100;
        int digit1 = 3;
        int digit2 = 5;

        Random random = new Random();
        number = random.Next(0, (maxValue + 1));
        Console.Write("Рандомное число: ");
        Console.WriteLine(number);

        for (int i = 0; i <= number; i++)
        {
            if ((i % digit1 == 0) || (i % digit2 == 0))
                summa += i;
        }

        Console.Write($"Сумма чисел, кратных {digit1} и {digit2}: ");
        Console.WriteLine(summa);
    }
}
