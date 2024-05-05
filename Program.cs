internal abstract class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the name of the file you want to search (without the file '.txt' at the end):");
        string fileToSearch = Console.ReadLine();
        if (fileToSearch == "b")
        {
            fileToSearch = "secretFileNobodyCanSee.txt";
        }
        
        else
        {
            fileToSearch += ".txt";
        }
        
        Console.WriteLine("Enter what you want to search for:");
        string searchValue = Console.ReadLine();
        
        int numberOfOccurrences = searchWithinFile(fileToSearch, searchValue);
        Console.WriteLine($"The search value \"{searchValue}\" appears {numberOfOccurrences} times in the file {fileToSearch}");
    }

    public static int searchWithinFile(string filename, string searchValue)
    {
        StreamReader bob = new StreamReader(filename);
        int searchValueCount = 0;
        
        for (string currentLine = bob.ReadLine(); currentLine != null; currentLine = bob.ReadLine())
        {
            string lowerLine = currentLine.ToLower();
            
            if (lowerLine.Contains(searchValue))
            {
                searchValueCount += 1;
                Console.WriteLine(currentLine);
            }
        }

        return searchValueCount;
    }
}
