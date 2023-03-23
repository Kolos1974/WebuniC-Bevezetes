using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRegister
{
    public class Desktop : PC
    {
        public int[] dim { get; set; }



        // Constructor
        public Desktop(int mem, string c, int year, int[] d) 
        {
            memory = mem;
            cpu = c;
            yearOfMan = year;
            dim = d;
        }

        public override string ToString()
        {
            return "Memory: " + memory.ToString() + ", Cpu: " + cpu + ", YearOfMade: " + yearOfMan.ToString() + ", Dimension: [" + dim[0] + ", " + dim[1]+", " + dim[2]+"]";
        }


    }
}
