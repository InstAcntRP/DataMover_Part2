
namespace DataMover.Batch
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            string fileName = @"C:\temp\Visual Studio Code\DataMover\Employee Data.csv";
            FileManager fileManager = new FileManager();
            fileManager.ParseFileAndGetData(fileName);

        }
    }
}



