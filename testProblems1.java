package test;

//Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.
//
//Note: This challenge introduces precision problems. The test cases are scaled to six decimal places.
//
//You must print the following  lines:
//
//A decimal representing of the fraction of positive numbers in the array compared to its size.
//A decimal representing of the fraction of negative numbers in the array compared to its size.
//A decimal representing of the fraction of zeros in the array compared to its size.
//
//Sample Input
//
//6
//arr[] = {-4 3 -9 0 4 1}       
//
//Sample Output
//
//0.500000
//0.333333
//0.166667


public class testProblems1 {
	static void plusMinus(int[] arr) {
        int posCount = 0;
        int negCount = 0;
        int zeroCount = 0;
        
        for(int i=0; i < arr.length ; i++){
            if (arr[i] > 0) {
                posCount++;                
            } else if (arr[i]<0) {
                negCount++;
            } else {
                zeroCount++;
            }
        }
        System.out.printf("%.6f \n", (float)posCount/arr.length );
        System.out.printf("%.6f \n", (float)negCount/arr.length );
        System.out.printf("%.6f \n", ((float)zeroCount/arr.length) );
    }
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] test = {1,2,3,0,-2,-2};
		plusMinus(test);
	}

}
