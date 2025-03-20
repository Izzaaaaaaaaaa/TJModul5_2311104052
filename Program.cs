using System;
using System.Collections.Generic;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
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

        // Buat objek SimpleDataBase
        SimpleDataBase<int> database = new SimpleDataBase<int>();

        // Tambahkan data
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        // Cetak hasil
        database.PrintAllData();
    }
}