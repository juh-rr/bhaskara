using System;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, R1, R2, delta;

        string[] vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0]);
        B = double.Parse(vet[1]);
        C = double.Parse(vet[2]);
        delta = Math.Pow(B, 2) - 4 * A * C;

        if (A == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            R2 = (-B - Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine("R1 = " + R1.ToString("F5"));
            Console.WriteLine("R2 = " + R2.ToString("F5"));
        }

    }

