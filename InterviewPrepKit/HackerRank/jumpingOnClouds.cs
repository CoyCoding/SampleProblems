/*
Print the minimum number of jumps needed to win the game.

You can only jump 1 or 2 spaces.

                Sample Input:

                7
                0 0 1 0 0 1 0
*/



    static int jumpingOnClouds(int[] c) {
        var count = -1;
        for(int i = 0; i < c.Length; i++)
        {
            i += (i + 2 < c.Length && c[i + 2] == 0) ? 1 : 0;
            Console.WriteLine(i);
            //Console.WriteLine(count);
            count++;             
        }
        return count;
    }
