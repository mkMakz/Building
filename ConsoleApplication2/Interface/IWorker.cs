using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Interface
{
    public interface IWorker
    {
        string Name { get; set; }
        double Salary { get; set; }
        bool IsTeam { get; set; }
        void PrintReport(List<IPart>parts);

    }
}
