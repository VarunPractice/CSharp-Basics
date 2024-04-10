using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Serialization
{
    [Serializable]
    public class Document
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
