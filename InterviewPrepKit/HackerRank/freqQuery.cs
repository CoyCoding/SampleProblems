/*



    THIS STILL NEEDS WORK




*/









    static List<int> freqQuery(List<List<int>> queries) {
        var queryCount = new Dictionary<int, int>();
        var freqency =  new Dictionary<int, int>();
        var returnList = new List<int>();

        foreach(var list in queries)
        {
            
            //Console.WriteLine(queryCount.ContainsKey(list[1]));
            if(list[0] == 1)
            {
                if(queryCount.ContainsKey(list[1]))
                {                                 
                    freqency[queryCount[list[1]]]--;
                    queryCount[list[1]]++;

                    if(freqency.ContainsKey(queryCount[list[1]]))
                    {
                        freqency[queryCount[list[1]]]++;
                    }
                    else
                    {
                        freqency[queryCount[list[1]]] = 1;
                    }
                }
                else
                {
                    queryCount[list[1]] = 1;
                    freqency[1] = freqency.ContainsKey(1) ? freqency[1]++ : 1;
                }
            }

            else if (list[0] == 2)
            {
                if(queryCount.ContainsKey(list[1]))
                {
                    Console.WriteLine(queryCount[list[1]]);
                    freqency[queryCount[list[1]]]--;
                    if(--queryCount[list[1]] <= 0)
                    {
                        queryCount.Remove(list[1]);
                    }
                }    
            }

            else if(list[0] == 3)
            {
                if(freqency.ContainsKey(list[1]))
                {
                    returnList.Add(1);
                }
                else
                {
                    returnList.Add(0);
                }
            }

        }
        
        return returnList;
    }
