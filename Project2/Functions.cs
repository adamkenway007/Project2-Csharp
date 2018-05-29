//Tambahkan mengunakan directive dari System apabila directive tidak muncul.

public class Functions
{
    public static long Factorial(int n)
    {
        // Test untuk input yang tidak sesuai
        if ((n < 0) || (n > 20))
        {
            return -1;
        }

        // Kalkulasikan factorial iteratively dari pada recursively:
        long tempResult = 1;
        for (int i = 1; i <= n; i++)
        {
            tempResult *= i;
        }
        return tempResult;
    }
}

class MainClass
{
    static int Main(string[] args)
    {
        // Test apabila input argument tidak tersedia:
        if (args.Length == 0)
        {
            System.Console.WriteLine("Mohon Masukkan argument numeric .");
            System.Console.WriteLine("Kegunaan: Factorial <num>");
            return 1;
        }

        // Coba untuk convert nilai input arguments menjadi nomer. Ini akan membuang
        // suatu pengecualian apabila argument bukanlah suatu nomer.
        // num = int.Parse(args[0]);
        int num;
        bool test = int.TryParse(args[0], out num);
        if (test == false)
        {
            System.Console.WriteLine("Mohon Masukkan argument numeric .");
            System.Console.WriteLine("Kegunaan: Factorial <num>");
            return 1;
        }

        // Kalkulasikan factorial.
        long result = Functions.Factorial(num);

        // Print Hasilnya.
        if (result == -1)
            System.Console.WriteLine("Input Harus >= 0 dan <= 20.");
        else
            System.Console.WriteLine("Factorial dari {0} adalah {1}.", num, result);

        return 0;
    }
}
// Apabila angka 3 di ditekan pada command line.
// output Akan Membacanya: factorial dari 3 adalah 6.