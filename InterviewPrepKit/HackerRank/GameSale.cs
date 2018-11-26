   /*
   Usually, all games are sold at the same price, (X) dollars. 
   However, they are planning to have the seasonal Halloween Sale next month in which you can buy games at a cheaper price. 
   
   Specifically, the first game you buy during the sale will be sold at (X) dollars, 
   but every subsequent game you buy will be sold at exactly (Y) dollars less than the cost of the previous one you bought. 
   
   This will continue until the cost becomes less than or equal to (Z) dollars, after which every game you buy will cost (Z) dollars each.
   
   How many games can you buy based on (X) (Y) (Z) and (W) the money in your wallet.
   
   
   */
   
    
    
    
    
    
    
    static int howManyGames(int price, int discount, int minPrice, int wallet) {
        // Return the number of games you can buy
        var count = 0;
        if(price > wallet)
        {
            return count;
        }
        
        count++;

        if(price - discount < minPrice)
        {
            count += howManyGames(minPrice, discount, minPrice,( wallet - price));
        } 
        else
        {
            count += howManyGames((price - discount), discount, minPrice, (wallet - price));
        }

        return count;
    }
