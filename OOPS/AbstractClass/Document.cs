using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basics.OOPS.AbstractClass;
namespace Basics.OOPS.AbstractClass
{
   abstract class Document
    {
        public string docNamw {  get; set; }    
        public string docContent { get; set; }
        = null;

        public Document()
        {

        }

        public abstract void PrintDocument(string docName);
        
    }
}
