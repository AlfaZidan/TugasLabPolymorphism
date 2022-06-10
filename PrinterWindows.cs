using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLabPolymorphism
{
    public class PrinterWindows
    {
        public int MyProperty { get; set; }

        public virtual void Show()
        {
            Console.WriteLine(" display dimension : ");
        }

        public virtual void Print()
        {
            Console.WriteLine(" printer printing....");
        }
    }
}
