// RDG Filings
// You are filling a bucket with water that holds n cups. you can use a one cup or rwo cup measuring
// up as you fill the bucket. Calculate how many distinct ways you can use the measuring cups to fill 
// the bucket. 

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
        numOfWaysToFillBucket = FillTheBucket(50);
        Console.WriteLine("Test Case 5: " + numOfWaysToFillBucket);

        // Test Case 6
        numOfWaysToFillBucket = FillTheBucket(50);
        Console.WriteLine("Test Case 6: " + numOfWaysToFillBucket);
    }

    public static int FillTheBucket(int bucketSize)
    {
        List<int> numbers = new List<int>() { 1, 2 };
        HashSet<string> permutations = new HashSet<string>();
        string oneCup = "1";
        string twoCup = "2";

        sum_up_recursive(numbers, bucketSize, new List<int>());
        //for(int i = 0; i <= bucketSize; i++)
        //{

        //}



        return permutations.Count();
    }

    private static void sum_up_recursive(List<int> numbers, int target, List<int> partial)
    {
        int s = 0;
        foreach (int x in partial) s += x;

        if (s == target)
            Console.WriteLine("sum(" + string.Join(",", partial.ToArray()) + ")=" + target);

        if (s >= target)
            return;

        for (int i = 0; i < numbers.Count; i++)
        {
            List<int> remaining = new List<int>();
            int n = numbers[i];
            for (int j = i + 1; j < numbers.Count; j++) remaining.Add(numbers[j]);

            List<int> partial_rec = new List<int>(partial);
            partial_rec.Add(n);
            sum_up_recursive(remaining, target, partial_rec);
        }
    }
}
