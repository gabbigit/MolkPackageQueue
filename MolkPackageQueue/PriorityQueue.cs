﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkPackageQueue
{
    public class PriorityQueue
    {
        Queue<Package> queueHigh = new Queue<Package>();
        Queue<Package> queueMedium = new Queue<Package>();
        Queue<Package> queueLow = new Queue<Package>();

        List<Package> incommingPackageList = new List<Package>();
        List<Package> prioritizedOutgoingPackage = new List<Package>();

        public void Enqueue(Package package)
        {
            switch (package.Priority)
            {
                case Priority.Low:
                    queueLow.Enqueue(package);
                    {
                        incommingPackageList.Add(package);
                        break;
                    }
                case Priority.Medium:
                    queueMedium.Enqueue(package);
                    {
                        incommingPackageList.Add(package);
                        break;
                    }
                case Priority.High:
                    queueHigh.Enqueue(package);
                    {
                        incommingPackageList.Add(package);
                        break;
                    }
                default: break;

            }
        }

        // handle dequeuing packages based on priority
        public Package Dequeue()
        {
            if (queueHigh.Count > 0)
            {
                return queueHigh.Dequeue();
            }
            else if (queueMedium.Count > 0)
            {
                return queueMedium.Dequeue();
            }
            else if (queueLow.Count > 0)
            {
                return queueLow.Dequeue();
            }

            return null; // No packages to dequeue
        }

        public void PrintLogList(List<Package> packageList) 
        {
            foreach (var package in packageList)
            {
                Console.WriteLine($"Package: {package.Payload.PackageName}, Priority: {package.Priority}");
            }
        }
    }
    
}
