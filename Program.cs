// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


    Dictionary<int, string> topGames = new Dictionary<int, string>();
    topGames.Add(1, "Fallout: New vegas");
    topGames.Add(2, "Cyberpunk 2077");
    topGames.Add(3, "Farcry 5");
    topGames.Add(4, "Fallout 4");
    topGames.Add(5, "Watch dogs: legion");
    topGames.Add(6, "Tom Clancy's: The Divsion");
    topGames.Add(7, "Fallout 3");
    topGames.Add(8, "Detriot Become Human");
    topGames.Add(9, "Team Fortress 2");
    topGames.Add(10, "Red Dead Redemption 2");

    foreach (KeyValuePair<int, string> kvp in topGames)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }

    if (topGames.ContainsKey(1))
    {
        Console.WriteLine($"My Favorite game is: {topGames[1]}!");
    }

    string result = "";

    topGames.TryGetValue(11, out result);

    if (result == "")
    {
        Console.WriteLine("There is no game in the eleventh position.");
    }
    else
    {
        Console.WriteLine(result);
    }

    if (topGames.ContainsKey(5))
    {
        topGames[5] = "Watch Dogs: Legion";
    }

    Console.WriteLine(topGames[5]);

    Hashtable hashTable = new Hashtable(topGames);

    string favGame = (string)hashTable[1];

    Console.WriteLine($"Favortie Game: {favGame}");

    Hashtable capitals = new Hashtable() {
        { "Oklahoma", "Oklahoma City" },
        {"New York", "Albany" },
        {"Texas", "Austin" },
        {"California", "Sacramento" }
    };
        foreach (DictionaryEntry kvp in capitals)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        capitals.Clear();
