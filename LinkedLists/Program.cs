//main method



public class Node
{
    int data;
    public Node next;
    public Node(int d)
    {
        this.data = d;
    }

    public void printLinkedList(Node x)
    {
        var current = x;
        while (current != null)
        {
            Console.WriteLine(current.data);
            Console.ReadLine();
            current = current.next;
        }
    }

    static void Main(string[] args)
    {
        Node head = new Node(6);
        Node nodeB = new Node(2);
        Node nodeC = new Node(5);
        Node nodeD = new Node(8);

        head.next = nodeB;
        nodeB.next = nodeC;
        nodeC.next = nodeD;

        head.printLinkedList(head);

    }

}

//namespace LinkedList
//{
//    class Node
//    {
//        public int info;
//        public Node next;

//        public Node(int info)
//        {
//            this.info = info;
//            this.next = null;
//        }
//    }

//    //class MyLinkedList
//    //{
//    //    public Node start;

//    //    public void AddNode(int info)
//    //    {
//    //        Node tempNode = new Node(info);
//    //        if (start == null)
//    //        {
//    //            Console.WriteLine("List is null. Going to add " + tempNode.info);
//    //            start = tempNode;
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Going to add " + tempNode.info);
//    //            Node iter = start;
//    //            while (iter != null && iter.next != null)
//    //            {
//    //                Console.WriteLine("iter is pointing to " + iter.info);
//    //                iter = iter.next;
//    //            }
//    //            Console.WriteLine("Adding next to " + iter.info);
//    //            // Save new node next to the one whose next was null was null
//    //            iter.next = tempNode;
//    //        }
//    //    }

//    //    public void PrintList()
//    //    {
//    //        Node iter = start;
//    //        while (iter != null)
//    //        {
//    //            Console.WriteLine(iter.info + " -> ");
//    //            iter = iter.next;
//    //        }
//    //    }

//    //    public static void Main(string[] args)
//    //    {
//    //        MyLinkedList myLinkedList = new MyLinkedList();
//    //        myLinkedList.AddNode(7);
//    //        myLinkedList.AddNode(12);
//    //        myLinkedList.AddNode(15);
//    //        myLinkedList.AddNode(23);
//    //        myLinkedList.PrintList();
//    //    }
//    //}

//}


