// Demonstrasi tipe variable secara implisit
using System;

class Variabelbertipeimplisit
{
    static void Main()
    {
        // Berikut ini adalah variable bertipe implisit.
        // Keduanya bertipe double karena expresi
        // penginiliasian bertipe double.
        var s1 = 4.0;
        var s2 = 5.0;

        // Sekarang, sisi_miring bertipe implisit.Tipenya double
        // Karena tipe nilai balik dari Sqrt(0 adalah double.
        var sisi_miring = Math.Sqrt((s1 * s1) + (s2 * s2));

        Console.Write("Sisi Miring dari suatu segitiga dengan kedua sisi " + s1 + " dan " + s2 + " adalah ");

        Console.Write("{0:#.###}.\n", sisi_miring);
        // Statement barikut idak dikompilasi karena
        // s1 adalah sebuah double dan tidak ditugasi nilai desimal.
        // s1 = 12.2M; // Error;
    }
}