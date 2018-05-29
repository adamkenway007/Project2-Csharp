// Menggunakan Perintah format
using System;

class OpsiPenampilan
{
    static void Main()
    {
        int i;

        Console.WriteLine("Nilai\tKuadrat\tKubik");
        for (i = 1; i < 10; i++)
            Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
    }
}