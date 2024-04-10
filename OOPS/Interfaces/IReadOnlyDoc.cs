using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Interfaces
{
    public interface IReadOnlyDoc: IDocument
    {
        void SaveAs(string path);
    }
}
