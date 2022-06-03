using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheValue
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int info)
        {
            this.info = info;
            this.next = null;
        }
    }
    internal class FindingTheValue
    {        
        
        //public bool FindTheValue(Node head, int target)
        //{
        //    var current = head;
        //    while (current != null)
        //    {
        //        if (current.info == target)
        //        {
        //            return true;
        //        }
        //        current = current.next;
        //    }
        //    return false;
        //}

        public bool RecursiveFindTheValue(Node head, int target)
        {
            if (head == null)
            {
                return false;
            }
            if (head.info == target)
            {
                return true;
            }
            return RecursiveFindTheValue(head.next, target);
        }
        public static void Main(string[] args)
        {

            Node head = new Node(6);
            Node nodeB = new Node(2);
            Node nodeC = new Node(5);
            Node nodeD = new Node(8);

            head.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;

            FindingTheValue linkedList = new FindingTheValue();

            linkedList.RecursiveFindTheValue(head,16);

        }
    }
}
