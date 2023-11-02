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
           // Payload = new Payload();
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
        //string packageName = string.Empty; //Replace with a random name (string of letters) for each instance // skapa en textgenerator
        public string packageName { get; }

        public Payload(string packageName)
        {
            this.packageName = packageName;
        }

        public static List<Payload> LoadFromJsonFile(string filePath)
        {
            List<Payload> payloads = new List<Payload>();

            try
            {
                string[] jsonLines = File.ReadAllLines(filePath);

                foreach (string jsonLine in jsonLines)
                {
                    Payload payload = JsonConvert.DeserializeObject<Payload>(jsonLine);
                    payloads.Add(payload);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fel vid inläsning av JSON-fil: " + e.Message);
            }

            return payloads;
        }
    }
}
