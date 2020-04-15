using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2856
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono" , 2000000);

            Console.WriteLine("No Nik/Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            GajiNormal1(karyawan1);
            GajiNormal2(karyawan2);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Asyiiiiik Kenaikan Gaji 10%!!");
            Console.WriteLine(" ");
            Console.WriteLine("No Nik/Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            KenaikanGaji1(karyawan1);
            KenaikanGaji2(karyawan2);
            Console.ReadKey();
        }

        static void GajiNormal1(Karyawan karyawan)
        {
            Console.WriteLine("1. " + karyawan.NIK + " " + karyawan.Nama + "            " + karyawan.GajiBulanan);
        }

        static void GajiNormal2(Karyawan karyawan)
        {
            Console.WriteLine("2. " + karyawan.NIK + " " + karyawan.Nama + "             " + karyawan.GajiBulanan);
        }

        static void KenaikanGaji1(Karyawan karyawan)
        {
            double kenaikan;
            kenaikan = karyawan.GajiBulanan * 0.1;
            karyawan.GajiBulanan = karyawan.GajiBulanan + kenaikan;
            Console.WriteLine("1. " + karyawan.NIK + " " + karyawan.Nama + "            " + karyawan.GajiBulanan);
        }

        static void KenaikanGaji2(Karyawan karyawan)
        {
            double kenaikan;
            kenaikan = karyawan.GajiBulanan * 0.1;
            karyawan.GajiBulanan = karyawan.GajiBulanan + kenaikan;
            Console.WriteLine("2. " + karyawan.NIK + " " + karyawan.Nama + "             " + karyawan.GajiBulanan);
        }
    }
}
