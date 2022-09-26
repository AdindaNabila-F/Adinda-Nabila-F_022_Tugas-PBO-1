using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatarPolimorfisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();
            Console.ReadLine();
        }
        class Menu
        {
            public void menu()
            {
                Console.WriteLine("== Menghitung Luas dan Keliling Bangun Datar ===");               
                Console.WriteLine();
                Console.WriteLine("Pilihan :");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Lingkaran");
                Console.WriteLine("3. Persegi Panjang");
                Console.WriteLine("4. Segitiga");
                Console.WriteLine();

                Persegi a = new Persegi();

                Console.WriteLine("1. Persegi");
                Console.WriteLine("======================");
                Console.Write("Sisi : ");
                a.sisi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas = {0} cm", a.hitungLuas());
                Console.WriteLine("Keliling = {0} cm", a.hitungKeliling());
                Console.WriteLine();

                Lingkaran d = new Lingkaran();

                Console.WriteLine("2. Lingkaran");
                Console.WriteLine("========================");
                Console.Write("Jari-Jari : ");
                d.jarijari = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas       = {0} cm", d.hitungLuas());
                Console.WriteLine("Keliling   = {0} cm", d.hitungKeliling());
                Console.WriteLine();

                PersegiPanjang b = new PersegiPanjang();

                Console.WriteLine("3. Persegi Panjang");
                Console.WriteLine("=============================");
                Console.Write("Panjang = ");
                b.panjang = (int.Parse(Console.ReadLine()));
                Console.Write("Lebar = ");
                b.lebar = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas = {0} cm", b.hitungLuas());
                Console.WriteLine("Keliling = {0} cm", b.hitungKeliling());
                Console.WriteLine();

                Segitiga c = new Segitiga();

                Console.WriteLine("4. Segitiga");
                Console.WriteLine("=======================");
                Console.Write("Alas   : ");
                c.alas = (int.Parse(Console.ReadLine()));
                Console.Write("Tinggi : ");
                c.tinggi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas   = {0} cm", c.hitungLuas());                        

                Console.ReadKey();
            }

            public abstract class BangunDatar
            {
                public double _hitung;

                public double Hitung
                {
                    get { return _hitung; }
                    set { _hitung = value; }
                }

                public abstract double hitungLuas();

                public abstract double hitungKeliling();
            }

            public class Persegi : BangunDatar
            {
                private double s;

                public double sisi
                {
                    get { return s; }
                    set { s = value; }
                }

                public Persegi()
                {
                    this.sisi = sisi;
                }

                public override double hitungLuas()
                {
                    return this.sisi * this.sisi;
                }
                public override double hitungKeliling()
                {
                    return this.sisi * 4;
                }
            }
            public class Segitiga
            {
                private float a, t, x;

                public float alas
                {
                    get { return a; }
                    set
                    {
                        a = value;
                    }
                }
                public float tinggi
                {
                    get { return t; }
                    set
                    {
                        t = value;
                    }
                }
                public float sisi2
                {
                    get { return x; }
                    set
                    {
                        x = value;
                    }
                }
                public Segitiga()
                {
                    this.alas = alas;
                    this.tinggi = tinggi;
                }
                public float hitungLuas()
                {
                    return this.alas * this.tinggi / 2;
                }               
            }
            public class Lingkaran : BangunDatar
            {
                private double r;

                public double jarijari
                {
                    get { return r; }
                    set
                    {
                        r = value;
                    }
                }
                public Lingkaran()
                {
                    this.jarijari = r;
                }

                public override double hitungLuas()
                {
                    return (float)(Math.PI * r * r);
                }

                public override double hitungKeliling()
                {
                    return (float)(2 * Math.PI * r);
                }
            }
            public class PersegiPanjang : BangunDatar
            {
                private float p, l;

                public float panjang
                {
                    get { return p; }
                    set
                    {
                        p = value;
                    }
                }
                public float lebar
                {
                    get { return l; }
                    set
                    {
                        l = value;
                    }
                }
                public override double hitungLuas()
                {
                    float luas = p * l;
                    return luas;
                }
                public override double hitungKeliling()
                {
                    float k = 2 * panjang + 2 * lebar;
                    return k;
                }
            }
        }
    }
}