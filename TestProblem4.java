package test;

import java.util.Arrays;

public class TestProblem4 {
	   static void miniMaxSum(int[] arr) {
	       long min = Arrays.stream(arr).asLongStream().min().getAsLong();
	       long max = Arrays.stream(arr).asLongStream().max().getAsLong();
	       long sum = Arrays.stream(arr).asLongStream().sum();
	        System.out.println((sum - max) + " " + (sum-min));

	    }
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] test = {222222222,5555544,1111111199,2333333,432323,};
		miniMaxSum(test);
	}

}
