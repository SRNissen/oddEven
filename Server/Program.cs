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
        
        // men hvis jeg nu skal være ærlig - hvis ikke det skulle forbi din lærer, så ville jeg nok have en løsning der
        // så sådan her ud:
        
        Console.WriteLine("================");

        // 1, bare for lige at få noget test data
        var input = "1,2,2,,,1,peter,1,2";
        
        //2. Konverter til et format lige/ulige
        var converted = input
            .Split(',') // laver "1,2" til "1","2"
            .Where(s => s.Length != 0 && s.All(char.IsDigit)) // laver "2,,,1,peter,1" til "2,1,1"
            .Select(s => "02468".Contains(s.Last()) ? ", lige igen" : ", ulige igen")// "select" burde have heddet "transform"
            .ToList();

        //3. Hvis ikke der er noget resultat så er vi done
        if (converted.Count == 0)
        {
            Console.WriteLine("nothing to convert");
            return;
        }
        
        //4. nu har vi en liste med "lige igen/ulige igen" - men vi skal have "igen" fjernet fra første lige og ulige
        var lige = converted.FindIndex(s => s == ", lige igen");
        if (lige != -1) // -1 betyder "der var ikke nogen
            converted[lige] = ", lige";

        var ulige = converted.FindIndex(s=> s == ", ulige igen");
        if (ulige != -1)
            converted[ulige] = ", ulige";
        
        //5. Der behøver ikke at være noget komma og mellemrum før den første
        converted[0] = converted[0].Substring(2);
        
        //6. konverter fra liste til en tekst der kan udskrives
        var output = string.Concat(converted);
        
        Console.WriteLine(output);


    }
}