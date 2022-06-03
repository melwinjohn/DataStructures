using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
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
    internal class Recursive_LinkedList
    {
        public void PrintLinkedList( Node head)
        {
            if (head == null)
            {
                return;
            }
            Console.WriteLine(head.info);
            PrintLinkedList(head.next);

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

        //    Recursive_LinkedList linkedList = new Recursive_LinkedList();

        //    linkedList.PrintLinkedList(head);

        //}

    }
}
