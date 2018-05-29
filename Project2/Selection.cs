using System;

namespace DataKaryawan
{
    class Switch
    {
        static void Main(string[] args)
        {

            int lembur;

            //kode inputan 		
            Console.WriteLine("Masukkan Nama Karyawan : ");
            string nama = Console.ReadLine();
            //dibawah ini adalah pernyataan kondisional do-while
            do
            {

                //kode inputan 
                Console.WriteLine("Masukkan Jam Lembur (0 - 10) : ");
                lembur = int.Parse(Console.ReadLine());
                //int lembur = Convert.ToInt32(Console.ReadLine());  ini adalah alternatif dari int.Parse

                //dibawah ini adalah pernyataan kondisional if
                if (lembur > 10 || lembur < 0)
                {
                    Console.WriteLine("Error: Angka harus diantara 0-10");
                    Console.WriteLine("");
                }

                //pernyataan while
            } while (lembur > 10 || lembur < 0);


            Console.WriteLine("Masukkan Grade Karyawan (A-E): ");
            char pilih = char.Parse(Console.ReadLine());

            //logika perhitungan gaji
            int bonuslembur = 600000 * lembur;
            int gaji = 4500000 + bonuslembur;

            Console.WriteLine("");
            Console.WriteLine("Nama Pegawai : " + nama);
            Console.WriteLine("Jam Lembur : " + lembur);
            Console.WriteLine("Gaji yang diperoleh : " + gaji);

            switch (pilih)
            {
                case 'A':
                    Console.WriteLine("He Is The Real Great Employer !");
                    goto default; //Harus ditambahkan Jump Statement
                case 'B':
                    Console.WriteLine("Dia Pekerja Keras !");
                    goto default;  //Harus ditambahkan Jump Statement
                case 'C':
                    Console.WriteLine("Motivasi Dia !");
                    goto default;  //Harus ditambahkan Jump Statement
                case 'D':
                    Console.WriteLine("Peringatkan Dia !");
                    goto default;  //Harus ditambahkan Jump Statement
                case 'E':
                    Console.WriteLine("Beri Dia Surat Peringatan (SP) !");
                    goto default;  //Harus ditambahkan Jump Statement				
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Program Selesai");
                    break;  //Harus ditambahkan Jump Statement
            }

            Console.WriteLine("");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}