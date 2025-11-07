internal class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Int32 number1 = 5;
        Int32 number2 = 10;
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("Hello, Mariusz!");
        // Console.WriteLine($"Mariusz jest {args[0]}");
        Console.WriteLine("Sumą 2 +2 jest {2 + 2}");
        Console.WriteLine($"Sumą 2 +2 jest {2 + 2}");
        Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");

        number1 = Int32.Parse(args[0]);
        number2 = Int32.Parse(args[1]);

        Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");
    }
}