// RDG Filings
// You are filling a bucket with water that holds n cups. you can use a one cup or rwo cup measuring
// up as you fill the bucket. Calculate how many distinct ways you can use the measuring cups to fill 
// the bucket. 

//1-> (1 - 1) + (1 - 2)
//2-> (2 - 1) + (2 - 2)
//3-> (3 - 1) + (3 - 2)
//4-> (4 - 1) + (4 - 2)

//n = 4

using System;

class rdg
{
    private static void Main(String[] args)
    {
        Console.WriteLine("Test Cases Below:");
        int numOfWaysToFillBucket = 0;

        // Test Case 1
        numOfWaysToFillBucket = FillTheBucket(1);
        Console.WriteLine("Test Case 1: " + numOfWaysToFillBucket);

        // Test Case 2
        numOfWaysToFillBucket = FillTheBucket(2);
        Console.WriteLine("Test Case 2: " + numOfWaysToFillBucket);

        // Test Case 3
        numOfWaysToFillBucket = FillTheBucket(3);
        Console.WriteLine("Test Case 3: " + numOfWaysToFillBucket);

        // Test Case 4
        numOfWaysToFillBucket = FillTheBucket(0);
        Console.WriteLine("Test Case 4: " + numOfWaysToFillBucket);

        // Test Case 5
        numOfWaysToFillBucket = FillTheBucket(51);
        Console.WriteLine("Test Case 5: " + numOfWaysToFillBucket);

        // Test Case 6
        numOfWaysToFillBucket = FillTheBucket(5);
        Console.WriteLine("Test Case 6: " + numOfWaysToFillBucket);
    }

    public static int FillTheBucket(int bucketSize)
    {
        if (bucketSize >= 1 && bucketSize <= 50)
            return countWays(bucketSize);
            //return countWays(bucketSize + 1);
        else
            return 0;
    }

    public static int countWays(int n)
    {
        if (n == 0)
            return 0;

        int[] cup = new int[n + 5];
        cup[1] = 1;
        cup[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            cup[i] = cup[i - 1] + cup[i - 2];
        }

        return cup[n]; 


        //if (n <= 1)
        //    return n;
        //return countWays(n - 1) + countWays(n - 2);
    }

}
