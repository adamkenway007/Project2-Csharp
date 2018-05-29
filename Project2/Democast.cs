// Demonstrasi operasi cast.
using System;

class DemoCast {
    static void Main()
    {
        double x, y;
        byte b;
        int i;
        char ch;
        uint u;
        short s;
        long l;

        x = 10.0;
        y = 3.0;

        // Cast double menjadi int, komponen pecahan hilang.
        i = (int)(x / y);
        Console.WriteLine("Keluaran integer dari x / y: " + i);
        Console.WriteLine();

        // Cast int menjadi byte, tidak ada data hilang.
        i = 255;
        b = (byte)i;
        Console.WriteLine("b setelah penugasan 255: " + b + " -- tidak data hilang.");

        // Cast int menjadi byte, data hilang.
        i = 257;
        b = (byte)i;
        Console.WriteLine("b setelah penugasan 257: " + b + " -- data hilang.");
        Console.WriteLine();

        // Cast uint menjadi short, tidak ada data hilang.
        u = 32000;
        s = (short)u;
        Console.WriteLine("s setelah data penugasan 32000: " + s + " -- tidak ada data hilang.");

        // Cast uint menjadi short, data hilang.
        u = 64000;
        s = (short)u;
        Console.WriteLine("s setelah penugasan 64000: " + s + " -- data hilang.");
        Console.WriteLine();

        // Cast long menjadi uint, tidak ada data hilang.
        l = 64000;
        u = (uint)l;
        Console.WriteLine("u setelah penugasan 64000: " + u + " -- tidak ada data hilang.");

        // Cast dari long menjadi uint, data hilang.
        l = -12;
        u = (uint)l;
        Console.WriteLine("u setelah penugasan -12: " + u + " -- data hilang.");
        Console.WriteLine();

        // Cast int menjadi char.
        b = 88; // Kode ASCII untuk x
        ch = (char)b;
        Console.WriteLine("ch setelah penugasan  88: " + ch);

        }
    }