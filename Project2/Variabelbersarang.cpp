/*
Program ini mencoba mendeklarasikan sebuah variable
di dalam skop sebelah dalam dengan nama sama dengan
variable yang didefinisikan di dalam skop sebelah luar.
*** Program ini tak akan bisa di kompilasi *** 
 */
/*using System;

class VariabelBersarang {
    static void Main() {
    int hitung;
    for (hitung = 0; hitung < 10; hitung = hitung + 1)
    {
        Console.WriteLine("Ini adalah hitung: " + hitung);
        int hitung; // illegal!!!
        for (hitung = 0; hitung < 2; hitung++)
            Console.WriteLine("Program ini bermasalah");
    }
  }
}
*/