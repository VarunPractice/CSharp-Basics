using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Inheritance
{
    public class WordDoc : Document
    {
        public WordDoc(string name, string type, string content) : base(name, type, content)
        {
        }

        public override void DisplayDoc(string name)
        {
            Console.WriteLine("Word doc is opened with name - " + name);
        }
    }
}
