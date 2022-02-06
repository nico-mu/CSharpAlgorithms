using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode result = new ListNode(-1);
            result.next = head;
            ListNode leftPointer = result, rightPointer = result;
            while (n > 0)
            {
                rightPointer = rightPointer.next;
                n--;
            }
            while (rightPointer.next != null)
            {
                leftPointer = leftPointer.next;
                rightPointer = rightPointer.next;
            }
            leftPointer.next = leftPointer.next.next;
            return result.next;
        }
    }
}
