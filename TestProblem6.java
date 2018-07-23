package test;

//	Shift an array values left n spaces or right n spaces. 
//	Looping the array EX.
//	
//	SHIFT RIGHT 2
//
//	1 2 3 4 5 -> 4 5 1 2 3 
//
//	SHIFT LEFT 11
//
//	"hello" "how "are" "you" -> 
//


public class TestProblem6 {
	public static int[] shiftArrayRight(int[] arr, int move) {
	    // Loop the number of shifts 
		
		if (arr == null || arr.length <= 1 || (move%arr.length) == 0) {			
		} else {
			for (int x = 0; x < move%arr.length; x++) {

				//Last element will be store in temporary variable 
				int lastElm = arr[arr.length - 1];

				//This loop will shift array content by one
				for (int i = arr.length; i > 0; i--) {
					if (i == 1) {
						arr[0] = lastElm;
					} else {
						arr[i - 1] = arr[i - 2];

	            }
	        }
	    }
			
	   }
		for(int i =0; i < arr.length ; i++ ) {
		System.out.print(arr[i] + " ");
		if (i == arr.length-1) {
			System.out.println();
		}
		}
		return arr;
	}
	
	public static int[] shiftArrayLeft(int[] arr, int move ) {
		if (arr == null || arr.length <= 1 || (move%arr.length) == 0) {			
		} else {
			for (int x = 0; x < move%arr.length; x++) {

				//Last element will be store in temporary variable 
				int firstElm = arr[0];

				//This loop will shift array content by one
				for (int i = 0; i < arr.length; i++) {
					if (i == arr.length-1) {
						arr[arr.length-1] = firstElm;
					} else {
						arr[i] = arr[i + 1];

	            }
	        }
	    }
			
	   }
		for(int i =0; i < arr.length ; i++ ) {
		System.out.print(arr[i] + " ");
		if (i == arr.length-1) {
			System.out.println();
		}
		}
		return arr;
	}

	public static String[] shiftArrayLeft(String[] arr, int move) {
		if (arr == null || arr.length <= 1 || (move%arr.length) == 0) {			
		} else {
			for (int x = 0; x < move%arr.length; x++) {

				//Last element will be store in temporary variable 
				String firstElm = arr[0];

				//This loop will shift array content by one
				for (int i = 0; i < arr.length; i++) {
					if (i == arr.length-1) {
						arr[arr.length-1] = firstElm;
					} else {
						arr[i] = arr[i + 1];

	            }
	        }
	    }
			
	   }
		for(int i =0; i < arr.length ; i++ ) {
		System.out.print(arr[i] + " ");
		if (i == arr.length-1) {
			System.out.println();
		}
		}
		return arr;
	}
	
	public static String[] shiftArrayRight(String[] arr, int move) {
		if(arr == null || arr.length <= 1 || move%arr.length == 0) {
		} else {
			for(int x = 0; x < move%arr.length; x++) {
				String lastElm = arr[arr.length-1];
				for(int i = arr.length; i > 0; i--) {
					if(i ==1) {
						arr[0] = lastElm;
					}else {
						arr[i-1] = arr[i-2];
					}
				}
			}
		}
		for (int i = 0; i < arr.length; i++) {
		
			System.out.print(arr[i]);
			if(i == arr.length-1) {
				System.out.println();
			}
		}
		
		return arr;
	}
	
	public static void main(String[] args) {
		int [] testInt = {1,2,3,4,5};
		String[] test = {"test1 " , "test2 " , "test3 " , "test4 "};

		shiftArrayLeft(test, 1);
		shiftArrayLeft(testInt,1);

	}

}
