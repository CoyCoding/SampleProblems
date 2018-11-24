/*
There is a collection of input strings and a collection of query strings. 
For each query string, determine how many times it occurs in the list of input strings.

Example: 
          input =  [bat, rat, cat, mat, mat]
         
          query =  [bat, fat, mat]

          output = [1, 0, 2]
*/
    
    
    
    
    
    
    
    static int[] matchingStrings(string[] strings, string[] queries) {
        Dictionary<string, int> queryDic = new Dictionary<string, int>();
        var matchedStrings = new int[queries.Length];

        foreach(var word in strings)
        {
            if(queryDic.ContainsKey(word))
            {
                queryDic[word]++;
            }else
            {
                queryDic.Add(word, 1);
            }
        }

        for(int i = 0; i < matchedStrings.Length; i++){
            var word = queries[i];
            if(queryDic.ContainsKey(word))
            {
                matchedStrings[i] = queryDic[word];
            }else{
                matchedStrings[i] = 0;
            }
        }

        return matchedStrings;
    }
