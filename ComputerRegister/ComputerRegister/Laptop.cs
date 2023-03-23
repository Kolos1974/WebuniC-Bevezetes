using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRegister
{
    public class Laptop : PC
    {
        public int displaySize { get; set; }

        public double weight { get; set; }


        // Constructor
        public Laptop(int mem, string c, int year, int ds, double w)
        {
            memory = mem;
            cpu = c;
            yearOfMan = year;
            displaySize = ds;
            weight = w;
        }

        public override string ToString()
        {
            return "Memory: " + memory.ToString() + ", Cpu: " + cpu + ", YearOfMade: " + yearOfMan.ToString() + ", DisplaySize: " + displaySize.ToString() + ", Weight: " + weight.ToString();
        }

    }



}
