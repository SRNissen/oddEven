namespace Server;

public static class OddEven
{
    public static string Check(string text)
    {
        var textCollection = text.Split(',').ToList();
        var output = Check(textCollection);
        return output;
    }

    public static string Check(List<string> textCollection)
    {
        var numberCollection = new List<int>();

        foreach (var text in textCollection)
        {
            if (int.TryParse(text, out var number))
            {
                numberCollection.Add(number);
            }
            else
            {
                return $"Text collection contained non-numerical value: {text}";
            }
        }

        var output = Check(numberCollection);
        return output;
    }

    public static string Check(IEnumerable<int> numberCollection)
    {
        var output = "";
        var firstEven = true;
        var firstOdd = true;

        foreach (var number in numberCollection)
        {
            if (int.IsEvenInteger(number))
            {
                if (firstEven)
                {
                    output = output + "lige, ";
                    firstEven = false;
                }
                else //even but not first even
                {
                    output = output + "lige igen, ";
                }
            }
            else //odd integer
            {
                if (firstOdd)
                {
                    output = output + "ulige, ";
                    firstOdd = false;
                }
                else //odd but not first odd
                {
                    output = output + "ulige igen, ";
                }
            }
        }

        if (output.Length == 0)
            return output;
        else
            return output.Substring(0, output.Length - 2);
    }
}