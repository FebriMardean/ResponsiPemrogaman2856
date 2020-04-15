using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2856
{
    public class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public double GajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            this.GajiBulanan = gaji;

            if(GajiBulanan < 0)
            {
                Console.WriteLine("Gaji tidak boleh kurang dari 0 / minus 1");
                GajiBulanan = 0;
            }
        }
    }
}
