using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkPackageQueue
{
    
    
    public class PackageFactory
    {

        // Instead of creating a new Random instance every time GetRandomPriority() is called, it's better to have a single instance to avoid potential issues with random number generation.
        Random randomizer = new Random();
        public Priority GetRandomPriority()
        { 
            return (Priority)randomizer.Next(0, 3);
        }

        Random random = new Random();
        public string GenerateRandomName()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(letters, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        
        public Package CreatePackage()
         {
            Payload payload = new Payload();
            return new Package(GetRandomPriority(), GenerateRandomName())
            {
                Payload = payload
            };
         }
    }
    
}