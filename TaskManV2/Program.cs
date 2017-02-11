using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff Staff1  = new Staff();
            Staff1.Name = "Carl";
        }
    }


    class Staff
    {
        public string Name { get; set; }
        int StaffID { get; set; }
        int Role { get; set; }
        
        
    }

    class Task
    { }

    



}
