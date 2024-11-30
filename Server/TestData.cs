namespace Server;

static class TestData
{
    public static List<string> Texts =>
    [
        "1,3,5,7,11,13",
        "1,2,3,4,5,6",
        "13,11,7,5,3,1",
        "-3,-2,-1,0,1,2,3",
        "adoj;jfoiadjf",
        "daf,3rq4,adfg"
    ];

    public static List<List<string>> TextCollections => new List<List<string>>
    {
        new List<string> { "1", "3", "5", "7", "11", "13" },
        new List<string> { "1", "2", "3", "4", "5", "6" },
        new List<string> { "13", "11", "7", "5", "3", "1" },
        new List<string> { "-3", "-2", "-1", "0", "1", "2", "3" },
        new List<string> { "adoj;jfoiadjf" },
        new List<string> { "daf,3rq4,adfg" },
    };

    public static List<List<int>> NumberCollections => new List<List<int>>
    {
        new List<int> { 1, 3, 4, 5, 11, 13 },
        new List<int> { 1, 2, 3, 4, 5, 6 },
        new List<int> { 13, 11, 7, 5, 3, 1 },
        new List<int> { -3, -2, -1, 0, 1, 2, 3 },
    };
}