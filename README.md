System;
namespace ConsoleApp2;

{
 public static void ChangeRef(red int numberRef)
{
    numberRef = 25;
    Console.WriteLine($"Inside the changeref is {numberRef}");
}

public static void ChangeOut(out int numberOut)
{
    numberOut = 60;
    Console.WriteLine($" inside changeout is {numberOut}");
}

public static void Main(string[] args)
{
    int numberRef = 15;

    Console.WriteLine($"before calling is {numberRef}");
    changeRef(ref numberRef);
    Console.WriteLine($"after calling is {numberRef}");

    Console.WriteLine();
    int numberOut;
    Console.WriteLine("before calling is unassigned");
    ChangeOut(out numberOut);
    Console.WriteLine($"after calling is {numberOut}");
    Console.ReadKey();
}
}
