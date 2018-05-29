// Mengunakan nilai bool.
using System;

class DemoBool
{
    static void Main()
    {
        bool b;

        b = false;
        Console.WriteLine("b adalah " + b);
        b = true;
        Console.WriteLine("b adalah " + b);

        // Nilai bool dapat mengendalikan statement if.
        if (b) Console.WriteLine("ini dieksekusi.");

        b = false;
        if (b) Console.WriteLine("ini tidak dieksekusi");

        // Keluaran dari operator relasional adalah nilai bool.
        Console.WriteLine("10 > 9 adalah " + (10 > 9));
    }
}