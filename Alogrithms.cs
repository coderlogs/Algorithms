using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections; 
    
namespace TwoSumAlgoExpert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5};
            //woNumberSum(a,5);
            //TwoNumberSumHash(a, 6);
            SortedSquaredArray(a); 

        }

        //3 : Sorted Squared Arra [Brute Force approach]
        // O(nLogn) time // O(n) space
        [TestMethod]
        public static int[] SortedSquaredArray(int[] array)
        {           
            int[] sortedSquaredArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                sortedSquaredArray[i] = (int)Math.Pow(array[i], 2);                
            }
            Array.Sort(sortedSquaredArray);a
            foreach(var i in sortedSquaredArray)
            {
                Console.WriteLine(i); 
            }
            Console.ReadKey(); 
            return sortedSquaredArray; 
        }
        //3 Sorted Squared Array Optimal approach 



        public static int[] TwoNumberSumPointer(int[] array, int targetSum)
        {
            Array.Sort(array);
            int leftPopinter = 0;
            int rightPointer = array.Length - 1;
            while(leftPopinter < rightPointer)
            {
                var currentSum = array[leftPopinter] + array[rightPointer];  
                if (currentSum == targetSum)
                {
                    return new int[] { array[leftPopinter], array[rightPointer] }; 
                }
                if (currentSum < targetSum)
                {
                    leftPopinter++; 
                }
                if(currentSum > targetSum)
                {
                    rightPointer--; 
                }
            }
            return new int[] { 0 };


        }


        public static int[] TwoNumberSumHash(int[] array, int targetSum)
        {
            Hashtable matches = new Hashtable();
            foreach (var val in array)
            {
                var match = targetSum - val;
                if (matches.Contains(match))
                {
                    return new int[] { match, val };
                }
                else
                {
                    matches.Add(val, true);
                }
            }
            return new int[] { };
        }



            public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int sum = 0;
            for (int i = 0; i < array.Length -1 ; i++)
            {                                                                                                                       
                for (int j = 1; j <= array.Length; j++)
                {
                   if((array[i] + array[j]) == targetSum)                    
                    {
                        Console.WriteLine("   " + sum + "   ");
                        Console.WriteLine( "i=" +array[i].ToString()+  " "+"j="+
                            array[j].ToString()); 
                        return new int[] { array[i],array[j]};
                    }
                    else                    
                    {
                        Console.WriteLine(array[i].ToString());
                        Console.WriteLine(array[j].ToString());
                        Console.WriteLine("SUM="+sum.ToString());
                        Console.WriteLine(sum.ToString("********")); 
                        sum = 0;  }                    
                }
                //sum = 0;             
            }
            if (sum != targetSum)
            {
                sum = 0;
                Console.WriteLine("not found");
                return new int[sum];
            }
            Console.WriteLine(sum.ToString());
            return new int[sum];
        }
    }
}
