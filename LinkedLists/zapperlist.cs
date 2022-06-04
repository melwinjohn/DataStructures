using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapperLinkedLists
{
    class Node
    {
        public string info;
        public Node next;

        public Node(string info)
        {
            this.info = info;
            this.next = null;
        }
    }
    internal class zapperlist
    {
        public Node ZapperList(Node head, Node head2)
        {
            var tail = head;
            var  current1 = head.next;
            var current2 = head2;
            var count = 0;
            while (current1 != null && current2 != null)
            {
                if (count % 2 == 0)
                {
                    tail.next = current2;
                    current2 = current2.next;
                }
                else
                {
                    tail.next = current1;
                    current1 = current1.next;
                }
                tail = tail.next;
                count += 1;
            }
            if (current1 != null) { tail.next = current1; }
            if (current2 != null) { tail.next = current2; }
            return head;
        }

        public static void Main(string[] args)
        {

            Node head = new Node("a");
            Node nodeB = new Node("b");
            Node nodeC = new Node("c");
            Node nodeD = new Node("d");
            
            head.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;

            Node nodex = new Node("x");
            Node nodey = new Node("y");
            Node nodez = new Node("z");

            nodex.next = nodey;
            nodey.next = nodez;


            zapperlist ZapperlinkedList = new zapperlist();

            ZapperlinkedList.ZapperList(head, nodex );

        }

    }
}
