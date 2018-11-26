/*

                          Find pairs of numbers in array

*/
    
    
    
    
    static int sockMerchant(int n, int[] ar) 
    {
        var sockPairs = 0;
        SortedSet<int> matches = new SortedSet<int>();
        for(int i = 0; i < n ; i++)
        {
            if(matches.Contains(ar[i]))
            {
               sockPairs++;
               matches.Remove(ar[i]);
            }
            else
            {
               matches.Add(ar[i]);
            }
        }
        return sockPairs;
    }
