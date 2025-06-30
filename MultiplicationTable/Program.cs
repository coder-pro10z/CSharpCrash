//MultiplicationTable

class MultiplicationTable
{
    public static void Main()
    {
        Console.WriteLine("Multiplication Table");
        int tablesCount = 10;
        int count = 1;
        while (count <= tablesCount)
        {
            int multiplier = 1;
            while (multiplier <= 10)
            {
                Console.Write("{0}\t|", count * multiplier);
                multiplier++;
            }
            Console.WriteLine();
            count++;
        }
    }
}