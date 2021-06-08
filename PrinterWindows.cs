using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas
{
    public class PrinterWindows
    {
        public virtual void Show()
        {

        }

        public virtual void Print()
        {

        }
    }

    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display Dimension : 10 * 11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson Printer Printing....");
        }
    }

    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension : 9.5 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing....");
        }
    }

    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet Display Dimension : 12 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet Printer Printing....");
        }
    }
}
