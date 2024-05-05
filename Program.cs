using System;
using System.IO;


class Program
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

        Console.WriteLine("Enter Y to see the whole message each time its mentioned, or anything else to not:");
        string seeEachTime = Console.ReadLine();

        int numberOfOccurrences = searchWithinFile(fileToSearch, searchValue, seeEachTime);
        Console.WriteLine($"The search value \"{searchValue}\" appears {numberOfOccurrences} times in the file {fileToSearch}");
    }

    public static int searchWithinFile(string filename, string searchValue, string seeEachTime)
    {
        StreamReader bob = new StreamReader(filename);
        int searchValueCount = 0;

        for (string currentLine = bob.ReadLine(); currentLine != null; currentLine = bob.ReadLine())
        {
            string lowerLine = currentLine.ToLower();

            if (lowerLine.Contains(searchValue))
            {
                searchValueCount += 1;
                if (seeEachTime == "Y")
                {
                    Console.WriteLine(currentLine);
                }
            }
        }

        return searchValueCount;
    }
}
