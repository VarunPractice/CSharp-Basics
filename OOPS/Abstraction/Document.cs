using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Abstraction
{
    public abstract class Document
    {
        public string Title { get; set; }
        public abstract void Display(); // Abstract method

    }
}
