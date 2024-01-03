class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        var maxHeight = candles.Max();
        var count = candles.Count(h => h == maxHeight);
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}
