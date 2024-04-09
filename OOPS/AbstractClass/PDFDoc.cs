using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.AbstractClass
{
    internal class PDFDoc : Document, IDocument
    {
        public void CloseDoc()
        {
            Console.WriteLine("pdf Doc is closed");
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
