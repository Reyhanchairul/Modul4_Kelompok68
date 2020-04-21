using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_Kelompok68_Tugas
{
    class Program
    {
        private const uint V = 4200000000;

        static void Main(string[] args)
        {

            Class2 objek = new Class2();

            {
                string S = "SELAMAT DATANG DI JUAL APPARTEMEN SYARIAH";
                Console.WriteLine(S);
                string L = "******************************************"; 
                Console.WriteLine(L);
                Console.WriteLine();

            }
            int hp, byr, kmb, p, jml, i, j;

            String[,] smp = new String[10, 4];
            //MENU :
            Console.WriteLine("Hayuuuuuuuu Dibeli\t                                  Harga(Rp)");
            Console.WriteLine("1. Elevee Alam Sutra\t                                2,300,000,000");
            Console.WriteLine("2. Senopati Suite\t                                1,600,000,000");
            Console.WriteLine("3. Maple Park\t                                        1,750,000,000");
            Console.WriteLine("4. Green Pramuka\t                                1,250,000,000");
            Console.WriteLine("5. Transpark Bintaro\t                                  950,000,000");
            Console.WriteLine("6. UNCHDIP Candi\t                                2,000,000,000");

            for (i = 0; i < 4; i++)
                Console.WriteLine("\n-----------------------------------------------------------------------------");
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(smp[i, j] + "\t|");
                }
                Console.WriteLine("\n-----------------------------------------------------------------------------");         //pindah baris
            }


            Console.WriteLine("Masukan Nomor Apartemen Yang Ingin Dibeli : ");
            int.TryParse(Console.ReadLine(), out hp);
            Console.WriteLine("Masukan Berapa Unit yang akan dibeli : ");
            int.TryParse(Console.ReadLine(), out jml);
            Console.WriteLine("Masukan Nominal Pembayaran : ");
            int.TryParse(Console.ReadLine(), out byr);

            System.Console.WriteLine();
            switch (hp)
            {
                case 1:
                    p = 1300000000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {

                        objek.tx();
                        Console.WriteLine(smp[1, 1] + " Sejumlah " + jml + " unit");
                        Console.WriteLine("Uang kembalian anda " + kmb + " rupiah");
                    }
                    else { objek.k(smp[1, 1], jml); }
                    break;
                case 2:
                    p = 1600000000;
                    kmb = byr - p;
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[2, 1] + " Sejumlah " + jml + " unit");
                        Console.WriteLine("Uang kembalian anda " + kmb + " rupiah");
                    }
                    else { objek.k(smp[2, 1], jml); }
                    break;
                case 3:
                    p = 275000000;
                    kmb = byr - p;
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[3, 1] + " Sejumlah " + jml + " unit");
                        Console.WriteLine("Uang kembalian anda " + kmb + " rupiah");
                    }
                    else { objek.k(smp[3, 1], jml); }
                    break;
                case 4:
                    p = 1250000000;
                    kmb = byr - p;
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[4, 1] + " Sejumlah " + jml + " unit");
                        Console.WriteLine("Uang kembalian anda " + kmb + " rupiah");
                    }
                    else { objek.k(smp[4, 1], jml); }
                    break;

                case 5:
                    p = 350000000;
                    kmb = byr - p;
                    if (kmb >= 0)
                    {

                        objek.tx();
                        Console.WriteLine(smp[5, 1] + " Sejumlah " + jml + " unit");
                        Console.WriteLine("Uang kembalian anda " + kmb + " rupiah");
                    }
                    else { objek.k(smp[5, 1], jml); }
                    break;
                case 6:
                    p = 2000000000;
                    kmb = byr - p;
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[6, 1] + " Sejumlah " + jml + " unit");
                        Console.WriteLine("Uang kembalian anda " + kmb + " rupiah");
                    }
                    else { objek.k(smp[6, 1], jml); }
                    break;
               
                default:
                    Console.WriteLine("masukan salah");
                    break;
            }
            Console.ReadKey();
        }

    }
}
