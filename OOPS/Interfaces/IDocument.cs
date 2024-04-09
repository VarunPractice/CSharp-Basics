using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Interfaces
{
    public interface IDocument
    {
        void OpenDoc(string filename);
        void CloseDoc();

    }
}
