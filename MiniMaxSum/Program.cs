using System.Linq;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        Int64 min = arr.Min();
        Int64 max = arr.Max();
        Int64 minSum = 0;
        Int64 maxSum = 0;


        foreach (Int64 i in arr)
        {
            if (i == min)
                continue;
            maxSum += i;
        }
        
        
        foreach (Int64 i in arr)
         {
            if (i == max)
                continue;
            minSum += i;
        }

        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}