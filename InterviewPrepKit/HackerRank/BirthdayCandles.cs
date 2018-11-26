/*
You are in charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age.
When she blows out the candles, 
she’ll only be able to blow out the tallest ones. Your task is to find out how many candles she can successfully blow out.
*/





    static int birthdayCakeCandles(int[] ar) {
        var largestCandleCount = new int[] { 0, 0 };
        
        for(int i = 0; i < ar.Length; i++)
        {
           if(ar[i] > largestCandleCount[0])
           {
               largestCandleCount[0] = ar[i];
               largestCandleCount[1] = 1;
           }else if(ar[i] == largestCandleCount[0]){
               largestCandleCount[1]++;
           }
        }
        return largestCandleCount[1];
    }







    static int birthdayCakeCandles(int[] ar) {
        Dictionary<int, int> candles = new Dictionary<int, int>();
        
        var largestCandleCount = new int{ 0, 0 };
        for(int i = 0; i < ar.Length; i++)
        {
            if(candles.ContainsKey(ar[i])){
                candles[ar[i]]++;
            }else{
                candles.Add(ar[i], 1);
            }
        }
        
        
        return candles.First(x => x.Key == candles.Keys.Max()).Value;
    }
