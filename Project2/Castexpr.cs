// Mengunakan cast di dalam sebuah ekspresi.
using System;

class CastExpr
{
    static void Main()
    {
        double n;

        for (n = 1.0; n <= 10; n++)
        {
            Console.WriteLine("Akar kuadrat atas {0} adalah {1}", n, Math.Sqrt(n));
            Console.WriteLine("Bagian angka bulat: {0}", (int)Math.Sqrt(n));
            Console.WriteLine("Bagian pecahan: {0}", Math.Sqrt(n) - (int)Math.Sqrt(n));
            Console.WriteLine();
        }
    }
}