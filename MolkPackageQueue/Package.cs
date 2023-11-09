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
     
        public Priority Priority { get; }
        public Payload Payload { get; }
    }

    public enum Priority 
    { 
        Low = 0,     //random slumpa fram en prio vid skapande av paket
        Medium = 1, 
        High = 2 
    }

    public class Payload 
    {

        Random random = new Random();
        private string GenerateRandomName()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(letters, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string PackageName { get; }
        public Payload()
        {
            PackageName = GenerateRandomName();
        }
    }

   
}
