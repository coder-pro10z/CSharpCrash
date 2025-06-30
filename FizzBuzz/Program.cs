//Fizz Buzz

using System.IO;
class Fizz
{
    public static void Main()
    {
        Console.WriteLine("|Fizz Buzz|");
        int num;
        bool isValid;
        //Check for valid User input FizzBuzz number Range
        do
        {
            Console.WriteLine("Enter a number to get FizzBuzz to the range:");
            isValid = int.TryParse(Console.ReadLine(), out num);

        } while (!isValid);

        int count = 1;
        while (count <= num)
        {
            //    int multiplier = 1;
            //    while (multiplier <= 10)
            //    { Console.Write("{0}\t|", count * multiplier);
            //        multiplier++; }
            //    Console.WriteLine();
            //    count++;
            //}
             if (count % 3 == 0 && count % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(count % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (count % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            
            else { 
                Console.WriteLine($"{count}");
            }
            count++;
        }
    }
}