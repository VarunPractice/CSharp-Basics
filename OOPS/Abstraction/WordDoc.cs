using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Abstraction
{
    public class WordDoc : Document
    {
        public override void Display()
        {
            Console.WriteLine("word displayed");
        }
    }
}
