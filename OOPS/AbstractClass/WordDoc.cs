using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.AbstractClass
{
    internal class WordDoc :  Document,IDocument
    {
        public void CloseDoc()
        {
            Console.WriteLine("Word Doc is closed");
        }

        public void OpenDoc(string filename)
        {
            Console.WriteLine(filename + " is opened");

        }

        public override void PrintDocument(string docName)
        {
            Console.WriteLine(docName + " is printed");

        }
    }
}
