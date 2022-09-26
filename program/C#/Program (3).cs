using System;

public class Inheritance
{
    public static void Main(String[] args)
    {
    menu:
        Console.WriteLine("Menu Bangun Datar : ");
        Console.WriteLine("1. Persegi \n2. Lingkaran \n3. Persegi Panjang \n4. Segitiga");
        Console.Write("Silahkan pilih bangun datar yang ingin dihitung luas dan kelilingnya");
        string pilih = Console.ReadLine();
        Console.WriteLine("");

        // membuat objek bangun datar
        BangunDatar bangunDatar = new BangunDatar();

        // memanggil method luas dan keliling
        bangunDatar.luas();
        bangunDatar.keliling();

        if (pilih == "Persegi")
        {
            // membuat objek persegi dan mengisi nilai properti
            Persegi persegi = new Persegi();
            Console.WriteLine("\nMasukkan sisi persegi = ");
            persegi.sisi = float.Parse(Console.ReadLine());
            persegi.luas();
            persegi.keliling();
            Console.WriteLine("Apakah anda ingin kembali ke menu?(ya/tidak)");
            string backmenu = Console.ReadLine();
            if (backmenu == "ya")
            {
                goto menu;
            }
            else if (backmenu == "tidak")
            {
                Console.WriteLine("Program Berakhir");
            }
            else
            {
                Console.WriteLine("Program Berakhir");
            }
        }

        else if (pilih == "Lingkaran")
        {
            // membuat objek Lingkaran dan mengisi nilai properti
            Lingkaran lingkaran = new Lingkaran();
            Console.WriteLine("\nMasukkan jari-jari lingkaran = ");
            lingkaran.r = float.Parse(Console.ReadLine());

            lingkaran.luas();
            lingkaran.keliling();
            Console.WriteLine("Apakah anda ingin kembali ke menu?(ya/tidak)");
            string backmenu = Console.ReadLine();
            if (backmenu == "ya")
            {
                goto menu;
            }
            else if (backmenu == "tidak")
            {
                Console.WriteLine("Program Berakhir");
            }
            else
            {
                Console.WriteLine("Program Berakhir");
            }
        }

        else if (pilih == "Persegi Panjang")
        {
            // membuat objek Persegi Panjang dan mengisi nilai properti
            PersegiPanjang persegiPanjang = new PersegiPanjang();
            Console.WriteLine("\nMasukkan panjang persegi = ");
            persegiPanjang.panjang = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan lebar persegi!");
            persegiPanjang.lebar = float.Parse(Console.ReadLine());

            persegiPanjang.luas();
            persegiPanjang.keliling();
            Console.WriteLine("Apakah anda ingin kembali ke menu?(ya/tidak)");
            string backmenu = Console.ReadLine();
            if (backmenu == "ya")
            {
                goto menu;
            }
            else if (backmenu == "tidak")
            {
                Console.WriteLine("Program Berakhir");
            }
            else
            {
                Console.WriteLine("Program Berakhir");
            }
        }

        else if (pilih == "Segitiga")
        {
            // membuat objek Segitiga dan mengisi nilai properti
            Segitiga mSegitiga = new Segitiga();
            Console.WriteLine("\nMasukkan alas segitiga = ");
            mSegitiga.alas = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi segitiga = ");
            mSegitiga.tinggi = float.Parse(Console.ReadLine());

            mSegitiga.luas();
            mSegitiga.keliling();
            Console.WriteLine("Apakah anda ingin kembali ke menu?(ya/tidak)");
            string backmenu = Console.ReadLine();
            if (backmenu == "ya")
            {
                goto menu;
            }
            else if (backmenu == "tidak")
            {
                Console.WriteLine("Program Berakhir");
            }
            else
            {
                Console.WriteLine("Program Berakhir");
            }
        }

        else
        {
            Console.WriteLine("Pilihan tidak ada di dalam Menu");
        }
    }
}

class BangunDatar
{
    public virtual float luas()
    {
        Console.WriteLine("Menghitung luas bangun datar");
        return 0;
    }
    public virtual float keliling()
    {
        Console.WriteLine("Menghitung keliling bangun datar");
        return 0;
    }

}

class Persegi : BangunDatar
{
    public float sisi;
    public override float luas()
    {
        float luas = sisi * sisi;
        Console.WriteLine("Luas Persegi: " + luas);
        return luas;
    }
    public override float keliling()
    {
        float keliling = 4 * sisi;
        Console.WriteLine("Keliling Persegi: " + keliling);
        return keliling;
    }
}

class Lingkaran : BangunDatar
{
    // jari-jari lingkaran
    public float r;
    public override float luas()
    {
        float luas = (float)(Math.PI * r * r);
        Console.WriteLine("Luas lingkaran: " + luas);
        return luas;
    }
    public override float keliling()
    {
        float keliling = (float)(2 * Math.PI * r);
        Console.WriteLine("Keliling Lingkaran: " + keliling);
        return keliling;
    }
}

class PersegiPanjang : BangunDatar
{
    public float panjang;
    public float lebar;
    public override float luas()
    {
        float luas = panjang * lebar;
        Console.WriteLine("Luas Persegi Panjang:" + luas);
        return luas;
    }
    public override float keliling()
    {
        float kll = 2 * panjang + 2 * lebar;
        Console.WriteLine("Keliling Persegi Panjang: " + kll);
        return kll;
    }
}

class Segitiga : BangunDatar
{
    public float alas;
    public float tinggi;
    public override float luas()
    {
        float luas = 1 / 2 * (alas * tinggi);
        Console.WriteLine("Luas Segitiga: " + luas);
        return luas;
    }
}

