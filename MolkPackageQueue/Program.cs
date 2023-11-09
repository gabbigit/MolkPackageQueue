namespace MolkPackageQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Package test = new Package(Priority.Low);
            Console.WriteLine($"Package {test} has {Priority.Low} priority");

            Console.WriteLine("Implement MPS");

            PriorityQueue prioqueue = new PriorityQueue();
            PackageFactory packageFactory = new PackageFactory();
            //Skapa 1-10 paket och köa dem (enligt nedan)
            prioqueue.Enqueue(packageFactory.CreatePackage());
            //avköa 1-5 paket med dequeue
            //Fortsätt tills minst 50 skapade och sedan till köer tomma.
            // Create a function and dequeue packages according to the rules. 
            // Don´t forget the logging lists
            // Print log for packages created in order of creation, with payload packageName and package priority
            // Print log for packages handled (dequeue and add to logg), same content as above.
            // No high prio should be in bottom of handled list, alla paket som skapas ska finnas i hanterad-listan.

            for (int i = 0; i < 10; i++)
            {
                var newPackage = packageFactory.CreatePackage();
                prioqueue.Enqueue(newPackage);
            }

            for (int i = 0; i < 5; i++)
            {
                var handledPackage = prioqueue.Dequeue();
                // Handle the package and log
            }

          


            // Instantiate the MPS-PriorityQueue
            // Create a function to queue and dequeue packages according to the rules. 
            // Don´t forget the logging lists
            // Print log for packages created in order of creation, with payload packageName and package priority
            // Print log for packages handled (dequeue and add to logg), same content as above.
            // No high prio should be in bottom of handled list, alla paket som skapas ska finnas i hanterad-listan.

            /*// File Path to the JSON-file with the package names
            string jsonFilePath = "C:\\Users\\Gabriella\\source\\repos\\MolkPackageQueue\\MolkPackageQueue\\bin\\Debug\\net6.0\\MOCK_DATA.json";
            List<Payload> payloads = Payload.LoadFromJsonFile(jsonFilePath);

            foreach (Payload payload in payloads)
            {
                Console.WriteLine("Paketnamn: " + payload.packageName);
            }*/
        }
    }
}