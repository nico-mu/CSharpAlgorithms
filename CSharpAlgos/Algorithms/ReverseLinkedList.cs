using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;
            return ReverseListHelper(null, head);
        }

        private ListNode ReverseListHelper(ListNode prev, ListNode curr)
        {
            if (curr == null) return prev;
            ListNode next = curr.next;
            curr.next = prev;
            return ReverseListHelper(curr, next);
        }
    }
}
