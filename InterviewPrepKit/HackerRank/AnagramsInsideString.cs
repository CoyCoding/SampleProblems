/*


      find all anagram pairs inside of a string


*/



    static int sherlockAndAnagrams(string s) {
        Dictionary<string, int> anagrams = new Dictionary<string, int>();
        var anagramCount = 0;
        for(int i = 0; i < s.Length; i++)
        {
            for(int j = 1; j < s.Length-i+1; j++)
            {
                var wordArr = s.Substring(i,j).ToCharArray();
                Array.Sort(wordArr);
                var word = new string(wordArr);

                if(anagrams.ContainsKey(word))
                {                    
                    anagramCount += anagrams[word];
                    Console.WriteLine(anagrams[word]++);
                }
                else
                {
                    anagrams.Add(word, 1);
                }   

            }
        }
        return anagramCount;
    }
