using System;

class URI
{

    static void Main(string[] args)
    {
        int n = 0;
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        do
        {
            
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    alcool++;
                    continue;

                case 2:
                    gasolina++;
                    continue;
                case 3:
                    diesel++;
                    continue;
                case 4:
                    n = 4;
                    break;
                default:
                    continue;
            }
        }

        while (n != 4);
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesiel: {diesel}");
    }

}