class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int arrLength = arr.Count;
        decimal positive = 0;
        decimal negative = 0;
        decimal zero = 0;

        foreach (var a in arr)
        {
            if (a > 0)
                positive++;
            else if(a < 0)
                negative++;
            else
                zero++;
        }

        decimal pResult = positive / arrLength;
        decimal nResult = negative / arrLength;
        decimal zResult = zero / arrLength;

         Console.WriteLine($"{pResult}\n{nResult}\n{zResult}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}