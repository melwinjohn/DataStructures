using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedLists
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
    
    internal class ReverseLinkedList
    {
        public Node Reverse(Node head)
        {
            Node current = head;
            Node prev = null;
            Node next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
        //public static void Main(string[] args)
        //{

        //    Node head = new Node(6);
        //    Node nodeB = new Node(2);
        //    Node nodeC = new Node(5);
        //    Node nodeD = new Node(8);

        //    head.next = nodeB;
        //    nodeB.next = nodeC;
        //    nodeC.next = nodeD;

        //    ReverseLinkedList ReverselinkedList = new ReverseLinkedList();

        //    ReverselinkedList.Reverse(head);

        //}


    }
}
