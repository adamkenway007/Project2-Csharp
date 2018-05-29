// Demonstrasi konversi implisit dari long ke double.
using System;

class LtoD
{
    static void Main()
    {
        long L;
        double D;

        L = 100123285L;
        D = L;

        Console.WriteLine("L dan D: " + L + " " + D);
    }
}