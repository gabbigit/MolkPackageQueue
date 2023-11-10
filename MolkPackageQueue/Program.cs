namespace MolkPackageQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            PriorityQueue prioqueue = new PriorityQueue();
            PackageFactory packageFactory = new PackageFactory();

            // Create and enqueue 1-10 packages
            for (int i = 0; i < 10; i++)
            {
                var newPackage = packageFactory.CreatePackage();
                prioqueue.Enqueue(newPackage);
            }

            // Dequeue 1-5 packages, handle them, and log
            for (int i = 0; i < 5; i++)
            {
                var handledPackage = prioqueue.Dequeue();
                HandlePackage(handledPackage);
            }

            // Continue creating and enqueuing packages until at least 50 are created and then empty the queues
            while (prioqueue.IncomingPackageList.Count < 50)
            {
                var newPackage = packageFactory.CreatePackage();
                prioqueue.Enqueue(newPackage);
            }

            // Dequeue and handle the remaining packages
            while (prioqueue.IncomingPackageList.Count > 0)
            {
                var handledPackage = prioqueue.Dequeue();
                HandlePackage(handledPackage);
            }

            // Print log for packages created and handled
            prioqueue.PrintCreatedPackageLog(prioqueue.IncomingPackageList);
            prioqueue.PrintCreatedPackageLog(prioqueue.PrioritizedOutgoingPackage);
        }

        static void HandlePackage(Package package)
        {
            // Your handling logic here
            if (package.Payload != null && package.Payload.PackageName != null)
            { 
              Console.WriteLine($"Handling package with Priority: {package.Priority}, Payload: {package.Payload.PackageName}");

                if (package.Priority == Priority.High)
                {
                    Console.WriteLine("Special handling for high-priority package.");
                    Console.WriteLine("This package will be delivered in 2 days.");
                }
                else if (package.Priority == Priority.Medium)
                {
                    Console.WriteLine("Package with medium priority will be delivered in 3-5 days.");
                }
                else if (package.Priority == Priority.Low)
                {
                    Console.WriteLine("Package with low priority will be delivered in 7 days");
                }
            }
            else
            {
                Console.WriteLine("Package or its Payload is null.");
            }
        }

        // Instantiate the MPS-PriorityQueue
        // Create a function to queue and dequeue packages according to the rules. 
        // Don´t forget the logging lists
        // Print log for packages created in order of creation, with payload packageName and package priority
        // Print log for packages handled (dequeue and add to logg), same content as above.
        // No high prio should be in bottom of handled list, alla paket som skapas ska finnas i hanterad-listan.

    }
    
}