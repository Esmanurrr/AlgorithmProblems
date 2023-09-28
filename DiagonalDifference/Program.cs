class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int arrLength = arr.Count;
        int ltorSum = 0;
        int rtolSum = 0;

        for (int i = 0; i < arrLength; i++)
        {
            ltorSum += arr[i][i];

            rtolSum += arr[i][arrLength - 1 - i];//[0,2] , [1,1], [2,0]
        }

        //for (int j = 0; j < arrLength; j++)
        //{
        //    if (i == j)
        //    {
        //        ltorSum += arr[j][i];
        //    }
        //}

        //for (int i = 0; i < arrLength; i++)
        //{
        //    for(int j = 0; j < arrLength; j++)
        //    {
        //        if (j == arrLength - i)
        //        {
        //            rtolSum += arr[j][i];
        //        }
        //    }
        //}

        int result = Math.Abs(ltorSum - rtolSum);
        return result;
    }

}

//for (int i = 0; i < arr_rows; i++)
//{
//    for (int j = 0; j < arr_columns; j++)
//    {
//        if (j == arr_rows - i)
//            sum2 += arr[i][j];
//    }
//}
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);

    }
}
