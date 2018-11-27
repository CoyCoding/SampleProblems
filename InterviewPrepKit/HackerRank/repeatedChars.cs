/*
      find the number a's in a string if n > than the length of the string loop the string



*/
    static long repeatedString(string s, long n) {
        var leftOverChars = n % s.Length;
        var count = 0;
        var extraCount = 0;
        for(int i = 0; i < s.Length; i++)
        {
            extraCount += (i < leftOverChars && s.Substring(i, 1) == "a") ? 1: 0;
            count += s.Substring(i, 1) == "a" ? 1 : 0;
        }
        return (count * (n / s.Length)) + extraCount;
    }
