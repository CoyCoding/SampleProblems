




    static long countTriplets(List<long> arr, long r) 
    {
        var numList = new Dictionary<long,long>();
        var triplePairs = new Dictionary<long,long>();
        long tripleCount = 0;
        foreach (long val in arr)
        {
            if (triplePairs.ContainsKey(val))
            {
                tripleCount += triplePairs[val];
            }
                
            if (numList.ContainsKey(val))
            {
                if (triplePairs.ContainsKey(val*r))
                {
                    triplePairs[val*r] += numList[val];
                }

                else
                {
                    triplePairs[val*r] = numList[val];
                }
                    
            }

            if (numList.ContainsKey(val*r))
            {
                numList[val*r]++;
            }  
            else
            { 
                numList[val*r] = 1;
            }
               
        }
        return tripleCount;
    }
