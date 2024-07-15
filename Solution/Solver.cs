
namespace Solution;

public static class Solver
{
    public static int[] TwoSum(int[] input, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < input.Length; i++)
        {
            var complement = target - input[i];

            if (dict.TryGetValue(complement, out int value))
            {
                return [value, i];
            }

            dict.TryAdd(input[i], i);
        }

        return [];
    }
}
