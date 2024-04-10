using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Reflection
{
    public class Document
    {
        public string Title { get; private set; }

        public Document(string title)
        {
            Title = title;
        }

        public void Display()
        {
            Console.WriteLine($"Document title: {Title}");
        }

    }
}
