    static string twoStrings(string s1, string s2) {
        var word1 = new SortedSet<char>();
        
        foreach(var letter in s1)
        {
            word1.Add(letter);
        }
        
        foreach(var letter in s2)
        {
            if(word1.Contains(letter))
            {
                return "YES";
            }
        }
        return "NO";
    }
