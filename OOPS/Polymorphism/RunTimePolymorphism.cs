using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Polymorphism
{
    public class RunTimePolymorphism
    {
      public  class Document
        {
         public  virtual void OpenDoc()
            {
                Console.WriteLine("Open Doc from Main");
            }
        }

        public class WordDoc: Document
        {
            public override void OpenDoc()
            {
                Console.WriteLine("Open Doc from word class");
            }
        }
        public class PdfDoc : Document
        {
            public override void OpenDoc()
            {
                Console.WriteLine("Open Doc from pdf class");
            }
        }
    }
}
