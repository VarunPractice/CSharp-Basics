using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.PartialClass.BusinessLogic
{
    public partial class PartialC
    {
        public void ConnectToSQL(string connectionStr)
        {
            Console.WriteLine("SQL server Conncted.");
        }
        public void ConnectToTSQL(string connectionStr)
        {
            Console.WriteLine("T-SQL server Conncted.");
        }
    }
}
