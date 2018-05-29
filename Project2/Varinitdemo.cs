// Demonstrasi usia suatu variabel
using System;

class VariableInitDemo
{
    static void Main()
    {
        int x;

        for (x = 0; x < 3; x++)
        {
            int y = -1; // y di iniliasisai setiap kali block dimasuki
            Console.WriteLine("y adalah: " + y); // selalu menampilkan -1

            y = 100;
            Console.WriteLine("y sekarang adalah menjadi: " + y);
        }
    }
}