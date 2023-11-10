using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkPackageQueue
{
    public class PriorityQueue
    {
        Queue<Package> mainQueue = new Queue<Package>();
        Queue<Package> queueHigh = new Queue<Package>();
        Queue<Package> queueMedium = new Queue<Package>();
        Queue<Package> queueLow = new Queue<Package>();

        // List<Package> incommingPackageList = new List<Package>();
        //  List<Package> prioritizedOutgoingPackage = new List<Package>();
        public List<Package> IncomingPackageList { get; private set; } = new List<Package>();
        public List<Package> PrioritizedOutgoingPackage { get; private set; } = new List<Package>();
        public void Enqueue(Package package)
        {
            mainQueue.Enqueue(package);

            switch (package.Priority)
            {
                case Priority.Low:
                    queueLow.Enqueue(package);
                    IncomingPackageList.Add(package);
                    break;
                case Priority.Medium:
                    queueMedium.Enqueue(package);
                    IncomingPackageList.Add(package);
                    break;
                case Priority.High:
                    queueHigh.Enqueue(package);
                    IncomingPackageList.Add(package);
                    break;
                default:
                    break;
            }

            PrintCreatedPackageLog(IncomingPackageList);

        }

        // handle dequeuing packages based on priority

        public Package Dequeue()
        {
            if (mainQueue.Count == 0)
            {
                Console.WriteLine("Main Queue is empty.");
                return null;
            }

            Package package = mainQueue.Dequeue();

            switch (package.Priority)
            {
                case Priority.Low:
                    return DequeueFromQueue(queueLow);
                case Priority.Medium:
                    return DequeueFromQueue(queueMedium);
                case Priority.High:
                    return DequeueFromQueue(queueHigh);
                default:
                    return null;
            }
        }

        private Package DequeueFromQueue(Queue<Package> queue)
        {
            if (queue.Count > 0)
            {
                Package package = queue.Dequeue();
                PrioritizedOutgoingPackage.Add(package);
                return package;
            }

            return null; // No packages to dequeue
        }

        public void PrintCreatedPackageLog(List<Package> packageList) 
        {

            Console.WriteLine("Log of Created Packages:");
            foreach (var package in packageList)
            {
                Console.WriteLine($"Priority: {package.Priority}, Payload: {package.Payload.PackageName}");
            }
        }
    }
    
}
