namespace MolkPackageQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement MPS");
            // Instantiate the MPS-PriorityQueue
            // Create a function to queue and dequeue packages according to the rules. 
            // Don´t forget the logging lists
            // Print log for packages created in order of creation, with payload packageName and package priority
            // Print log for packages handled (dequeue and add to logg), same content as above.
            // No high prio should be in bottom of handled list, alla paket som skapas ska finnas i hanterad-listan.

            // File Path to the JSON-file with the package names
            string jsonFilePath = "C:\\Users\\Gabriella\\source\\repos\\MolkPackageQueue\\MolkPackageQueue\\bin\\Debug\\net6.0\\MOCK_DATA.json";
            List<Payload> payloads = Payload.LoadFromJsonFile(jsonFilePath);

            foreach (Payload payload in payloads)
            {
                Console.WriteLine("Paketnamn: " + payload.packageName);
            }
        }
    }
}