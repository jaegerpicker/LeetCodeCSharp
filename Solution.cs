using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l1next = l1.next;
            ListNode l2next = l2.next;
            string l1string = l1.val.ToString();
            string l2string = l2.val.ToString();
            while(l1next.next != null)
            {
                l1string += l1next.val.ToString();
                if(l1next.next.next == null)
                {
                    l1string += l1next.next.val.ToString(); 
                }
                l1next = l1next.next;
            }
            while(l2next.next != null)
            {
                l2string += l2next.val.ToString();
                if(l2next.next.next == null)
                {
                    l2string += l2next.next.val.ToString();
                }
                l2next = l2next.next;
            }
            int l1val = int.Parse(new string(l1string.Reverse().ToArray()));
            int l2val = int.Parse(new string(l2string.Reverse().ToArray()));
            string val = (l1val + l2val).ToString();
            Console.WriteLine(val);
            var valArr = val.Reverse().ToArray();
            ListNode[] retVal = new ListNode[valArr.Length];
            retVal[0] = new ListNode(int.Parse(new string(valArr[0].ToString())));
            for (int i = 1; i < valArr.Length; i++)
            {
                int valNext = int.Parse(new string(valArr[i].ToString()));
                retVal[i] = new ListNode(valNext);
                retVal[i - 1].next = retVal[i];
            }
            return retVal[0];
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] lessThanTarget = nums.Where(c => c < target).ToArray();
            for(int i = 0; i < lessThanTarget.Length; i++)
            {
                for(int j = 0; j < lessThanTarget.Length; j++)
                {
                    if((lessThanTarget[i] + lessThanTarget[j]) % target == 0)
                    {
                        Console.WriteLine("Solution found!");
                        Console.WriteLine("[{0}: {1}]", i, lessThanTarget[i]);
                        Console.WriteLine("[{0}: {1}]", j, lessThanTarget[j]);
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No two sum solution");
        }

        public int[] twoSumHash(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    Console.WriteLine("Solution found!");
                    Console.WriteLine("[{0}: {1}]", i, nums[i]);
                    Console.WriteLine("map: [{0}]", string.Join(", ", map.Keys.ToList()));
                    Console.WriteLine("[{0}: {1}]", map.FirstOrDefault(x => x.Value == complement).Key, complement);
                    return new int[] { map.FirstOrDefault(x => x.Value == complement).Key, i };
                }
                map.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
