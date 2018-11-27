/*

          Check if magazine same strings as note including duplicates

*/

    static void checkMagazine(string[] magazine, string[] note) {
        Dictionary<string, int> wordPool = new Dictionary<string, int>();
        foreach(var item in magazine)
        {
            if(wordPool.ContainsKey(item))
            {
                wordPool[item]++;
            }
            else
            {
                wordPool.Add(item, 1);
            }
        }

        foreach(var item in note)
        {
            if(wordPool.ContainsKey(item) && wordPool[item] > 0)
            {
                wordPool[item]--;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }

        }
        Console.WriteLine("Yes");
    }
