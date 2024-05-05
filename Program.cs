internal abstract class Program
{
    public static void Main()
    {
        Console.WriteLine("Running Program");
        Console.WriteLine("Enter the name of the file you want to search (without the file '.txt' at the end)\n");
        string fileToSearch = Console.ReadLine();
        fileToSearch += ".txt";
        searchWithinFile(fileToSearch, "gm");
    }

    public static void searchWithinFile(string filename, string searchValue)
    {
        StreamReader bob = new StreamReader(filename);
        int searchValueCount = 0;
        while (bob.ReadLine() != null)
        {
            string currentLine = bob.ReadLine();
            if (currentLine.Contains(searchValue))
            {
                searchValueCount += 1;
                Console.WriteLine(currentLine);
            }
        }
        Console.WriteLine($"The word {searchValue} appears {searchValueCount} times in the file {filename}");
    }
}
