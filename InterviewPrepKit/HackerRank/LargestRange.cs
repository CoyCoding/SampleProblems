using System;
using System.Collections.Generic;
/*
This is an algo for finding the greatest range between consecutive numbers in an array.

                                       Big-O: (N)
*/

public class Program
{
	public static void Main()
	{
    //Test Driver
		int[] list = {-1, 0,1,2,3,4,5,6,8,9,10,10};	
    
		var rangeArr = highestRange(list);
    
		foreach (var num in rangeArr)
		{
			Console.Write(num + " ");
		}
		
	}
  
	static public int[] highestRange(int[] arr){
  
    //Create Dictionary for tracking visited numbers    
		Dictionary<int, bool> nums = new Dictionary<int, bool>();
    
		var largestRangeArr = new int[2];
		int largestRange = 0;
		
		foreach(var num in arr)
		{
			nums[num] = true;
		}
		
		foreach(var num in arr)
		{
			if(nums[num])
			{
				var currentRange = 1;
				var lowerNum  = num -1; 
				var higherNum = num + 1;
				nums[num] = false;
				
				while(nums.ContainsKey(lowerNum)){
					nums[lowerNum] = false;
					currentRange++;
					lowerNum--;
				}
				
				while(nums.ContainsKey(higherNum)){
					nums[higherNum] = false;
					currentRange++;
					higherNum++;
				}
				
				if(currentRange > largestRange){
					largestRange = currentRange;
					largestRangeArr = new int[] {lowerNum + 1, higherNum -1};
				}	
			}
		}
		return largestRangeArr;
	}
}
