using System;

namespace MedellonBerakning
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] loner = new double[3];

            // Be användaren mata in lönen för tre anställda
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ange lön för anställd {i + 1}: ");
                loner[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Beräkna medellönen
            double medellon = (loner[0] + loner[1] + loner[2]) / 3;

            // Skriv ut medellönen
            Console.WriteLine($"Medellönen för personalen är: {medellon:F2} kr");
        }
    }
}
