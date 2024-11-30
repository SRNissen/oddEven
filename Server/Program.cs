namespace Server;

static class Program
{
    static void Main()
    {
        Console.WriteLine("program start");

        Console.WriteLine("Testing text input");
        foreach (var text in TestData.Texts)
        {
            Console.WriteLine($"Output: {OddEven.Check(text)}");
        }

        Console.WriteLine("\nTesting text collection input");
        foreach (var textCollection in TestData.TextCollections)
        {
            Console.WriteLine($"Output: {OddEven.Check(textCollection)}");
        }

        Console.WriteLine("\nTesting number collection input");
        foreach (var numberCollection in TestData.NumberCollections)
        {
            Console.WriteLine($"Output: {OddEven.Check(numberCollection)}");
        }
    }
}