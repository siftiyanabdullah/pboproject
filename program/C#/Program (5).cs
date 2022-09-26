using System;

namespace Polimorphism_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.WriteLine("Menu Bangun Datar : ");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Persegi");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Segitiga");
            Console.Write("Silahkan pilih bangun datar yang ingin dihitung luas dan kelilingnya : ");
            string input_bangundatar = Console.ReadLine();
            if(input_bangundatar == "Lingkaran")
            {
                BangunDatar lingkaran = new BangunDatar();
                Console.Write("Masukan nilai jari-jari = ");
                double r = double.Parse(Console.ReadLine());
                lingkaran.luas(r);
                lingkaran.keliling(r);
                Console.WriteLine("Apakah anda ingin kembali ke menu?(ya/tidak)");
                string backmenu = Console.ReadLine();
                if (backmenu == "ya")
                {
                    goto menu;
                }
                else if (backmenu == "tidak"){
                    Console.WriteLine("Program Berakhir");
                }
                else
                {
                    Console.WriteLine("Program Berakhir");
                }
            }
            else if(input_bangundatar == "Persegi")
            {
                BangunDatar persegi = new BangunDatar();
                Console.Write("Masukan nilai sisi = ");
                int s = int.Parse(Console.ReadLine());
                persegi.luas(s);
                persegi.keliling(s);
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
            else if (input_bangundatar == "Persegi Panjang")
            {
                BangunDatar persegi_panjang = new BangunDatar();
                Console.Write("Masukan nilai panjang = ");
                int p = int.Parse(Console.ReadLine());
                Console.Write("Masukan nilai l = ");
                int l = int.Parse(Console.ReadLine());
                persegi_panjang.luas(p, l);
                persegi_panjang.keliling(p, l);
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
            else if (input_bangundatar == "Segitiga")
            {
                BangunDatar segitiga = new BangunDatar();
                Console.Write("Masukan nilai alas = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Masukan nilai tinggi = ");
                double t = double.Parse(Console.ReadLine());
                segitiga.luas(a, t);
                segitiga.keliling(a, t);
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
                Console.WriteLine("Menu yang anda pilih tidak tersedia");
                goto menu;
            }
        }
    }
    public class BangunDatar
    {
        public double phi = 3.14;
        public void luas(double r)
        {
            Console.WriteLine("Luas lingkaran = " + phi * r * r);
        }
        public void luas(int s)
        {
            Console.WriteLine("Luas persegi = " + s*s);
        }
        public void luas(int p, int l)
        {
            Console.WriteLine("Luas persegi panjang = " + p * l);
        }
        public void luas(double a, double t)
        {
            Console.WriteLine("Luas segitiga = " + 0.5 * a * t);
        }
        public void keliling(double r)
        {
            Console.WriteLine("Keliling lingkaran = " + 2*phi*r);
        }
        public void keliling(int s)
        {
            Console.WriteLine("Keliling persegi = " + 4*s);
        }
        public void keliling(int p, int l)
        {
            Console.WriteLine("Keliling persegi panjang = " + 2 * (p+l));
        }
        public void keliling(double a, double t)
        {
            double phytagoras = (a * a) + (t * t);
            Console.WriteLine("Keliling segitiga = " + 3*a);
        }
    }
}
