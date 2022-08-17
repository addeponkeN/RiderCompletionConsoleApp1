using System.Numerics;

namespace ConsoleApp1;

class Program
{
    static void Main(params string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.ReadLine();
        var v = new Vector2(5);
    }
}