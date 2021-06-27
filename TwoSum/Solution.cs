using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        //暴力法
        //public int[] TwoSum(int[] nums, int target)
        //{
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                int[] res = new int[] { i, j };
        //                return res;
        //            }
        //        }
        //    }
        //    return new int[] {0, 0};
        //}

        //哈希表
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var otherNumber = target - nums[i];

                if (dict.TryGetValue(otherNumber, out var index))
                    return new int[2] { index, i };

                dict.Add(nums[i], i);
            }

            return new int[2];
        }

        public static void Main()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 18;

            int[] res = TwoSum(nums, target);
            System.Console.WriteLine("{0}, {1}", res[0], res[1]);
        }
    }
}
