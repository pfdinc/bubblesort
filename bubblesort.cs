using System;

namespace bubbleSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] ht = { 2, 3, 4, 5, 64, 3, 1, -5, 345,65,33,212,5,7,868,98,98,7,543,3,1 };
            Console.WriteLine("Oraginal array");
            print(ht);
            Console.WriteLine("Descending Bubblesort");
            bubblesortdDescending(ht);
            Console.WriteLine("Ascending Bubble sort");
            bubblesortAscending(ht);
        
        }

        public static void bubblesortAscending(int[] intArray)
        {

            int lenghtIntArray = intArray.Length;

            for (int lastunsortedArray = lenghtIntArray ; lastunsortedArray > 0; lastunsortedArray--)
            {
                for (int i = 0; i < lenghtIntArray -1; i++)
                {
                    //compairs the index and the next index in the array array 
                    if (intArray[i] > intArray[i+1])
                    {
                        swap(intArray, i, i + 1);
                    }
                }
            }
            print(intArray);
        }

        
        public static void bubblesortdDescending(int[] intArray)
        {

            int lenghtIntArray = intArray.Length;

            for (int lastunsortedArray = lenghtIntArray; lastunsortedArray > 0; lastunsortedArray--)
            {

                for (int i = 0; i < lenghtIntArray - 1; i++)
                {

                    if (intArray[i] < intArray[i + 1])
                    {
                        swap(intArray, i, i + 1);
                    }
                }
            }
            print(intArray);
        }

        
        public static void print(int[] arr){
            
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            
            Console.WriteLine();
        } 
        

        public static void swap(int[] arrayToSwap, int x, int y ){

            int temp;
            //if i amd i+1 is a match return 
            if (arrayToSwap[x] == arrayToSwap[y])
                return;
                
                temp = arrayToSwap[x];
                arrayToSwap[x] = arrayToSwap[y];
                arrayToSwap[y] = temp;

        }
    }
}
