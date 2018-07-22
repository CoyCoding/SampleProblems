package test;

public class TestProblem5 {
    static int hourglassSum(int[][] arr) {
        int maxGlass = Integer.MIN_VALUE;
    for(int i = 0; i < arr.length-2; i++){
    	//i is used for x axis
    	//arr[j][i]
    	
        for(int j = 0; j < arr.length-2; j++){
        	//j is used for y axis
        	
        	
            int tempMax = (arr[0+j][0+i] + arr[0+j][1+i] + arr[0+j][2+i] + arr[1+j][1+i] + arr[2+j][0+i] + arr[2+j][1+i] + arr[2+j][2+i]);
            	//This is the I shape we are checking for in the arr[][]
            
            if (tempMax > maxGlass){                    //if new I-shape sum is greater than current
                maxGlass = tempMax;						//update maxGlass
                
            }
            
            
            // System.out.print(arr[0+j][0+i]);
            // System.out.print(arr[0+j][1+i]);
            // System.out.println(arr[0+j][2+i]);
            // System.out.println(arr[1+j][1+i]);
            // System.out.print(arr[2+j][0+i]);
            // System.out.print(arr[2+j][1+i]);
            // System.out.println(arr[2+j][2+i]);
            
        }
    }
    return maxGlass;
    }
    public static void main(String[] args) {
		// TODO Auto-generated method stub
    	int [][] test = {{1,2,3,4,5,6,7,8,9}, {9,8,1,4,5,6,7,8,10}, {5,1,1,4,5,6,7,8,9}, {4,2,3,4,5,6,7,8,9}, {5,2,3,4,5,6,7,8,9}, {6,2,3,4,5,6,7,8,9}, {7,2,3,4,5,6,7,8,9}, {8,2,3,4,5,6,7,8,9}};
	System.out.println(hourglassSum(test));
    }
}
