using System.Reflection.PortableExecutable;

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        //list a = 3 5 7
        //list b = 9 5 2

        List<int> result = new();
        int aSum = 0;
        int bSum = 0;

        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                aSum += 1;
            }
            else if (b[i] > a[i])
            {
                bSum += 1;
            }
           
        }
        result.Add(aSum);
        result.Add(bSum);
        return result;
    }

}


class Solution
{
    public static void Main(string[] args)
    {

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));

    }
}