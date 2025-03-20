using System;

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}
class Program
{
    static void Main()
    {
        // Ganti dengan dua digit dari NIM
        int angka1 = 10;
        int angka2 = 40;
        int angka3 = 52;

        // Tentukan tipe data berdasarkan digit terakhir NIM
        var hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine($"Hasil Penjumlahan: {hasil}");
        Console.ReadLine();
    }
}