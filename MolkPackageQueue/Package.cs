using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace MolkPackageQueue
{
    public class Package
    {
        public Package(Priority priority)
        {
            Priority = priority;
            Payload = new Payload();
        }

        public Package(Priority priority, string packageName)
        {
            Priority = priority;
            Payload = new Payload { PackageName = packageName };
        }
        public Priority Priority { get; }
        public Payload Payload { get; set; }
    }

    public enum Priority 
    { 
        Low = 0,     //random slumpa fram en prio vid skapande av paket
        Medium = 1, 
        High = 2 
    }

    public class Payload 
    {
  
        public string PackageName { get; set; }
        
    }

   
}
