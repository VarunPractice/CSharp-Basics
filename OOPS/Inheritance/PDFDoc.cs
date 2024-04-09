using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Inheritance
{
    public class PDFDoc : Document
    {
        public PDFDoc(string name, string type, string content) : base(name, type, content)
        {
        }
        public override void DisplayDoc(string name)
        {
            Console.WriteLine("pdf doc is opened with name - " + name);
        }
    }
}
