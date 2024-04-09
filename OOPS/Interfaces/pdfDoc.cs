using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Interfaces
{
    internal class pdfDoc : IReadOnlyDoc
    {
        public pdfDoc(string name)
        {
            this.filename = name;
        }
        public string filename
        {
            get;    set;
        }
       
        public void CloseDoc()
        {
            Console.WriteLine("pdf Doc Closed");
        }

        public void OpenDoc(string filename)
        {
            Console.WriteLine("pdf Doc opened with value : " + filename);

        }

        public void SaveAs(string path)
        {
            Console.WriteLine("pdf Doc saved with new path  : " + filename);

        }
    }
}
