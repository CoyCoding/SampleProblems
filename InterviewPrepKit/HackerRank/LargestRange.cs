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
		
    		//Create array size 2 for holding the result
		var largestRangeArr = new int[2];
		
		//Create int for holding the current largest range count.
		int largestRange = 0;
		
		
		//Load the numbers into the dictionary and set all to not visited(true)
		foreach(var num in arr)
		{
			nums[num] = true;
		}
		
		
		foreach(var num in arr)
		{
			//check if num is visited(true) else nothing
			if(nums[num])
			{
				//set to visited
				nums[num] = false;
				
				//set variables for seaching consecutive numbers
				var currentRange = 1;
				var lowerNum  = num -1; 
				var higherNum = num + 1;
				
				
				//search for all consecutive numbers less than orginal 
				while(nums.ContainsKey(lowerNum)){
					nums[lowerNum] = false;
					currentRange++;
					lowerNum--;
				}
				
				//search for all consecutive numbers greater than orginal
				while(nums.ContainsKey(higherNum)){
					nums[higherNum] = false;
					currentRange++;
					higherNum++;
				}
				
				//set largest range and arr if current search is greater than current Largest.
				if(currentRange > largestRange){
					largestRange = currentRange;
					largestRangeArr = new int[] {lowerNum + 1, higherNum -1};
				}	
			}
		}
		return largestRangeArr;
	}
}
