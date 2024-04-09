using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Encapsulation
{
    public class Document
    {
        private string DocName { get; set; }
        private string DocType { get; set; }
        = string.Empty;
        private string Content { get; set; }

        public Document(string name, string type, string content)
        {
            DocName = name;
            DocType = type;
            Content = content;
        }

        public string GetDocument()
        {
            Console.WriteLine("doc returned :" + DocName); ;
            return DocName; }
        public string SetDocument(string newvalue)
        {
            Console.WriteLine("doc updated from old value : " + DocName + " with new value" + newvalue); 
            return DocName= newvalue; }
    }
}
