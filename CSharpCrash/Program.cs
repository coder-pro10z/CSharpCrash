using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        ComparisonOperator();
        LogicalOperator();
        ConditonalStatements();
        Loops();

    }

    static void PrintToConsole()
    {
        Console.WriteLine("Hello World!");
    }

    static void VariablesAndDataTypes()
    {
        int age = 30;
        Console.WriteLine(age);

        float temprature = 34.5f;

        double interest = 33.456;

        decimal stockPrice = 65.354675M;

        char grade = 'A';

        String name = "John";

        bool isBanana = true;

        Console.WriteLine(temprature);
        Console.WriteLine("interest:{0}", interest);
        Console.WriteLine("stock price:{0}", stockPrice);
        Console.WriteLine("grade:{0}", grade);
        Console.WriteLine("name:{0}", name);
        Console.WriteLine("isBanana:{0}", isBanana);

        int amount = 100;
        string student = "Ram";
        Console.WriteLine("{0} got {1} marks", student, amount);

    }

    static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;

        int addition = num1 + num2;
        int substraction = num1 - num2;
        int multiplication = num1 * num2;
        int division = num1 / num2;

        int modulus = num1 % num2;

        Console.WriteLine("adition of {0} and {1} :{2}", num1, num2, addition);
        Console.WriteLine("substraction of {0} and {1} :{2}", num1, num2, substraction);
        Console.WriteLine("multiplication of {0} and {1} :{2}", num1, num2, multiplication);
        Console.WriteLine("division of {0} and {1} :{2}", num1, num2, division);

        Console.WriteLine("modulus of {0} and {1} :{2}", num1, num2, modulus);

        int num3 = 5;
        int num4 = 0;

        try
        {
            int quotient;
            quotient = num3 % num4;
            Console.WriteLine("quoteint:{0}", quotient);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occured " + ex.Message);
        }
        int num5 = 5;
        double num5asdouble = (Double)num5;
        Console.WriteLine("num 5 as double {0}", num5asdouble);

    }

    static void ComparisonOperator()
    {
        int num1 = 10;
        int num2 = 5;
        bool isEqual = (num1 == num2);
        Console.WriteLine("num1 isEqual to num2 :" + isEqual);

        bool isNotEqual = (num1 != num2);
        Console.WriteLine("num1 isNotEqual to num2 :" + isNotEqual);

        bool isGreater = (num1 > num2);
        Console.WriteLine("num1 isGreater than num2 :" + isGreater);

        bool isLess = (num1 < num2);
        Console.WriteLine("num1 isLess than num2 :" + isLess);

        bool isGreaterThanOrEqual = (num1 >= num2);
        Console.WriteLine("num1 isGreaterThanOrEqual than num2 :" + isGreaterThanOrEqual);

        bool isLesserThanOrEqual = (num1 <= num2);
        Console.WriteLine("num1 isLesserThanOrEqual than num2 :" + isLesserThanOrEqual);
    }

    static void LogicalOperator()
    {

        bool x = true;
        bool y = false;

        bool andResult = x && y;
        bool orResult = x || y;
        bool andResultNotY = x && !y;
        bool notResultX = !x;
        Console.WriteLine("andResult: " + andResult);
        Console.WriteLine("orResult: " + orResult);
        Console.WriteLine("andResultNotY: " + andResultNotY);
        Console.WriteLine("notResultX: " + notResultX);

    }

    static void ConditonalStatements()
    {
        // if  else if  else logic

        int age = 21;
        if (age < 18)
        {
            Console.WriteLine("You are a Kid");
        }

        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("You are a Adult");
        }
        else
        {
            Console.WriteLine("You are a Senior citizen");
        }


        //switch
        int Day = 3;
        //string DayName;
        switch (Day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }


    }

    static void Loops()
    {
        //Loops - For
        Console.WriteLine("Iterations of For Loop: ");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        //While Looop
        int count = 0;
        while (count < 5) {
        Console.WriteLine("While count"+count);
            count ++;
        }
        //Do while Loop
        do
        {
            Console.WriteLine("Do-While count : "+count);
            count--;
        }
        while (count>0);

        //for Each Loop
        //initializing an array of int
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        foreach (int number in numbers)
        { 
        Console.WriteLine(number);
        }

        //standard For loop for Numbers array
        for (int i=0; i< numbers.Length;i++) 
        { Console.WriteLine("Using standard For Loop: "+ numbers[i]);
        }

    }

}
