using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Solutions for TwoSums problems");
            Solution sol = new Solution();
            Console.WriteLine("[{0}]", string.Join(", ", sol.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine("[{0}]", string.Join(", ", sol.twoSumHash(new int[] { 2, 7, 11, 15 }, 13)));
            ListNode l1 = new ListNode(2);
            ListNode l1_2 = new ListNode(4);
            ListNode l1_3 = new ListNode(3);
            l1.next = l1_2;
            l1_2.next = l1_3;
            ListNode l2 = new ListNode(5);
            ListNode l2_2 = new ListNode(6);
            ListNode l2_3 = new ListNode(4);
            l2.next = l2_2;
            l2_2.next = l2_3;
            ListNode rv = sol.AddTwoNumbers(l1, l2);
            while(rv.next != null)
            {
                Console.WriteLine("-> {0} ", rv.val);
                if(rv.next.next == null)
                {
                    Console.WriteLine("-> {0} ", rv.next.val);
                }
                rv = rv.next;
            }
            Console.WriteLine("[{0}]", rv);
        }
    }
}
