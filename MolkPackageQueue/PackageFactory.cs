using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkPackageQueue
{
    
    
    public class PackageFactory
    {
        /// <summary>
        /// Randomizes an int between 0,2
        /// </summary>
        /// <returns>Priority enum value low, medium or high</returns>
        /// 

        // Instead of creating a new Random instance every time GetRandomPriority() is called,
        // it's better to have a single instance to avoid potential issues with random number generation.
        Random randomizer = new Random();
        public Priority GetRandomPriority()
        { 
            return (Priority)randomizer.Next(0, 3);
         }

         public Package CreatePackage()
         {
            return new Package(GetRandomPriority());
         }
    }
    
}