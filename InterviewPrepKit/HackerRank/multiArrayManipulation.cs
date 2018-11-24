    /*
    Starting with a 1-indexed array of zeros and a list of operations, 
    for each operation add a value to each of the array element between two given indices, inclusive. 
    Once all operations have been performed, return the maximum value in your array.
    
    
    Example inputs:
                     n = 5
    
                     queries = [
                               [1, 2, 100],
                               [2, 5, 100],
                               [3, 4, 100]
                               ];
                               
    Maximum value would be = 200.
    */    
    
    
    
    
    
    static long arrayManipulation(int n, int[][] queries) {
        long[] computation = new long[n];
        
        for (int i = 0; i < queries.Length; i++) 
        {
            int startIndex = queries[i][0] - 1;
            int endIndex   = queries[i][1] - 1;
            int numToAdd   = queries[i][2];

            for(int j = startIndex; j <= endIndex; j++)
            {
                computation[j] += numToAdd;
            }
        }
        
        return computation.Max();
  
    }


    static long arrayManipulation(int n, int[][] queries) {
        long[] computation = new long[n];

    for (int i = 0; i < queries.Length; i++) {
      int a = queries[i][0] - 1;
      int b = queries[i][1];
      int k = queries[i][2];

      computation[a] += k;

      if (b < n) 
      {
            computation[b] -= k;
      }
    }

    long max = 0; 
    long sum = 0;

    for (int i = 0; i < n; i++) 
    {
      sum += computation[i];
      max = sum > max ? sum : max;
    }

    return max;
  
    }
