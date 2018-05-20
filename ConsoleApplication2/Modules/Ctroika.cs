using ConsoleApplication2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Modules
{
    public class Ctroika
    {
        public void startCt()
        {
            House house = new House();
            house.CreateHousePlan();

            Team team = new Team();
            team.GenerateWorkers();

            while(house.PartsHouse.Count(c=>c.StartWork==null)>0)
            {
                team.WorkJ(ref house.PartsHouse);
            }
            
            
            
        }
    }
}
