internal abstract class Program
{
    public static void Main()
    {
        Console.WriteLine("Running Program");
    }
    
    public int GetValidInt(int min, int max)
    {
        if (int.TryParse(Console.ReadLine(), out int validInt))
        {
            if (validInt >= min && validInt <= max)
            {
                return validInt;
            }

            Console.WriteLine($"No bro enter a number between {min} and {max}");
            return GetValidInt(min, max);
        }

        Console.WriteLine("Please enter a valid integer");
        return GetValidInt(min, max);
    }
}
