using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Inheritance
{
    public   class Document
    {
        public string DocName { get; set; }
        public string Type { get; set; }    
        public string Content { get; set; }

        public Document(string name, string type, string content) {
        DocName = name;
            Type = type;
            Content = content;
        }

        public virtual void DisplayDoc(string name)
        {
            Console.WriteLine("Document class with name - " + name);
        }

    }
}
