package test;
 
/*
* KeyEventDemo
*/
 import java.io.*;
//import java.math.*;
//import java.text.*;
//import java.util.*;
//import java.util.regex.*;

public class testProblem2 {

    /*
     * Find the Difference of the diagonals in an multiArray
     * Complete the simpleArraySum function below.
     */
	
    static int diagonalDifference(int[][] arr) {
        int dif;
        int leftD = 0;
        int rightD = 0;
        for (int i = 0; i < arr[0].length; i++){
            for (int j = 0; j < arr[0].length; j++){
               if (i == j) {
                   leftD += arr[i][j];                  
               }
                if ((i+j) == (arr[0].length-1)){
                    rightD += arr[i][j];
                }
                
            }        
        }
        dif = Math.abs(rightD - leftD);
    return dif;
    }


    public static void main(String[] args) throws IOException {
    	int[][] test = {{1,2,3},{4,5,6},{7,8,111}};
    	System.out.println(diagonalDifference(test));

    	System.out.println(test);
}
}
