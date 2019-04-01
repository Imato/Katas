using System;

public class Solution {
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
          return null;
    }
}

public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }

      public override string ToString(){
            var str = $"{val}";
            ListNode n = this;
            while(n.next != null)
            {
                  str += $" -> {n.next.val}";
                  n = n.next;
            }

            return str;
      }

      public static implicit operator string(ListNode l){
            return l.ToString();
      }
 }

 public static class Utils{

       public static ListNode AddNext(this ListNode t, ListNode next){
             t.next = next;
             return next;
       }
 }