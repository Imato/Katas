using System;

class Program
{
    static void Main(string[] args)
    {
        var l1 = new ListNode(2);
        l1.AddNext(new ListNode(4)).AddNext(new ListNode(3));
        var l2 = new ListNode(5);
        l2.AddNext(new ListNode(6)).AddNext(new ListNode(4));
        Add(l1, l2);
    }

    private static void Add(ListNode l1, ListNode l2)
    {
        var r = Solution.AddTwoNumbers(l1, l2);
        Console.WriteLine($"{l1 ?? "null"} + {l2 ?? "null"} = {r ?? "null"}");
    }
}