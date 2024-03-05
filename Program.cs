using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pilihan menu Calkulator!!\n";
            Console.Title = "1. Penambahan\n";
            Console.Title = "2. Pengurangan\n";
            Console.Title = "3. Perkalian\n";
            Console.Title = "4. Pembagian\n";
            Console.Title = "Input nomor menu [1..4] :";
            int d = int.Parse(Console.ReadLine());


            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());


            if(d == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
            }
            else if(d == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if(d ==3)
            {
                Console.WriteLine("Hasil Pengurangan {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if(d == 4)
            {
                Console.WriteLine("Hasil Pengurangan {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan (int a, int b) 
        {
        return a + b; }
        static int Pengurangan (int a, int b)
        {
            return a - b;
        }
        static int Perkalian (int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}
