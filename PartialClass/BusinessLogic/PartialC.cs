using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.PartialClass.BusinessLogic
{
    public partial class PartialC
    {
        public void OpenDoc()
        {
            Console.WriteLine("Logic to opening doc");
        }
        public void CloseDoc()
        {
            Console.WriteLine("Logic to close doc");
        }
        public void CreateDoc(string name, string type)
        {
            Console.WriteLine("Logic to creating doc");
        }
    }
}
