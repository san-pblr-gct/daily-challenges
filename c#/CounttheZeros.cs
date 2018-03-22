/*
Problem Title: Count the Zeros
Problem Description: Given an array of size N consisting of only 0's and 1's ,
            which is sorted in such a manner that all the 1's are placed first 
            and then they are followed by all the 0's. 
            You have to find  the count of all the 0's.
Example :
            Input:
            3
            12
            1 1 1 1 1 1 1 1 1 0 0 0 
            5
            0 0 0 0 0
            6
            1 1 1 1 1 1
            
            Output:
            3
            5
            0

Link: https://practice.geeksforgeeks.org/problems/count-the-zeros/0

*/
using System;
public class GFG{
	static public void Main (){
		int testCasesNo=Convert.ToInt32(Console.ReadLine());
			
		for (int i=0;i<testCasesNo;i++)
		{
		  
		   int[] arr= new int[Convert.ToInt32(Console.ReadLine())];
		   string[] strArr= Console.ReadLine().Trim().Split(' ');
		   for (int j=0;j<strArr.Length;j++)
		   {
		       Int32.TryParse(strArr[j], out arr[j]);
		   }
		   int index=Array.IndexOf(arr, 0);
		   if(index>-1)
		   Console.WriteLine(arr.Length-index);
		   else
		   Console.WriteLine(0);
			
		}
	}
}