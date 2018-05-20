using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Interface
{
    public interface IPart
    {
        string Name { get; set; }
        DateTime StartWork { get; set; }
        DateTime EndWork { get; set; }
        int Priority { get; set; }
    }
}
