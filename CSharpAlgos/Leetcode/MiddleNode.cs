using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class MiddleNode
    {
        public static ListNode SolveMiddleNode(ListNode head)
        {
            ListNode leftPointer = head;
            ListNode rightPointer = head;
            while (rightPointer != null && rightPointer.next != null)
            {
                leftPointer = leftPointer.next;
                rightPointer = rightPointer.next.next;
            }
            return leftPointer;
        }
    }
}
