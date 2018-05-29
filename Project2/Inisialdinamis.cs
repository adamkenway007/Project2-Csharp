// Demonstrasi inisialisasi dinamis.
using System;

class InisialDinamis
{
    static void Main()
    {
        // Panjang kedua sisi.
        double s1 = 4.0;
        double s2 = 5.0;

        // Secara dinamis menginialisasi sisi miring.
        double sisi_miring = Math.Sqrt((s1 * s1) + (s2 * s2));
        Console.WriteLine("Sisi Miring suatu segitiga dengan kedua di isi " + s1 + " dan " + s2 + " adalah ");

        Console.WriteLine("{0:#.###}.", sisi_miring);
    }
}