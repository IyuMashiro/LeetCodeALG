using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class ALG2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode result = new ListNode();
            ListNode now = result;

            while (l1 != null && l2 != null)
            {

                
                int x = l1 != null ? l1.val : 0;
                int y = l2 != null ? l2.val : 0;
                int addition = x + y;
               
                if (carry != 0)
                {
                    addition += carry;
                    carry = 0;
                }
                if (addition >= 10)
                {
                    carry = addition/10;
                    addition = addition%10;
                }

                now.val = addition;
                
                

                if(l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                if (l1 != null || l2 != null)
                {
                    now.next = new ListNode();
                    now = now.next;
                }
                
            }

            if (carry != 0)
            {
                now.next = new ListNode(carry);
            }
            return result;
        }
    }

    
 
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        { 
            this.val = val;
            this.next = next;
        }
    }
    
}
