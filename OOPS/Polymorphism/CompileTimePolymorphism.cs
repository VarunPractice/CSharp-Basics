using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Polymorphism
{
    public class CompileTimePolymorphism
    {
        public void OpenDoc(string filename)
        {
            Console.WriteLine("File Opened : " + filename);
        }
        public void OpenDoc(string filename,string type)
        {
            Console.WriteLine("File Opened : " + filename + "Type is: " + type);
        }
        public void OpenDoc(string filename, out string FilePath)
        {
            FilePath = filename;
            Console.WriteLine("File Opened : " + filename + "File Path :" + FilePath);
        }
    }
}
