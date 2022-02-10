using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkListMiddleNode
{
    class TortoiseAndHare
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        static void Print(ListNode temp)
        {
            while (temp != null && temp.val > 0)
            {
                Console.Write(temp.val.ToString() + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }

        public static void RunSample()
        {
            ListNode list = new ListNode();

            // populate list
            int count = 1;
            var temp = list;
            int nodes = 6;

            while (count <= nodes)
            {
                temp.val = count;
                if (count != nodes)
                {
                    temp.next = new ListNode();
                }
                temp = temp.next;
                count++;
            }


            // print link list
            Print(list);
            
            // print the middle node
            Print(MiddleNode(list));
        }

       
    }
}
