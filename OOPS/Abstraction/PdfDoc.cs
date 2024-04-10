using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Abstraction
{
    internal class PdfDoc : Document
    {
        public override void Display()
        {
            Console.WriteLine("pdf displayed");
        }
    }
}
