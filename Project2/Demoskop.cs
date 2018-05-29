// Demonstrasi skop blok.
using System;

class DemoSkop
{
    static void Main()
    {
        int x; // di kenali oleh semua kode di dalam Main()
        int z;

        z = 2;
        x = 10;
        if  ((z == 2) && ( x == 10) )
        { // mulai skop baru
            int y = 20; // hanya dikenali di dalam blok ini
            int m = 5;
            byte l = 50;
            

            // x,l dan y keduanya dikenali di sini.
            Console.WriteLine("x dan y: " + x + " " + y);
            Console.WriteLine("x ditambah y: " + (x + y));
            Console.WriteLine("x dikurangi y: " + (x - y));
            Console.WriteLine("x dikali y: " + (x * z));
            Console.WriteLine("x dibagi m: " + (x / m));
            Console.WriteLine("l dibagi x dikali m: " + (l / x) * m);
       
        }
        
        { // mulai skop baru ke 2
            int a = 3;
            int b = 4;

           
            // a dan b keduanya dikenali di sini.
            Console.WriteLine("-------------------------");
            Console.WriteLine("x dan a: " + x + " " + a);
            Console.WriteLine("b ditambah a: " + (b + a));
            Console.WriteLine("x dikurangi b: " + (x - b));
        
        }
        // y = 100; // Error! y tidak dikenal di sini.
        // x masih dikenali di sini

        Console.WriteLine("x adalah " + x);
    }
}