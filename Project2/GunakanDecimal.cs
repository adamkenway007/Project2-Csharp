// Menggunakan format C untuk menampilkan dollar dan cent;
using System;

class GunakanDecimal
{

    static void Main() {
        decimal harga;
        decimal diskon;
        decimal harga_diskon;

        // Menghitung harga diskon.
        harga = 19.95m;
        diskon = 0.15m; // persen diskon 15%

        harga_diskon = harga - (harga * diskon);

        Console.WriteLine("Harga setelah diskon: {0:C}",harga_diskon);
    }
}