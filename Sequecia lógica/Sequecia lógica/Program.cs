using System;

public class Program
{

    public static void Main(string[] args)
    {

        int i = 0;

        string[] vet = Console.ReadLine().Split(" ");

       int x = int.Parse(vet[0]);

       int y = int.Parse(vet[1]);

        for (i = 1; i <= y; i++)
        {

            Console.Write(" {0}", i);

            if (i % x == 0)

                Console.Write("\n");

        }

    }

}