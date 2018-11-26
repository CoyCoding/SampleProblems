/*
Variables: money to spend, cost of a chocolate, and the number of wrappers needed to get a free chocolate.

                              Return to total number of chocolates we can get.
*/




    static int chocolateFeast(int money, int chocolateCost, int wrappersNeeded) {
        var chocolateCount = money/chocolateCost;
        var wrapperCount = chocolateCount;
        while(wrapperCount >= wrappersNeeded)
        {
            wrapperCount -= wrappersNeeded - 1;
            chocolateCount++;
        }
        return chocolateCount;
    }
