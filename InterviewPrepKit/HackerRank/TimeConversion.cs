/*
    
            Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
    
*/
    
   
    
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
        var timeArr = s.Split(':');
        int hour = int.Parse(timeArr[0]);
        if(timeArr[2].Substring(2,1) == "P")
        {          
            timeArr[0] = "" + ((hour % 12) + 12);
        } 
        else 
        {
            timeArr[0] = "" + hour % 12;
        }

        if(timeArr[0].Length == 1)
        {
            timeArr[0] = "0" + timeArr[0];
        }

        var militaryTime = string.Join(":" , timeArr);
        return militaryTime.Substring(0,8);
    }
