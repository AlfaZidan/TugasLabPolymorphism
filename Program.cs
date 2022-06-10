using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLabPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
