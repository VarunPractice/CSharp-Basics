using Basics.OOPS.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
     static   Document document;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Doc Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Doc Type");
            var type  = Console.ReadLine();
            Console.WriteLine("Enter Doc Content");
            var content = Console.ReadLine();
            document = new Document(name, type, content);
            document.GetDocument();
            document.SetDocument("jai shree Ram");
        }
    }
}
