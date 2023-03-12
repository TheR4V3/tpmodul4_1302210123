using System;
using System.Collections.Generic;

class kodePos
{
    private Dictionary<string, string> KodePos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string GetKodePos(string kelurahan)
    {
        if (KodePos.ContainsKey(kelurahan))
        {
            return KodePos[kelurahan];
        }
        else
        {
            return "Kode Pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        kodePos kp = new kodePos();
        Console.Write("Masukkan nama Kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine("Kode pos dari kelurahan " + kelurahan + " adalah " + kp.GetKodePos(kelurahan));
    }
}


