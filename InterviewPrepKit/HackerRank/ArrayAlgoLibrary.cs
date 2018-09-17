using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{

    //  These are a Library of Algos from hacker Rank focused on Arrays
    //  Taken from the Interview Prep Kit section
    //  Extreme Comments for explaining the thought proccess

    public class ArrayAlgoLibrary
    {
        public static int[] RotLeft(int[] arr, int numOfRotations)
        {

            //First I create a holder array
            //This array will stop mutation of the orginal array
            //and allow us to only loop through the array once

            int[] newArr = new int[arr.Length];

            //This calculation of cuts the number of rotations down
            //with relation to the size of the array
            //This calculation prevents index out of bounds in the for loop

            numOfRotations %= arr.Length;


            for (int j = 0; j < arr.Length; j++)
            {

                //Finding the new index after the rotation.
                //At the current location (j) add (The length of the array - the number of rotations.
                //Then mod that by the length 
                //This modulus opperation keeps the index from going out of bounds.
                //We then place the current indexed item at its newIndex in the holder Array.

                int newIndex = (j + (arr.Length - numOfRotations)) % arr.Length;
                newArr[newIndex] = arr[j];
            }
            return newArr;
        }

        public static int[] RotRight(int[] arr, int numOfRotations)
        {
            int[] newArr = new int[arr.Length];

            numOfRotations %= arr.Length;

            for (int j = 0; j < arr.Length; j++)
            {

                //In order to rotate Right we just add the number of rotations
                //instead of subtracting 

                int newIndex = (j + (arr.Length + numOfRotations)) % arr.Length;
                newArr[newIndex] = arr[j];
            }

            return newArr;
        }

        public static int MinimumSwaps(int[] arr)
        {
            int minNum= 0;
            int minIndex = 0;
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                minNum = arr[i];
                for (int j =1+i; j < arr.Length; j++)
                {
                    if ((arr[j] < minNum))
                    {
                        minNum = arr[j];
                        minIndex = j;
                    }

                }
                if(arr[i] != minNum)
                {
                    int numHolder = arr[i];
                    arr[i] = minNum;
                    arr[minIndex] = numHolder;
                    count++;
                }
                
            }
            return count;
        }

        public static int SolutionSwap(int[] arr)
        {
            int numSwaps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int curVal = arr[i];
                while (curVal != i + 1)
                {
                    
                    int temp = arr[curVal - 1];
                    arr[curVal - 1] = curVal;
                    curVal = temp;
                    numSwaps++;
                }
            }
            return numSwaps;
        }
    }
}
