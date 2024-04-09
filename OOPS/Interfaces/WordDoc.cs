using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Interfaces
{
    public class WordDoc : IEditableDoc
    {
        public WordDoc(string filename)
        {
            this.filename = filename;
        }

        public string filename {    get; set; }

        public void CloseDoc()
        {
            Console.WriteLine("word Doc Closed");
        }

        public void EditDoc(string filename)
        {
            Console.WriteLine("word Doc edited with value : " + filename);

        }

        public void OpenDoc(string filename)
        {
            Console.WriteLine("word Doc opened with value : " + filename);

        }
    }
}
