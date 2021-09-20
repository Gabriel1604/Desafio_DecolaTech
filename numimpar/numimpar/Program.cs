using System;

class minhaClasse
{

    public static void Main()
    {
        int n;
        n = int.Parse(Console.ReadLine());
        //complete seu codigo
        for (int X = 1; X <= n; X++) //complete seu codigo
        {
            if (X % 2 != 0)
            {
                Console.WriteLine(X);
            }
        }

        Console.ReadLine();
    }

}
