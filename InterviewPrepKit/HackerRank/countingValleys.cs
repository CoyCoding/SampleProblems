/*
Print a single integer that denotes the number of valleys Gary walked through during his hike.

A valley is a continous distance below seaLevel; i.e. seaLevel = -1

D = down
U = up
*/




    static int countingValleys(int n, string s) {
        var seaLevel = 0;
        var valleyCount = 0;
        for(int i = 0; i < n-1; i++)
        {
            if(s.Substring(i, 1) == "D")
            {
                if(seaLevel == 0)
                {
                    valleyCount++;
                }
                seaLevel--;
            }
            else
            {
                seaLevel++;
            }
           
        }
        return valleyCount;
    }
