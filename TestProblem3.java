package test; 

//Sample Input
//
//6 
//Sample Output
//
//     #
//    ##
//   ###
//  ####
// #####
//######
//Explanation
//
//The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of n;

public class TestProblem3 {
	static void staircase(int n) {
		for(int i=1; i <= n; i++) {
			for(int j=1; j<=n; j++) {
				if (j <= n-i) {
					System.out.print(" ");
					//System.out.print(n-i);
				}else {
					System.out.print("#");
				}	
			}
			System.out.println();
		}
	
    }
	static void reverseStaircase(int n) {
		for(int i=0; i <= n; i++) {
			for(int j=1; j<=n; j++) {
				if (j <= n-i) {
					System.out.print("#");
					//System.out.print(n-i);
				}else {
					System.out.print(" ");
				}	
			}
			System.out.println();
		}
	}
	public static void main(String[] args) {
		staircase(3);
		reverseStaircase(7);
		
	}
}
