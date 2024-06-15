using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número N para os primeiros números da sequência de Fibonacci: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("N deve ser maior ou igual a 1.");
            return;
        }

        if (N == 1)
        {
            Console.WriteLine("Os primeiros números de Fibonacci são: 0");
            return;
        }

        int[] fibonacci = new int[N];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < N; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.Write("Os primeiros números de Fibonacci são: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(fibonacci[i]);
            if (i < N - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}